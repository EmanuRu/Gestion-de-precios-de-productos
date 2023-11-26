namespace RecuperatorioTomasRuibal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            bsProd = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbMonto = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsPrecio = new System.Windows.Forms.BindingSource(components);
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            button3 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            tbPrecioEdit = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            tbMontoEdit = new System.Windows.Forms.TextBox();
            dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            comboBoxEdit = new System.Windows.Forms.ComboBox();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPrecio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(39, 54);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(153, 27);
            button1.TabIndex = 3;
            button1.Text = "Gestionar Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bsProd;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(293, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "id";
            // 
            // bsProd
            // 
            bsProd.DataSource = typeof(Entidades.Productos);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(265, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 15);
            label2.TabIndex = 5;
            label2.Text = "Precios de los productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(433, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha";
            // 
            // tbMonto
            // 
            tbMonto.Location = new System.Drawing.Point(561, 54);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new System.Drawing.Size(100, 23);
            tbMonto.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(561, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Monto";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(683, 54);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 23);
            button2.TabIndex = 10;
            button2.Text = "Agregar precio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, Date, Monto, idProducto, NombreProducto });
            dataGridView1.DataSource = bsPrecio;
            dataGridView1.Location = new System.Drawing.Point(31, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(713, 330);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Codigo Precio";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 110;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Fecha";
            Date.Name = "Date";
            Date.Width = 120;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.Width = 120;
            // 
            // idProducto
            // 
            idProducto.DataPropertyName = "idProducto";
            idProducto.HeaderText = "Codigo Producto";
            idProducto.Name = "idProducto";
            idProducto.Width = 170;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 150;
            // 
            // bsPrecio
            // 
            bsPrecio.DataSource = typeof(Entidades.Precios);
            // 
            // dtpFecha
            // 
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFecha.Location = new System.Drawing.Point(433, 53);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(92, 23);
            dtpFecha.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(750, 435);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(117, 23);
            button3.TabIndex = 13;
            button3.Text = "Eliminar Precio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(750, 150);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 15);
            label7.TabIndex = 17;
            label7.Text = "Actualizar / Eliminar Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(750, 175);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(101, 15);
            label8.TabIndex = 19;
            label8.Text = "Codigo del Precio";
            // 
            // tbPrecioEdit
            // 
            tbPrecioEdit.Location = new System.Drawing.Point(750, 197);
            tbPrecioEdit.Name = "tbPrecioEdit";
            tbPrecioEdit.Size = new System.Drawing.Size(87, 23);
            tbPrecioEdit.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(750, 234);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(43, 15);
            label9.TabIndex = 21;
            label9.Text = "Monto";
            // 
            // tbMontoEdit
            // 
            tbMontoEdit.Location = new System.Drawing.Point(750, 254);
            tbMontoEdit.Name = "tbMontoEdit";
            tbMontoEdit.Size = new System.Drawing.Size(100, 23);
            tbMontoEdit.TabIndex = 20;
            // 
            // dateTimePickerEdit
            // 
            dateTimePickerEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerEdit.Location = new System.Drawing.Point(750, 308);
            dateTimePickerEdit.Name = "dateTimePickerEdit";
            dateTimePickerEdit.Size = new System.Drawing.Size(92, 23);
            dateTimePickerEdit.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(750, 289);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(38, 15);
            label10.TabIndex = 22;
            label10.Text = "Fecha";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(750, 397);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(117, 23);
            button4.TabIndex = 24;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBoxEdit
            // 
            comboBoxEdit.DataSource = bsProd;
            comboBoxEdit.DisplayMember = "descripcion";
            comboBoxEdit.FormattingEnabled = true;
            comboBoxEdit.Location = new System.Drawing.Point(750, 349);
            comboBoxEdit.Name = "comboBoxEdit";
            comboBoxEdit.Size = new System.Drawing.Size(121, 23);
            comboBoxEdit.TabIndex = 25;
            comboBoxEdit.ValueMember = "id";
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(254, 52);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(33, 24);
            button5.TabIndex = 26;
            button5.Text = "↻";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(7, 55);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(25, 23);
            button6.TabIndex = 27;
            button6.Text = "!";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(232, 52);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(16, 23);
            button7.TabIndex = 28;
            button7.Text = "!";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(794, 54);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(25, 23);
            button8.TabIndex = 29;
            button8.Text = "!";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(875, 397);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(24, 23);
            button9.TabIndex = 30;
            button9.Text = "!";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(877, 435);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(22, 23);
            button10.TabIndex = 31;
            button10.Text = "!";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(comboBoxEdit);
            Controls.Add(button4);
            Controls.Add(dateTimePickerEdit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tbMontoEdit);
            Controls.Add(label8);
            Controls.Add(tbPrecioEdit);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(dtpFecha);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(tbMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bsProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.BindingSource bsPrecio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrecioEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMontoEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

