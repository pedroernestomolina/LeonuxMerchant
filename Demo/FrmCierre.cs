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

    public partial class FrmCierre : Form
    {

        public FrmCierre()
        {
            InitializeComponent();
        }

        private void FrmCierre_Load(object sender, EventArgs e)
        {
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
        }

        private void FrmCierre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Salir();
            }
        }

        private void BT_CIERRE_Click(object sender, EventArgs e)
        {
            CierreTerminal();
        }

        private void CierreTerminal()
        {
            var msg = MessageBox.Show("Estas Seguro de Hacer Cierre Al Terminal ?", "*** ALERTA ***", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == System.Windows.Forms.DialogResult.Yes) 
            {
                CerrarTerminal();
            }
        }

        private void CerrarTerminal()
        {
            var rt = "";
            RespuestaCierre result;
            try
            {
                WebRequest __webrequest = WebRequest.Create(Program._urlCierre) as HttpWebRequest;
                string Postdata = string.Format("KeyId={0}&PublicKeyId={1}&Terminal={2}", Program._KeyId, 
                    Program._PublicKeyId, Program._Terminal);
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
                rt = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<RespuestaCierre>(rt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "*** ERROR ***", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }

}