using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Demo
{

    static class Program
    {

        static public MerchantPOS.POS.Cliente _cliente;

        static public string _KeyId = "";
        static public string _PublicKeyId = "";
        static public string _Terminal = "";

        static public string _KeyPinPad = "";
        static public string _idUltTransaccion = "";
        static public string _loteTransaccion = "";

        static public int _ptoFiscal = 0;

        static public string _urlLogon = "https://api.instapago.com/pos";
        static public string _urlPago = "https://api.instapago.com/pos";
        static public string _urlPagoAnulacion = "https://api.instapago.com/pos";
        static public string _urlUltimaTransaccion = "https://api.instapago.com/payment";
        static public string _urlReports = "https://api.instapago.com/reports";
        static public string _urlCierre = "https://api.instapago.com/posbatch";

        static public string _ultCI = "";
        static public decimal _ultMonto = 0.0m;
        static public MerchantPOS.Objetos.TipoCuenta _ultTipoCta;

        static public string _filePath = "";
        static public string _filePathLectura = "";

        static public Imprimir _ctrlImprimir;
        static public bool _ImprimirActivado;

        //{"success":true,"message":"Rechazado","id":"4527f550-d80c-49d8-96a0-746296df7e0f","code":"201","reference":"000274",
        //"voucher":"","ordernumber":"","sequence":"012447090274","approval":"000000","lote":"369","responsecode":"91",
        //"deferred":false,"datetime":"1/24/2020 3:14:54 PM","amount":"1.00","authid":null,"idmerchant":null,"terminal":null}
        //https://test.instapago.com/thanospos/pos?KeyId=47F7A141-FA02-4854-B84C-793003499BAA&PublicKeyId=d8d1ff0dfcaaee2579abde830e873df2&Terminal=20124709&EMVKey=false


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            _cliente = new MerchantPOS.POS.Cliente();

            var r01 = CargarXml();
            if (r01.Result == EnumResult.isOk)
            {
                Program._ImprimirActivado = false;
                if (Program._ptoFiscal > 0) 
                {
                    Program._ImprimirActivado = true;
                }
                _ctrlImprimir = new Imprimir();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = new Frm();
                Application.Run(new Frm());
            }
            else 
            {
                MessageBox.Show(r01.Mensaje, "*** ALERTA ***", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Exit();
            }
        }

       static private Resultado CargarXml()
        {
            var result = new Resultado();

            try
            {
                var doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");

                if (doc.HasChildNodes)
                {
                    foreach (XmlNode nd in doc)
                    {
                        if (nd.LocalName.ToUpper().Trim() == "CONFIGURACION")
                        {
                            foreach (XmlNode nv in nd.ChildNodes)
                            {
                                if (nv.LocalName.ToUpper().Trim() == "KEYID")
                                {
                                    _KeyId = nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "PUBLICKEYID")
                                {
                                    _PublicKeyId = nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "TERMINAL")
                                {
                                    _Terminal= nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "KEYPINPAD")
                                {
                                    _KeyPinPad = nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "IDULTTRANSACCION")
                                {
                                    _idUltTransaccion = nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "LOTETRANSACCION")
                                {
                                    _loteTransaccion= nv.InnerText.Trim();
                                }
                                if (nv.LocalName.ToUpper().Trim() == "PTO_FISCAL")
                                {
                                    if (nv.InnerText.Trim() != "") 
                                    {
                                        _ptoFiscal = int.Parse(nv.InnerText.Trim());
                                    }
                                }
                                if (nv.LocalName.ToUpper().Trim() == "LECTURAARCHIVO")
                                {
                                    if (nv.InnerText.Trim() != "")
                                    {
                                        _filePathLectura = nv.InnerText.Trim();
                                    }
                                }
                                if (nv.LocalName.ToUpper().Trim() == "ESCRITURAARCHIVO")
                                {
                                    if (nv.InnerText.Trim() != "")
                                    {
                                        _filePath = nv.InnerText.Trim();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                result.Result = EnumResult.isError;
                result.Mensaje = e.Message;
            }

            return result;
        }

    }

}