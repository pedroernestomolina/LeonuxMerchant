namespace Demo
{
    partial class FrmPago
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.L_MODO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.CB_TIPO_CUENTA = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TB_NOMBRE = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TB_MONTO = new Demo.LibControles.NumeroDecimal();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.TB_CIRIF = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BT_PAGO = new System.Windows.Forms.Button();
            this.PN_ESTATUS = new System.Windows.Forms.Panel();
            this.PB_POS = new System.Windows.Forms.PictureBox();
            this.PB_ERROR = new System.Windows.Forms.PictureBox();
            this.PB_OK = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PN_ESTATUS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_POS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 34);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.57399F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.42601F));
            this.tableLayoutPanel3.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(390, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.L_MODO);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(1, 1);
            this.panel14.Margin = new System.Windows.Forms.Padding(1);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(2);
            this.panel14.Size = new System.Drawing.Size(249, 32);
            this.panel14.TabIndex = 0;
            // 
            // L_MODO
            // 
            this.L_MODO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_MODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MODO.ForeColor = System.Drawing.Color.White;
            this.L_MODO.Location = new System.Drawing.Point(2, 2);
            this.L_MODO.Name = "L_MODO";
            this.L_MODO.Size = new System.Drawing.Size(245, 28);
            this.L_MODO.TabIndex = 0;
            this.L_MODO.Text = "Modo: PAGO";
            this.L_MODO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 13;
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
            this.panel2.Size = new System.Drawing.Size(390, 310);
            this.panel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PN_ESTATUS, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 204);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.90773F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.09227F));
            this.tableLayoutPanel2.Controls.Add(this.panel13, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 204);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.CB_TIPO_CUENTA);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(91, 138);
            this.panel13.Margin = new System.Windows.Forms.Padding(1);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(2);
            this.panel13.Size = new System.Drawing.Size(153, 30);
            this.panel13.TabIndex = 3;
            // 
            // CB_TIPO_CUENTA
            // 
            this.CB_TIPO_CUENTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_TIPO_CUENTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TIPO_CUENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TIPO_CUENTA.FormattingEnabled = true;
            this.CB_TIPO_CUENTA.Items.AddRange(new object[] {
            "Ahorro",
            "Corriente",
            "Credito",
            "FAL"});
            this.CB_TIPO_CUENTA.Location = new System.Drawing.Point(2, 2);
            this.CB_TIPO_CUENTA.Name = "CB_TIPO_CUENTA";
            this.CB_TIPO_CUENTA.Size = new System.Drawing.Size(149, 28);
            this.CB_TIPO_CUENTA.TabIndex = 3;
            this.CB_TIPO_CUENTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_MONTO_KeyDown);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TB_NOMBRE);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(91, 65);
            this.panel9.Margin = new System.Windows.Forms.Padding(1);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2);
            this.panel9.Size = new System.Drawing.Size(153, 71);
            this.panel9.TabIndex = 2;
            // 
            // TB_NOMBRE
            // 
            this.TB_NOMBRE.BackColor = System.Drawing.Color.Yellow;
            this.TB_NOMBRE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NOMBRE.Enabled = false;
            this.TB_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NOMBRE.Location = new System.Drawing.Point(2, 2);
            this.TB_NOMBRE.MaxLength = 60;
            this.TB_NOMBRE.Multiline = true;
            this.TB_NOMBRE.Name = "TB_NOMBRE";
            this.TB_NOMBRE.ReadOnly = true;
            this.TB_NOMBRE.Size = new System.Drawing.Size(149, 67);
            this.TB_NOMBRE.TabIndex = 2;
            this.TB_NOMBRE.Text = "CLEINTE VENTA DETAL";
            this.TB_NOMBRE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_MONTO_KeyDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TB_MONTO);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(91, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(153, 30);
            this.panel7.TabIndex = 0;
            // 
            // TB_MONTO
            // 
            this.TB_MONTO.BackColor = System.Drawing.Color.Yellow;
            this.TB_MONTO.Dock = System.Windows.Forms.DockStyle.Left;
            this.TB_MONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MONTO.Location = new System.Drawing.Point(2, 2);
            this.TB_MONTO.MaxLength = 12;
            this.TB_MONTO.Name = "TB_MONTO";
            this.TB_MONTO.Size = new System.Drawing.Size(117, 26);
            this.TB_MONTO.TabIndex = 0;
            this.TB_MONTO.Text = "0";
            this.TB_MONTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_MONTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_MONTO_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(88, 30);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 65);
            this.panel8.Margin = new System.Windows.Forms.Padding(1);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2);
            this.panel8.Size = new System.Drawing.Size(88, 71);
            this.panel8.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 67);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(1, 33);
            this.panel10.Margin = new System.Windows.Forms.Padding(1);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(88, 30);
            this.panel10.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "CI/RIF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.TB_CIRIF);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(91, 33);
            this.panel11.Margin = new System.Windows.Forms.Padding(1);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(2);
            this.panel11.Size = new System.Drawing.Size(153, 30);
            this.panel11.TabIndex = 1;
            // 
            // TB_CIRIF
            // 
            this.TB_CIRIF.BackColor = System.Drawing.Color.Yellow;
            this.TB_CIRIF.Dock = System.Windows.Forms.DockStyle.Left;
            this.TB_CIRIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CIRIF.Location = new System.Drawing.Point(2, 2);
            this.TB_CIRIF.MaxLength = 12;
            this.TB_CIRIF.Name = "TB_CIRIF";
            this.TB_CIRIF.Size = new System.Drawing.Size(117, 26);
            this.TB_CIRIF.TabIndex = 1;
            this.TB_CIRIF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_MONTO_KeyDown);
            this.TB_CIRIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_CIRIF_KeyPress);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(1, 138);
            this.panel12.Margin = new System.Windows.Forms.Padding(1);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(2);
            this.panel12.Size = new System.Drawing.Size(88, 30);
            this.panel12.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "T/Cuenta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 40);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Del Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BT_PAGO);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 249);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(6);
            this.panel6.Size = new System.Drawing.Size(245, 60);
            this.panel6.TabIndex = 3;
            // 
            // BT_PAGO
            // 
            this.BT_PAGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_PAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_PAGO.Location = new System.Drawing.Point(6, 6);
            this.BT_PAGO.Name = "BT_PAGO";
            this.BT_PAGO.Size = new System.Drawing.Size(233, 48);
            this.BT_PAGO.TabIndex = 10;
            this.BT_PAGO.Text = "Procesar";
            this.BT_PAGO.UseVisualStyleBackColor = true;
            this.BT_PAGO.Click += new System.EventHandler(this.BT_PAGO_Click);
            // 
            // PN_ESTATUS
            // 
            this.PN_ESTATUS.Controls.Add(this.PB_POS);
            this.PN_ESTATUS.Controls.Add(this.PB_ERROR);
            this.PN_ESTATUS.Controls.Add(this.PB_OK);
            this.PN_ESTATUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_ESTATUS.Location = new System.Drawing.Point(248, 1);
            this.PN_ESTATUS.Margin = new System.Windows.Forms.Padding(1);
            this.PN_ESTATUS.Name = "PN_ESTATUS";
            this.PN_ESTATUS.Padding = new System.Windows.Forms.Padding(5, 30, 5, 30);
            this.tableLayoutPanel1.SetRowSpan(this.PN_ESTATUS, 4);
            this.PN_ESTATUS.Size = new System.Drawing.Size(141, 308);
            this.PN_ESTATUS.TabIndex = 4;
            // 
            // PB_POS
            // 
            this.PB_POS.BackgroundImage = global::Demo.Properties.Resources.POS;
            this.PB_POS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_POS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_POS.Location = new System.Drawing.Point(5, 30);
            this.PB_POS.Name = "PB_POS";
            this.PB_POS.Size = new System.Drawing.Size(131, 248);
            this.PB_POS.TabIndex = 2;
            this.PB_POS.TabStop = false;
            // 
            // PB_ERROR
            // 
            this.PB_ERROR.BackgroundImage = global::Demo.Properties.Resources.Error;
            this.PB_ERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_ERROR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_ERROR.Location = new System.Drawing.Point(5, 30);
            this.PB_ERROR.Name = "PB_ERROR";
            this.PB_ERROR.Size = new System.Drawing.Size(131, 248);
            this.PB_ERROR.TabIndex = 1;
            this.PB_ERROR.TabStop = false;
            // 
            // PB_OK
            // 
            this.PB_OK.BackgroundImage = global::Demo.Properties.Resources.OK_2;
            this.PB_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_OK.Location = new System.Drawing.Point(5, 30);
            this.PB_OK.Name = "PB_OK";
            this.PB_OK.Size = new System.Drawing.Size(131, 248);
            this.PB_OK.TabIndex = 0;
            this.PB_OK.TabStop = false;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merchant ( Pago )";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmPago_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPago_FormClosing);
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPago_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.PN_ESTATUS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_POS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_OK)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BT_PAGO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NOMBRE;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox TB_CIRIF;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_TIPO_CUENTA;
        private System.Windows.Forms.Panel PN_ESTATUS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label L_MODO;
        private System.Windows.Forms.PictureBox PB_OK;
        private LibControles.NumeroDecimal TB_MONTO;
        private System.Windows.Forms.PictureBox PB_ERROR;
        private System.Windows.Forms.PictureBox PB_POS;
    }
}