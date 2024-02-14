
namespace Money.Formularios
{
    partial class FPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRIngreso = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvRGastos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lbl_Ingresos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngreso)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO ",
            "ABRIL",
            "MAYO ",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE "});
            this.cboMes.Location = new System.Drawing.Point(10, 116);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(86, 31);
            this.cboMes.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 360);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRIngreso);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvRIngreso
            // 
            this.dgvRIngreso.AllowUserToAddRows = false;
            this.dgvRIngreso.AllowUserToDeleteRows = false;
            this.dgvRIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRIngreso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRIngreso.Location = new System.Drawing.Point(-2, 0);
            this.dgvRIngreso.Name = "dgvRIngreso";
            this.dgvRIngreso.ReadOnly = true;
            this.dgvRIngreso.RowHeadersWidth = 62;
            this.dgvRIngreso.Size = new System.Drawing.Size(505, 542);
            this.dgvRIngreso.TabIndex = 8;
            this.dgvRIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.txtGasto);
            this.tabPage2.Controls.Add(this.txtIngreso);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saldo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(137, 88);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(167, 29);
            this.txtSaldo.TabIndex = 13;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGasto
            // 
            this.txtGasto.BackColor = System.Drawing.Color.White;
            this.txtGasto.Location = new System.Drawing.Point(137, 49);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.ReadOnly = true;
            this.txtGasto.Size = new System.Drawing.Size(167, 29);
            this.txtGasto.TabIndex = 12;
            this.txtGasto.Text = "0";
            this.txtGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.Location = new System.Drawing.Point(137, 17);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(167, 29);
            this.txtIngreso.TabIndex = 11;
            this.txtIngreso.Text = "0";
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRGastos);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(499, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gastos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRGastos
            // 
            this.dgvRGastos.AllowUserToAddRows = false;
            this.dgvRGastos.AllowUserToDeleteRows = false;
            this.dgvRGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRGastos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRGastos.Location = new System.Drawing.Point(3, 3);
            this.dgvRGastos.Name = "dgvRGastos";
            this.dgvRGastos.ReadOnly = true;
            this.dgvRGastos.RowHeadersWidth = 62;
            this.dgvRGastos.Size = new System.Drawing.Size(425, 143);
            this.dgvRGastos.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGastos);
            this.groupBox1.Controls.Add(this.lbl_Ingresos);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Location = new System.Drawing.Point(16, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(415, 38);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(63, 23);
            this.lblGastos.TabIndex = 10;
            this.lblGastos.Text = "Gastos";
            // 
            // lbl_Ingresos
            // 
            this.lbl_Ingresos.AutoSize = true;
            this.lbl_Ingresos.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingresos.Location = new System.Drawing.Point(299, 38);
            this.lbl_Ingresos.Name = "lbl_Ingresos";
            this.lbl_Ingresos.Size = new System.Drawing.Size(75, 23);
            this.lbl_Ingresos.TabIndex = 9;
            this.lbl_Ingresos.Text = "Ingresos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Money.Properties.Resources.Costo;
            this.pictureBox2.Location = new System.Drawing.Point(406, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Money.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(185, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 58);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Money.Properties.Resources.Ingreso;
            this.pictureBox1.Location = new System.Drawing.Point(294, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(102, 117);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(127, 29);
            this.txtAño.TabIndex = 8;
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.AllowUserToAddRows = false;
            this.dgvMovimiento.AllowUserToDeleteRows = false;
            this.dgvMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimiento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMovimiento.Location = new System.Drawing.Point(10, 371);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.ReadOnly = true;
            this.dgvMovimiento.RowHeadersWidth = 62;
            this.dgvMovimiento.Size = new System.Drawing.Size(495, 207);
            this.dgvMovimiento.TabIndex = 9;
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMovimiento_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMovimientoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 36);
            // 
            // editarMovimientoToolStripMenuItem
            // 
            this.editarMovimientoToolStripMenuItem.Name = "editarMovimientoToolStripMenuItem";
            this.editarMovimientoToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.editarMovimientoToolStripMenuItem.Text = "Editar Movimiento";
            this.editarMovimientoToolStripMenuItem.Click += new System.EventHandler(this.editarMovimientoToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 590);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Gastos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngreso)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRIngreso;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRGastos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarMovimientoToolStripMenuItem;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lbl_Ingresos;
    }
}