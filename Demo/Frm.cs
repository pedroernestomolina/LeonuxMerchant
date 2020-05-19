using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Demo
{

    public partial class Frm : Form
    {
    
        public Frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            L_VERSION.Text = "Ver. "+Application.ProductVersion;
        }

        private void Notificar() 
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\Imagenes\Notificacion_2.ico");
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(2000, "Information", "LEONUX - MERCHANT Instalado y Escuchando !", ToolTipIcon.Info);
            trayIcon.ContextMenuStrip = contextMenuStrip1;
        }

    
        private void menuInicializar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            var frm = new Form1();
            frm.ShowDialog();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var frm = new FrmReport();
            frm.ShowDialog();
        }

        private void BT_INICIAR_Click(object sender, EventArgs e)
        {
            Notificar();
            this.Hide();
            var frm = new FrmPago();
            frm.ShowDialog();
        }

        private void menuCierre_Click(object sender, EventArgs e)
        {
            CierreTerminal();
        }

        private void CierreTerminal()
        {
            var frm = new FrmCierre();
            frm.ShowDialog();
        }

        private void menuAnularPago_Click(object sender, EventArgs e)
        {
            AnularPago();
        }

        private void AnularPago()
        {
            var frm = new FrmAnulacion();
            frm.ShowDialog();
        }

         
    }

}