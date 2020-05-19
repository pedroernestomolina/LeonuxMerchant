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

    public partial class FrmAnulacion : Form
    {

        public FrmAnulacion()
        {
            InitializeComponent();
        }

        private void BT_CONSULTA_PAGO_LOTE_Click(object sender, EventArgs e)
        {
            var frm = new Form();
            frm.TopMost = true;

            var msg = MessageBox.Show(frm, "Anular Ultimo Pago Realizado ?", "*** ALERTA ***", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    var modo = true;
                    var xr = Program._cliente.GenerarPaqueteCompra(Program._ultCI, Program._ultMonto, Program._KeyPinPad, Program._ultTipoCta, modo, Program._Terminal);
                    if (!xr.Exito)
                    {
                        var xmsg = xr.Mensaje + Environment.NewLine + xr.CodigoRespuesta.ToString();
                        throw new Exception(xmsg);
                    }

                    var respuesta = InstaPagoAnulacion(Program._idUltTransaccion, xr.Paquete);
                    var xr01 = Program._cliente.ProcesarRespuesta(xr.Paquete, respuesta);
                    if (xr01.Exito)
                    {
                        var rt = xr01.Paquete;

                        var mg = "";
                        mg += "CODIGO: " + rt.code + Environment.NewLine;
                        mg += "MENSAJE: " + rt.message + Environment.NewLine;
                        mg += "FECHA Y HORA: " + rt.datetime.ToString() + Environment.NewLine;
                        mg += "MONTO: " + rt.amount + Environment.NewLine;
                        mg += "REFERENCIA: " + rt.reference + Environment.NewLine;
                        mg += "TERMINAL: " + rt.terminal + Environment.NewLine;
                        mg += "LOTE: " + rt.lote + Environment.NewLine;
                        mg += "TICKET: " + rt.sequence + Environment.NewLine;
                        mg += "ID: " + rt.id + Environment.NewLine;
                        if (rt.success)
                        {
                            MessageBox.Show(frm, mg, "*** OK ***", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show(frm, mg, "*** ERROR ***", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }

                        var text = new List<string>();
                        text.Add("CODIGO: " + rt.code + "-" + rt.message);
                        text.Add("FECHA: " + rt.datetime.ToString());
                        text.Add("REFERENCIA: " + rt.reference);
                        text.Add("MONTO: " + rt.amount);
                        text.Add("AID: " + rt.id);
                        text.Add("LOTE: " + rt.lote.ToString());
                        text.Add("ID: " + rt.id);
                        text.Add("------------------------------");
                        text.Add("------------------------------");

                        if (Program._ImprimirActivado)
                        {
                            Program._ctrlImprimir.ImprimirTexto(text);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Helpers.Msg.Error(ex.Message);
                }
            }
            Salir();
        }

        private void Salir()
        {
            this.Close();
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private String InstaPagoAnulacion(string id, string paquete)
        {
            var result = "";
            try
            {
                WebRequest __webrequest = WebRequest.Create(Program._urlPagoAnulacion) as HttpWebRequest;
                string Postdata = string.Format("KeyId={0}&PublicKeyId={1}&IdPayment={2}&DataBlock={3}", Program._KeyId, Program._PublicKeyId, id, paquete);
                byte[] __posDataStream = Encoding.UTF8.GetBytes(Postdata);

                __webrequest.Method = "DELETE";
                __webrequest.ContentType = "application/x-www-form-urlencoded";
                __webrequest.ContentLength = __posDataStream.Length;
                Stream __requestStream = __webrequest.GetRequestStream();
                __requestStream.Write(__posDataStream, 0, __posDataStream.Length);
                __requestStream.Close();

                WebResponse __webresponse = __webrequest.GetResponse();
                Stream dataStream = __webresponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                var rt = reader.ReadToEnd();
                return rt;
            }
            catch (Exception e)
            {
                Helpers.Msg.Error(e.Message);
            }
            return result;
        }

    }

}