namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.L_MODO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.L_RESULTADO = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_INICIAR = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PB_SETUP = new System.Windows.Forms.PictureBox();
            this.PB_ESTATUS_OK = new System.Windows.Forms.PictureBox();
            this.PB_ESTATUS_ERROR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SETUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ESTATUS_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ESTATUS_ERROR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 34);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.57399F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.42601F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.L_MODO);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(300, 32);
            this.panel6.TabIndex = 0;
            // 
            // L_MODO
            // 
            this.L_MODO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_MODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MODO.ForeColor = System.Drawing.Color.White;
            this.L_MODO.Location = new System.Drawing.Point(2, 2);
            this.L_MODO.Name = "L_MODO";
            this.L_MODO.Size = new System.Drawing.Size(296, 28);
            this.L_MODO.TabIndex = 0;
            this.L_MODO.Text = "Modo: INICIALIZAR";
            this.L_MODO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Size = new System.Drawing.Size(96, 22);
            this.menuArchivoSalir.Text = "Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 286);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.L_RESULTADO);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 180);
            this.panel4.TabIndex = 1;
            // 
            // L_RESULTADO
            // 
            this.L_RESULTADO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_RESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RESULTADO.Location = new System.Drawing.Point(0, 0);
            this.L_RESULTADO.Name = "L_RESULTADO";
            this.L_RESULTADO.Size = new System.Drawing.Size(305, 180);
            this.L_RESULTADO.TabIndex = 0;
            this.L_RESULTADO.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_INICIAR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(305, 60);
            this.panel3.TabIndex = 0;
            // 
            // BT_INICIAR
            // 
            this.BT_INICIAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_INICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_INICIAR.Location = new System.Drawing.Point(6, 6);
            this.BT_INICIAR.Name = "BT_INICIAR";
            this.BT_INICIAR.Size = new System.Drawing.Size(293, 48);
            this.BT_INICIAR.TabIndex = 0;
            this.BT_INICIAR.Text = "INICIAR";
            this.BT_INICIAR.UseVisualStyleBackColor = true;
            this.BT_INICIAR.Click += new System.EventHandler(this.BT_INICIAR_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 40);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIALIZAR DISPOSITIVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PB_SETUP);
            this.panel7.Controls.Add(this.PB_ESTATUS_OK);
            this.panel7.Controls.Add(this.PB_ESTATUS_ERROR);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(308, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.tableLayoutPanel1.SetRowSpan(this.panel7, 3);
            this.panel7.Size = new System.Drawing.Size(160, 284);
            this.panel7.TabIndex = 3;
            // 
            // PB_SETUP
            // 
            this.PB_SETUP.BackgroundImage = global::Demo.Properties.Resources.setup;
            this.PB_SETUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_SETUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_SETUP.Location = new System.Drawing.Point(10, 30);
            this.PB_SETUP.Name = "PB_SETUP";
            this.PB_SETUP.Size = new System.Drawing.Size(140, 224);
            this.PB_SETUP.TabIndex = 2;
            this.PB_SETUP.TabStop = false;
            // 
            // PB_ESTATUS_OK
            // 
            this.PB_ESTATUS_OK.BackgroundImage = global::Demo.Properties.Resources.OK_2;
            this.PB_ESTATUS_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_ESTATUS_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_ESTATUS_OK.Location = new System.Drawing.Point(10, 30);
            this.PB_ESTATUS_OK.Name = "PB_ESTATUS_OK";
            this.PB_ESTATUS_OK.Size = new System.Drawing.Size(140, 224);
            this.PB_ESTATUS_OK.TabIndex = 0;
            this.PB_ESTATUS_OK.TabStop = false;
            this.PB_ESTATUS_OK.Visible = false;
            // 
            // PB_ESTATUS_ERROR
            // 
            this.PB_ESTATUS_ERROR.BackgroundImage = global::Demo.Properties.Resources.Error;
            this.PB_ESTATUS_ERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_ESTATUS_ERROR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_ESTATUS_ERROR.Location = new System.Drawing.Point(10, 30);
            this.PB_ESTATUS_ERROR.Name = "PB_ESTATUS_ERROR";
            this.PB_ESTATUS_ERROR.Size = new System.Drawing.Size(140, 224);
            this.PB_ESTATUS_ERROR.TabIndex = 1;
            this.PB_ESTATUS_ERROR.TabStop = false;
            this.PB_ESTATUS_ERROR.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merchant (Inicializar)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_SETUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ESTATUS_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ESTATUS_ERROR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BT_INICIAR;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_RESULTADO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label L_MODO;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox PB_ESTATUS_OK;
        private System.Windows.Forms.PictureBox PB_ESTATUS_ERROR;
        private System.Windows.Forms.PictureBox PB_SETUP;
    }
}

