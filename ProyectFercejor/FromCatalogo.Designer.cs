
namespace ProyectFercejor
{
    partial class FrmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogo));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReportFecha = new System.Windows.Forms.Button();
            this.btnReportProductos = new System.Windows.Forms.Button();
            this.btnReportPedidos = new System.Windows.Forms.Button();
            this.btnReportFactura = new System.Windows.Forms.Button();
            this.textFactCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPedidosCliente = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(416, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Silver;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(508, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReportFecha
            // 
            this.btnReportFecha.BackColor = System.Drawing.Color.Silver;
            this.btnReportFecha.Location = new System.Drawing.Point(517, 253);
            this.btnReportFecha.Name = "btnReportFecha";
            this.btnReportFecha.Size = new System.Drawing.Size(135, 27);
            this.btnReportFecha.TabIndex = 34;
            this.btnReportFecha.Text = "Generar reporte";
            this.btnReportFecha.UseVisualStyleBackColor = false;
            this.btnReportFecha.Click += new System.EventHandler(this.btnReportFecha_Click);
            // 
            // btnReportProductos
            // 
            this.btnReportProductos.BackColor = System.Drawing.Color.Silver;
            this.btnReportProductos.Location = new System.Drawing.Point(517, 174);
            this.btnReportProductos.Name = "btnReportProductos";
            this.btnReportProductos.Size = new System.Drawing.Size(135, 27);
            this.btnReportProductos.TabIndex = 33;
            this.btnReportProductos.Text = "Generar reporte";
            this.btnReportProductos.UseVisualStyleBackColor = false;
            this.btnReportProductos.Click += new System.EventHandler(this.btnReportProductos_Click);
            // 
            // btnReportPedidos
            // 
            this.btnReportPedidos.BackColor = System.Drawing.Color.Silver;
            this.btnReportPedidos.Location = new System.Drawing.Point(517, 103);
            this.btnReportPedidos.Name = "btnReportPedidos";
            this.btnReportPedidos.Size = new System.Drawing.Size(135, 27);
            this.btnReportPedidos.TabIndex = 32;
            this.btnReportPedidos.Text = "Generar reporte";
            this.btnReportPedidos.UseVisualStyleBackColor = false;
            this.btnReportPedidos.Click += new System.EventHandler(this.btnReportPedidos_Click_1);
            // 
            // btnReportFactura
            // 
            this.btnReportFactura.BackColor = System.Drawing.Color.Silver;
            this.btnReportFactura.Location = new System.Drawing.Point(517, 342);
            this.btnReportFactura.Name = "btnReportFactura";
            this.btnReportFactura.Size = new System.Drawing.Size(135, 27);
            this.btnReportFactura.TabIndex = 31;
            this.btnReportFactura.Text = "Generar reporte";
            this.btnReportFactura.UseVisualStyleBackColor = false;
            this.btnReportFactura.Click += new System.EventHandler(this.btnReportFactura_Click);
            // 
            // textFactCliente
            // 
            this.textFactCliente.Location = new System.Drawing.Point(746, 297);
            this.textFactCliente.Name = "textFactCliente";
            this.textFactCliente.Size = new System.Drawing.Size(77, 20);
            this.textFactCliente.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 72);
            this.label5.TabIndex = 29;
            this.label5.Text = "Reportes de lista facturas del cliente \r\n\r\n\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 36);
            this.label4.TabIndex = 28;
            this.label4.Text = "Reportes de lista facturas menores al dia\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "cantidad de stock";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(811, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reportes de Lista de productos menores a \r\n";
            // 
            // textPedidosCliente
            // 
            this.textPedidosCliente.Location = new System.Drawing.Point(835, 64);
            this.textPedidosCliente.Name = "textPedidosCliente";
            this.textPedidosCliente.Size = new System.Drawing.Size(135, 20);
            this.textPedidosCliente.TabIndex = 24;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(783, 214);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reportes de Lista de pedidos del cliente";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 41);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(509, 400);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1061, 469);
            this.Controls.Add(this.btnReportFecha);
            this.Controls.Add(this.btnReportProductos);
            this.Controls.Add(this.btnReportPedidos);
            this.Controls.Add(this.btnReportFactura);
            this.Controls.Add(this.textFactCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPedidosCliente);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCatalogo";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReportFecha;
        private System.Windows.Forms.Button btnReportProductos;
        private System.Windows.Forms.Button btnReportPedidos;
        private System.Windows.Forms.Button btnReportFactura;
        private System.Windows.Forms.TextBox textFactCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPedidosCliente;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}