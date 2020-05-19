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
using System.Xml;
using System.Xml.Linq;

namespace Demo
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xr= Program._cliente.ObtenerSerial();
            if (xr.Exito)
            {
            }
        }

        private string rt="";
        private bool TestConexion()
        {
            rt+= "TEST CONEXION";
            var xr = Program._cliente.TestConexion();
            if (xr.Exito)
            {
                rt += Environment.NewLine;
                rt += xr.Mensaje;
                rt += Environment.NewLine;
                return true;
            }
            else 
            {
                rt += " ( ERROR ) ";
                rt += Environment.NewLine;
                rt += xr.Mensaje;
                rt += Environment.NewLine;
                return false;
            }
        }

        private RespuestaLogon Logon()
        {
            RespuestaLogon rt =null;
            try
            {
                WebClient webClient = new WebClient();
                webClient.QueryString.Add("KeyId", Program._KeyId);
                webClient.QueryString.Add("PublicKeyId", Program._PublicKeyId);
                webClient.QueryString.Add("Terminal", Program._Terminal);
                webClient.QueryString.Add("EMVKey", "false");
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                string result = webClient.DownloadString(Program._urlLogon);
                rt  = JsonConvert.DeserializeObject<RespuestaLogon>(result);
            }
            catch (Exception e)
            {
                rt = new RespuestaLogon();
                rt.message = e.Message;
                rt.success = false;
            }
            return rt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L_RESULTADO.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                Salir();
            }
        }

        private void Salir()
        {
            this.Close();
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void BT_INICIAR_Click(object sender, EventArgs e)
        {
            Iniciar();
            L_RESULTADO.Text = "Espere Por Favor";
            this.Refresh();

            if (TestConexion())
            {
                L_RESULTADO.Text = rt;
                this.Refresh();

                rt += "OBTENER LLAVE";
                rt += Environment.NewLine;
                L_RESULTADO.Text = rt;
                this.Refresh();

                var r01 = Logon();
                if (r01.success)
                {
                    rt += "( OK )";
                    rt += Environment.NewLine;
                    L_RESULTADO.Text = rt;
                    this.Refresh();

                    rt += "CARGAR LLAVE";
                    rt += Environment.NewLine;
                    L_RESULTADO.Text = rt;
                    this.Refresh();

                    var r02 = Program._cliente.CargarLLaveTrabajo(r01.message);
                    if (r02.Exito)
                    {
                        Program._KeyPinPad = r01.message;
                        rt += "( OK )";
                        rt += Environment.NewLine;
                        rt += r02.Mensaje;
                        rt += Environment.NewLine;
                        L_RESULTADO.Text = rt;
                        this.Refresh();

                        rt += "ACTUALIZAR LLAVE";
                        rt += Environment.NewLine;
                        L_RESULTADO.Text = rt;
                        this.Refresh();

                        var r03 = ActualizarLLave(r01.message);
                        if (r03.Result == EnumResult.isError)
                        {
                            rt += "( ERROR )";
                            rt += Environment.NewLine;
                            rt += r03.Mensaje;
                            Falla();
                        }
                        else
                        {
                            rt += "( OK)";
                            rt += Environment.NewLine;
                            L_RESULTADO.Text = rt;
                            PB_SETUP.Visible = false;
                            PB_ESTATUS_ERROR.Visible= false;
                            PB_ESTATUS_OK.Visible = true;
                            BT_INICIAR.Enabled = false;
                            this.Refresh();
                        }
                    }
                    else
                    {
                        rt += "( ERROR )";
                        rt += Environment.NewLine;
                        rt += r02.Mensaje;
                        Falla();
                    }
                }
                else
                {
                    rt += "( ERROR )";
                    rt += Environment.NewLine;
                    rt += r01.message;
                    rt += Environment.NewLine;
                    Falla();
                }
            }
            else 
            {
                Falla();
            }
        }

        private void Iniciar()
        {
            rt = "";
            L_RESULTADO.Text = "";
            PB_ESTATUS_OK.Visible = false;
            PB_ESTATUS_ERROR.Visible = false;
            PB_SETUP.Visible = true;
        }

        private void Falla()
        {
            L_RESULTADO.Text = rt;
            PB_SETUP.Visible = false;
            PB_ESTATUS_OK.Visible = false;
            PB_ESTATUS_ERROR.Visible = true;
        }

        private Resultado ActualizarLLave(string p)
        {
            var rt = new Resultado();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Setup.XML");
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = root.SelectSingleNode("descendant::KeyPinPad");
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
          
    }

}