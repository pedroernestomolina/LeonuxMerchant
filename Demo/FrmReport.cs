using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace Demo
{

    public partial class FrmReport : Form
    {


        public FrmReport()
        {
            InitializeComponent();
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
        }

        private void FrmReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Salir();
            }
        }

        private void BT_CONSULTA_ULT_TRANSACCION_Click(object sender, EventArgs e)
        {
            if (Program._idUltTransaccion != "00000000-0000-0000-0000-000000000000")
            {
                var rt = UltimaTransaccion();

                var frm = new Form();
                frm.TopMost = true;
                var mg = "";
                mg += "MENSAJE: " + rt.message + Environment.NewLine;
                mg += "FECHA Y HORA: " + rt.datetime.ToString() + Environment.NewLine;
                mg += "MONTO: " + rt.amount + Environment.NewLine;
                mg += "REFERENCIA: " + rt.reference + Environment.NewLine;
                mg += "TERMINAL: " + rt.terminal + Environment.NewLine;
                mg += "LOTE: " + rt.lote + Environment.NewLine;
                mg += "TICKET: " + rt.sequence + Environment.NewLine;
                //mg += "ID: " + rt.id + Environment.NewLine;
                if (rt.success)
                {
                    MessageBox.Show(frm, mg, "*** OK ***", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show(frm, mg, "*** ERROR ***", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                var text = new List<string>();
                var s = "";

                s = rt.message;
                text.Add("Mensaje: " + s);

                s = rt.datetime.ToString();
                text.Add("Fecha y Hora: " + s);

                s = rt.reference;
                text.Add("Referencia: " + s);

                s = rt.amount.Value.ToString("n2");
                text.Add("Monto: " + s);

                s = rt.id;
                //text.Add("Id:" + s);

                s = rt.lote.ToString();
                text.Add("Lote: " + s);

                text.Add("------------------------------");
                text.Add("------------------------------");

                if (Program._ImprimirActivado) 
                {
                    Program._ctrlImprimir.ImprimirTexto(text);
                }
            }
            else 
            {
                Helpers.Msg.Error("SERVIDOR REMOTO NO RESPONDIO");
            }
        }

        private RespuestaUltConsulta UltimaTransaccion()
        {
            var rt = new RespuestaUltConsulta();
            try
            {
                WebClient webClient = new WebClient();
                webClient.QueryString.Add("KeyId", Program._KeyId);
                webClient.QueryString.Add("PublicKeyId", Program._PublicKeyId);
                webClient.QueryString.Add("Id", Program._idUltTransaccion);
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                string result = webClient.DownloadString(Program._urlUltimaTransaccion);
                rt = JsonConvert.DeserializeObject<RespuestaUltConsulta>(result);
            }
            catch (Exception e)
            {
                rt.success = false;
                rt.message = e.Message;
            }
            return rt;
        }

        private void BT_CONSULTA_PAGO_LOTE_Click(object sender, EventArgs e)
        {
            var r01 = PagoLote();
            if (r01 != "")
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(r01);
                MemoryStream stream = new MemoryStream(byteArray);

                var x = 0;
                var texto = new List<string>();
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        texto.Add(values[0]);
                        texto.Add(values[1].ToString() + ", ");
                        texto.Add(values[2].ToString() + ", ");
                        texto.Add(values[3].ToString() + ", ");
                        texto.Add(values[5].ToString() + ", " + values[6].ToString() + ", " + values[7].ToString() + ", " + values[8].ToString());
                        texto.Add(values[9].ToString() + ", " + values[10].ToString() + ", " + values[11].ToString());
                        texto.Add(values[12].ToString() + ", " + values[13].ToString() + ", " + values[14].ToString() + ", " + values[15].ToString());
                    }
                    texto.Add("------------------------------");
                    texto.Add("------------------------------");
                }

                if (Program._ImprimirActivado) 
                {
                    Program._ctrlImprimir.ImprimirTexto(texto);
                }
            }
        }

        private string PagoLote()
        {
            string result = "";
            try
            {
                WebClient webClient = new WebClient();
                webClient.QueryString.Add("KeyId", Program._KeyId);
                webClient.QueryString.Add("PublicKeyId", Program._PublicKeyId);
                webClient.QueryString.Add("Lote", Program._loteTransaccion);
                webClient.QueryString.Add("Global", "false");
                webClient.QueryString.Add("Terminal", Program._Terminal);
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                result = webClient.DownloadString(Program._urlReports);
            }
            catch (Exception e)
            {
                Helpers.Msg.Error(e.Message);
            }
            return result;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
        }

    }

}