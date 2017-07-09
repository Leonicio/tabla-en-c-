namespace Registro_de_Notas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTP = new System.Windows.Forms.TextBox();
            this.TXTA = new System.Windows.Forms.TextBox();
            this.TXTTF = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgNotas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajo_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examen_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carlificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTEF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCantidadC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(86, 49);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(272, 24);
            this.TXTNOMBRE.TabIndex = 1;
            this.TXTNOMBRE.TextChanged += new System.EventHandler(this.TXTNOMBRE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Participancion (0/15) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asistencia (0/15) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TF (0/20) :";
            // 
            // TXTP
            // 
            this.TXTP.Location = new System.Drawing.Point(121, 20);
            this.TXTP.Name = "TXTP";
            this.TXTP.Size = new System.Drawing.Size(35, 20);
            this.TXTP.TabIndex = 5;
            this.TXTP.TextChanged += new System.EventHandler(this.TXTP_TextChanged);
            this.TXTP.VisibleChanged += new System.EventHandler(this.TXTP_VisibleChanged);
            this.TXTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTP_KeyPress);
            this.TXTP.Validating += new System.ComponentModel.CancelEventHandler(this.TXTP_Validating);
            // 
            // TXTA
            // 
            this.TXTA.Location = new System.Drawing.Point(291, 20);
            this.TXTA.Name = "TXTA";
            this.TXTA.Size = new System.Drawing.Size(35, 20);
            this.TXTA.TabIndex = 6;
            this.TXTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTA_KeyPress);
            this.TXTA.Validating += new System.ComponentModel.CancelEventHandler(this.TXTA_Validating);
            // 
            // TXTTF
            // 
            this.TXTTF.Location = new System.Drawing.Point(436, 20);
            this.TXTTF.Name = "TXTTF";
            this.TXTTF.Size = new System.Drawing.Size(38, 20);
            this.TXTTF.TabIndex = 7;
            this.TXTTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTF_KeyPress);
            this.TXTTF.Validating += new System.ComponentModel.CancelEventHandler(this.TXTTF_Validating);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 319);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgNotas);
            this.tabPage1.Controls.Add(this.TXTEF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TXTP);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TXTTF);
            this.tabPage1.Controls.Add(this.TXTA);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgNotas
            // 
            this.dgNotas.AllowUserToAddRows = false;
            this.dgNotas.AllowUserToDeleteRows = false;
            this.dgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Participacion,
            this.Asistencia,
            this.Trabajo_Final,
            this.Examen_Final,
            this.Carlificacion,
            this.Puntuacion});
            this.dgNotas.Location = new System.Drawing.Point(0, 57);
            this.dgNotas.Name = "dgNotas";
            this.dgNotas.ReadOnly = true;
            this.dgNotas.Size = new System.Drawing.Size(697, 236);
            this.dgNotas.TabIndex = 0;
            this.dgNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNotas_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 190;
            // 
            // Participacion
            // 
            this.Participacion.HeaderText = "Participacion";
            this.Participacion.Name = "Participacion";
            this.Participacion.ReadOnly = true;
            this.Participacion.Width = 80;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Width = 80;
            // 
            // Trabajo_Final
            // 
            this.Trabajo_Final.HeaderText = "Trabajo Final";
            this.Trabajo_Final.Name = "Trabajo_Final";
            this.Trabajo_Final.ReadOnly = true;
            this.Trabajo_Final.Width = 80;
            // 
            // Examen_Final
            // 
            this.Examen_Final.HeaderText = "Examen Final";
            this.Examen_Final.Name = "Examen_Final";
            this.Examen_Final.ReadOnly = true;
            this.Examen_Final.Width = 80;
            // 
            // Carlificacion
            // 
            this.Carlificacion.HeaderText = "Carlificacion";
            this.Carlificacion.Name = "Carlificacion";
            this.Carlificacion.ReadOnly = true;
            this.Carlificacion.Width = 75;
            // 
            // Puntuacion
            // 
            this.Puntuacion.HeaderText = "Puntuacion";
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.ReadOnly = true;
            this.Puntuacion.Width = 67;
            // 
            // TXTEF
            // 
            this.TXTEF.Location = new System.Drawing.Point(576, 20);
            this.TXTEF.Name = "TXTEF";
            this.TXTEF.Size = new System.Drawing.Size(41, 20);
            this.TXTEF.TabIndex = 10;
            this.TXTEF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTEF_KeyPress);
            this.TXTEF.Validating += new System.ComponentModel.CancelEventHandler(this.TXTEF_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "EF (0/50) :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCantidadC);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCantidadB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCantidadA);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resumen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCantidadC
            // 
            this.txtCantidadC.Location = new System.Drawing.Point(86, 102);
            this.txtCantidadC.Name = "txtCantidadC";
            this.txtCantidadC.ReadOnly = true;
            this.txtCantidadC.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadC.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad C";
            // 
            // txtCantidadB
            // 
            this.txtCantidadB.Location = new System.Drawing.Point(86, 76);
            this.txtCantidadB.Name = "txtCantidadB";
            this.txtCantidadB.ReadOnly = true;
            this.txtCantidadB.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cantidad B";
            // 
            // txtCantidadA
            // 
            this.txtCantidadA.Location = new System.Drawing.Point(86, 50);
            this.txtCantidadA.Name = "txtCantidadA";
            this.txtCantidadA.ReadOnly = true;
            this.txtCantidadA.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadA.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad A";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "José Bernardo Cid   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Notas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTP;
        private System.Windows.Forms.TextBox TXTA;
        private System.Windows.Forms.TextBox TXTTF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgNotas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTEF;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajo_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carlificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadA;
        private System.Windows.Forms.TextBox txtCantidadC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadB;
        private System.Windows.Forms.Label label8;
    }
}

