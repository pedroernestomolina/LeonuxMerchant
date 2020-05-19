using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace Demo
{

    public partial class FrmPago : Form
    {


        private bool estatus_LecturaArchivo; 


        public FrmPago()
        {
            InitializeComponent();
            Inicializar();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicializar()
        {
            estatus_LecturaArchivo = false;
            BT_PAGO.Enabled = true;
            TB_MONTO.Limpiar();
            PB_ERROR.Visible = false;
            PB_OK.Visible = false;
            TB_MONTO.Text = "0.0";
            TB_CIRIF.Text = "";
            TB_NOMBRE.Text = "VENTA DETAL";
            CB_TIPO_CUENTA.SelectedIndex = 0;
            TB_MONTO.Select();
            L_MODO.Text = "Modo: PAGO";
            this.Text = "Merchant ( Pago )";
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void FrmPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
            }
        }

        private void Salir()
        {
            this.Close();
        }

        private void BT_PAGO_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            var monto = decimal.Parse(TB_MONTO.Text);
            var ci = TB_CIRIF.Text.Trim().ToUpper();
            var tipoCta = MerchantPOS.Objetos.TipoCuenta.Ahorro;
            var nombre = TB_NOMBRE.Text.Trim().ToUpper();
            switch (CB_TIPO_CUENTA.SelectedIndex)
            { 
                case 0:
                    tipoCta = MerchantPOS.Objetos.TipoCuenta.Ahorro;
                    break;
                case 1:
                    tipoCta = MerchantPOS.Objetos.TipoCuenta.Corriente;
                    break;
                case 2:
                    tipoCta = MerchantPOS.Objetos.TipoCuenta.Credito;
                    break;
                case 3:
                    tipoCta = MerchantPOS.Objetos.TipoCuenta.FAL;
                    break;
            }

            if (VerificarPagoOk(ci,tipoCta,nombre,monto))
            {
                BT_PAGO.Enabled = false;
                try
                {
                    var modo = false; 
                    var xr = Program._cliente.GenerarPaqueteCompra(ci, monto, Program._KeyPinPad, tipoCta, modo, Program._Terminal);
                    if (!xr.Exito)
                    {
                        var msg=xr.Mensaje + Environment.NewLine + xr.CodigoRespuesta.ToString();
                        throw new Exception(msg);
                    }
                   
                    var respuesta = InstaPago(xr.Paquete, monto, nombre, ci);
                    var xr02 = Program._cliente.ProcesarRespuesta(xr.Paquete, respuesta);
                    if (xr02.Exito)
                    {
                        var rt = xr02.Paquete;
                        var texto = new List<string>();
                        //var xmonto = decimal.Parse(rt.amount).ToString("n2");
                        var xmonto = monto.ToString("n2");

                        texto.Add("BANESCO");
                        texto.Add("COMPRA");
                        texto.Add("BOGA MARKET, CA");
                        texto.Add("PARAPARAL - LOS GUAYOS");
                        texto.Add("J-30714331-2");
                        texto.Add("0000000000000"+"   "+Program._Terminal);
                        texto.Add("FECHA: "+rt.datetime.ToString());
                        texto.Add("NRO CUENTA: "+rt.cardnumber );
                        texto.Add("NRO. REF: "+ rt.reference + "   LOTE: "+rt.lote);
                        texto.Add("APROBACION: " + rt.approval);
                        texto.Add("SECUENCIA: " + rt.sequence);
                        texto.Add("TC: " + rt.tc+"   NA: "+rt.na);
                        texto.Add("TVR: " + rt.tvr + "   TSI: " + rt.tsi);
                        texto.Add("AID: " + rt.aid);
                        texto.Add("");
                        texto.Add("MONTO BS.: " + xmonto);
                        texto.Add("");
                        texto.Add("RIF: J-07013380-5");
                        texto.Add(rt.code+"-"+rt.message);
                        texto.Add(rt.cardline);
                        texto.Add("ARQC: " + rt.arqc );
                        //texto.Add("ID: " + rt.id );

                        var msg = "";
                        msg += "FECHA: " + rt.datetime.ToString() + Environment.NewLine;
                        msg += "NRO. REF: " + rt.reference + "   LOTE: " + rt.lote + Environment.NewLine;
                        msg += "APROBACION: " + rt.approval+ Environment.NewLine;
                        msg += "SECUENCIA: " + rt.sequence + Environment.NewLine;
                        msg += "TC: " + rt.tc+"   NA: "+rt.na + Environment.NewLine;
                        msg += "TVR: " + rt.tvr + "   TSI: " + rt.tsi + Environment.NewLine;
                        msg += "AID: " + rt.aid + Environment.NewLine;
                        //msg += "ID: " + rt.id + Environment.NewLine;
                        msg += Environment.NewLine;
                        msg += "MONTO BS.: " + xmonto + Environment.NewLine;
                        msg += Environment.NewLine;
                        msg += rt.code+"-"+rt.message+Environment.NewLine;
                        msg += rt.cardline + Environment.NewLine;

                        if (rt.id != null)
                        {
                            Program._idUltTransaccion = rt.id;
                            Program._ultCI=ci;
                            Program._ultMonto=monto;
                            Program._ultTipoCta = tipoCta;

                            var rp=ActualizarIdTransaccion(rt.id);
                            if (rp.Result == EnumResult.isError) 
                            {
                                Helpers.Msg.Error(rp.Mensaje);
                            }
                        }
                        if (rt.lote != null)
                        {
                            Program._loteTransaccion = rt.lote;
                            var rp=ActualizarLote(rt.lote);
                            if (rp.Result == EnumResult.isError)
                            {
                                Helpers.Msg.Error(rp.Mensaje);
                            }
                        }

                        if (Program._ImprimirActivado) 
                        {
                            Program._ctrlImprimir.ImprimirTexto(texto);
                        }
                                               
                        if (rt.success)
                        {
                            PB_ERROR.Visible = false;
                            PB_POS.Visible = false;
                            PB_OK.Visible = true;

                            GrabarArchivo(monto, rt.lote, rt.reference);
                            var frm = new Form();
                            frm.TopMost = true;
                            MessageBox.Show(frm, msg, "*** OK ***", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Salir();
                        }
                        else
                        {
                            GrabarArchivo(0, "", "");
                            throw new Exception(msg);
                        }
                    }
                    else
                    {
                        throw new Exception(xr02.Mensaje + Environment.NewLine + xr02.CodigoRespuesta.ToString());
                    }
                }
                catch (Exception e)
                {
                    PB_POS.Visible = false;
                    PB_OK.Visible = false;
                    PB_ERROR.Visible = true;
                    Helpers.Msg.Error(e.Message);
                    Salir();
                }
            }
        }

        private void GrabarArchivo(decimal monto, string lote, string referencia)
        {
            try
            {
                var csv = new StringBuilder();
                var newLine = string.Format("{0}\t{1}\t{2}", monto.ToString("0.00").Replace(",","."), lote, referencia);
                csv.AppendLine(newLine);
                File.WriteAllText(Program._filePath+@"\data.txt", csv.ToString());
            }
            catch (Exception e)
            {
                Helpers.Msg.Error(e.Message);
            }
        }

        private void LeerArchivo()
        {
            try
            {
                string path = Program._filePathLectura+@"\pos.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    var line = sr.ReadLine();
                    if (line != null) 
                    {
                        var data = line.Split((char)9);
                        if (data.Length>=1)
                        {
                            if (data[0].Trim() != "")
                            {
                                TB_MONTO.Text = data[0].Trim().Replace('.', ',');
                            }
                            if (data[1].Trim() != "")
                            {
                                TB_CIRIF.Text = data[1].Trim().Substring(1);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                estatus_LecturaArchivo = true;
            }
        }

        private bool VerificarPagoOk(string ci, MerchantPOS.Objetos.TipoCuenta tipocta , string nombre, decimal monto)
        {
            var r = true;
            if (ci == "" || nombre == "" || monto <= 0)
            {
                TB_MONTO.Select();
                Helpers.Msg.Alerta("Campos Incorrecto, Verifique Por Favor");
                r=false;
            }
            return r;
        }

        private Resultado ActualizarIdTransaccion(string p)
        {
            var rt = new Resultado();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = root.SelectSingleNode("descendant::IdUltTransaccion");
                myNode.InnerText = p;
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");
            }
            catch (Exception e)
            {
                rt.Mensaje = e.Message;
                rt.Result = EnumResult.isError;
            }
            return rt;
        }

        private Resultado ActualizarLote(string p)
        {
            var rt = new Resultado();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = root.SelectSingleNode("descendant::LoteTransaccion");
                myNode.InnerText = p;
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");
            }
            catch (Exception e)
            {
                rt.Mensaje = e.Message;
                rt.Result = EnumResult.isError;
            }
            return rt;
        }

        private string InstaPago(string p, decimal monto, string nombreRazonSocial, string cirif)
        {
            var rt = "";
            try
            {
                WebRequest __webrequest = WebRequest.Create(Program._urlPago) as HttpWebRequest;
                string Postdata = string.Format("KeyId={0}&PublicKeyId={1}&Amount={2}&Description={3}&CardHolder={4}&CardNumber={5}" +
                    "&ExpirationDate={6}&CardHolderId={7}&Statusid={8}&DataBlock={9}", Program._KeyId, Program._PublicKeyId, monto.ToString().Replace(',','.'),
                    "PAGO", nombreRazonSocial, "4111111111111111", "12/2025", cirif, "2", p);
                byte[] __posDataStream = Encoding.UTF8.GetBytes(Postdata);

                __webrequest.Method = "POST";
                __webrequest.ContentType = "application/x-www-form-urlencoded";
                __webrequest.ContentLength = __posDataStream.Length;
                Stream __requestStream = __webrequest.GetRequestStream();
                __requestStream.Write(__posDataStream, 0, __posDataStream.Length);
                __requestStream.Close();

                WebResponse __webresponse = __webrequest.GetResponse();
                Stream dataStream = __webresponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                rt= reader.ReadToEnd();
            }
            catch (Exception e)
            {
                Helpers.Msg.Error(e.Message);
            }
            return rt ;
        }
     
        private void TB_MONTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void TB_CIRIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        private void FrmPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inicializar();
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPago_Activated(object sender, EventArgs e)
        {
            var ancho = Screen.PrimaryScreen.Bounds.Width;
            if (ancho <= 1024)
            {
                this.Left = 615;
                this.Top = 275;
            }
            else 
            {
                this.Left = 855;
                this.Top = 275;
            }

            if (this.Visible) 
            {
                if (!estatus_LecturaArchivo) 
                {
                    LeerArchivo();
                }
            }
        }
              
    }

}