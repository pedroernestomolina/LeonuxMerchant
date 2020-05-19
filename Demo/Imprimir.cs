using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;


namespace Demo
{

    public class Imprimir
    {


        private SerialPort spPuertoSerie;
        private string respuesta;
        private bool exito = false;
        private System.Timers.Timer timer;
        private int intentos = 0;


        public Imprimir()
        {
            spPuertoSerie = new SerialPort("COM" + Program._ptoFiscal.ToString(), 9600, Parity.Even, 8, StopBits.One);
            spPuertoSerie.DataReceived += new SerialDataReceivedEventHandler(spPuertoSerie_DataReceived);
        }

        public void ImprimirTexto(List<string> texto)
        {
            try
            {
                spPuertoSerie.Open();

                foreach (var linea in texto)
                {
                    var trama = TramaData("800" + linea);
                    spPuertoSerie.Write(trama, 0, trama.Length);
                    if (!EsperaRespuesta())
                    {
                        throw new Exception("PROBLEMA AL IMPRIMIR");
                    }
                }
                var trama2 = TramaData("810");
                spPuertoSerie.Write(trama2, 0, trama2.Length);
                if (!EsperaRespuesta())
                {
                    throw new Exception("PROBLEMA AL IMPRIMIR");
                }
            }
            catch (Exception ex)
            {
                Helpers.Msg.Error(ex.Message);
            }
            finally 
            {
                try
                {
                    spPuertoSerie.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void spPuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            respuesta += spPuertoSerie.ReadExisting();
        }

        private bool EsperaRespuesta()
        {
            respuesta = "";
            exito = false;
            intentos = 0;

            timer = new System.Timers.Timer();
            timer.Interval = 200;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            do
            {
            }
            while (!exito && intentos <= 3);
            timer.Stop();

            return exito;
        }

        private void timer_Elapsed(object sender, EventArgs e)
        {
            intentos += 1;
            timer.Enabled = false;
            respuesta += spPuertoSerie.ReadExisting();
            if (respuesta.Contains((char)6) || respuesta.Contains((char)3) || respuesta.Contains((char)4))
            {
                exito = true;
            }
            else
            {
                timer.Enabled = true;
            }
        }

        private char[] TramaData(string p)
        {
            var cad = p + (char)3;
            var xcad = cad.ToCharArray();
            var lrc = (int)xcad[0];

            for (int x = 1; x <= xcad.Length - 1; x++)
            {
                lrc = lrc ^ (int)xcad[x];
            }
            cad = (char)2 + cad + (char)lrc;

            return cad.ToCharArray();
        }

        //private void ImpresionPrueba2()
        //{
        //    byte[] mBuffer = new byte[6];
        //    mBuffer[0] = 0x02;
        //    mBuffer[1] = 0x49;
        //    mBuffer[2] = 0x30;
        //    mBuffer[3] = 0x58;
        //    mBuffer[4] = 0x03;
        //    mBuffer[5] = 0x22;

        //    SerialPort spPuertoSerie = new SerialPort("COM"+Program._ptoFiscal.ToString(), 9600, Parity.Even, 8, StopBits.One);
        //    spPuertoSerie.Open();

        //    spPuertoSerie.Write(mBuffer, 0, mBuffer.Length);

        //    spPuertoSerie.Close();
        //}

        //private void ImpresionPrueba()
        //{
        //    var texto = new List<string>();
        //    texto.Add("BANESCO"+Environment.NewLine);
        //    texto.Add("COMPRA"+Environment.NewLine);
        //    texto.Add("BOGA MARKET, CA"+Environment.NewLine);
        //    texto.Add("PARAPARAL - LOS GUAYOS"+Environment.NewLine);
        //    texto.Add("J-30714331-2"+Environment.NewLine);

        //    var r01 = Program._impFiscal.TextoNoFiscal(texto);
        //    if (r01.Resultado == LibFoxFiscal.Resultado.EnumResultado.ERROR)
        //    {
        //        Helpers.Msg.Error(r01.MensajeError);
        //    }
        //}

    }

}