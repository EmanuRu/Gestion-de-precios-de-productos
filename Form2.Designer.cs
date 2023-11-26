namespace RecuperatorioTomasRuibal
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbNomProd = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            bsProductos = new System.Windows.Forms.BindingSource(components);
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            tbNombre = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // tbNomProd
            // 
            tbNomProd.Location = new System.Drawing.Point(76, 89);
            tbNomProd.Name = "tbNomProd";
            tbNomProd.Size = new System.Drawing.Size(100, 23);
            tbNomProd.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(76, 118);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bsProductos;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(313, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "id";
            // 
            // bsProductos
            // 
            bsProductos.DataSource = typeof(Entidades.Productos);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(76, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(147, 15);
            label3.TabIndex = 5;
            label3.Text = "Agregar nuevos productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(314, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 15);
            label4.TabIndex = 6;
            label4.Text = "Actualizar / Eliminar";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(554, 88);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(448, 57);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new System.Drawing.Point(448, 89);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new System.Drawing.Size(100, 23);
            tbNombre.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(646, 89);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(157, 118);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(25, 23);
            button4.TabIndex = 11;
            button4.Text = "!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(603, 59);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(26, 23);
            button5.TabIndex = 12;
            button5.Text = "!";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(696, 60);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(25, 23);
            button6.TabIndex = 13;
            button6.Text = "!";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 263);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(tbNomProd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Gestionar Productos";
            ((System.ComponentModel.ISupportInitialize)bsProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}