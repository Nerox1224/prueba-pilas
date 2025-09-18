namespace Prueba_de_pilas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabla = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellod = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCodigo = new TextBox();
            Apilar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            Desapilar = new Button();
            Promedio = new Button();
            buscar = new Button();
            Eliminar = new Button();
            label5 = new Label();
            txtPromedio = new Label();
            txtBusqueda = new TextBox();
            label6 = new Label();
            Imprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Apellod, Precio });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tabla.DefaultCellStyle = dataGridViewCellStyle2;
            tabla.Location = new Point(203, 12);
            tabla.Name = "tabla";
            tabla.ReadOnly = true;
            tabla.RowHeadersVisible = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.ShowCellToolTips = false;
            tabla.ShowEditingIcon = false;
            tabla.Size = new Size(444, 302);
            tabla.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellod
            // 
            Apellod.HeaderText = "Apellido";
            Apellod.Name = "Apellod";
            Apellod.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(84, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // Apilar
            // 
            Apilar.Location = new Point(20, 128);
            Apilar.Name = "Apilar";
            Apilar.Size = new Size(164, 38);
            Apilar.TabIndex = 3;
            Apilar.Text = "Apilar";
            Apilar.UseVisualStyleBackColor = true;
            Apilar.Click += Apilar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(84, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(84, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 99);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // Desapilar
            // 
            Desapilar.Location = new Point(20, 172);
            Desapilar.Name = "Desapilar";
            Desapilar.Size = new Size(164, 38);
            Desapilar.TabIndex = 10;
            Desapilar.Text = "Desapilar";
            Desapilar.UseVisualStyleBackColor = true;
            Desapilar.Click += Desapilar_Click;
            // 
            // Promedio
            // 
            Promedio.Location = new Point(20, 216);
            Promedio.Name = "Promedio";
            Promedio.Size = new Size(164, 38);
            Promedio.TabIndex = 11;
            Promedio.Text = "Promedio";
            Promedio.UseVisualStyleBackColor = true;
            Promedio.Click += Promedio_Click;
            // 
            // buscar
            // 
            buscar.Location = new Point(20, 332);
            buscar.Name = "buscar";
            buscar.Size = new Size(164, 38);
            buscar.TabIndex = 12;
            buscar.Text = "buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(497, 320);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(164, 38);
            Eliminar.TabIndex = 13;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 332);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "Promedio";
            // 
            // txtPromedio
            // 
            txtPromedio.AutoSize = true;
            txtPromedio.Location = new Point(326, 332);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(28, 15);
            txtPromedio.TabIndex = 15;
            txtPromedio.Text = "0.00";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(84, 303);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(100, 23);
            txtBusqueda.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 303);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 16;
            label6.Text = "Código";
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(20, 259);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(164, 38);
            Imprimir.TabIndex = 18;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += Imprimir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 375);
            Controls.Add(Imprimir);
            Controls.Add(txtBusqueda);
            Controls.Add(label6);
            Controls.Add(txtPromedio);
            Controls.Add(label5);
            Controls.Add(Eliminar);
            Controls.Add(buscar);
            Controls.Add(Promedio);
            Controls.Add(Desapilar);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(Apilar);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(tabla);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabla;
        private Label label1;
        private TextBox txtCodigo;
        private Button Apilar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private Button Desapilar;
        private Button button2;
        private Button Promedio;
        private Button buscar;
        private Button Eliminar;
        private Label label5;
        private Label txtPromedio;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellod;
        private DataGridViewTextBoxColumn Precio;
        private TextBox txtBusqueda;
        private Label label6;
        private Button Imprimir;
    }
}
