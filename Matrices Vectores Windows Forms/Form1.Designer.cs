namespace Matrices_Vectores_Windows_Forms
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.vectorImput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Label();
            this.mostrarVector = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.matrizN = new System.Windows.Forms.TextBox();
            this.matrizM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrarMatriz = new System.Windows.Forms.Button();
            this.buttonCrearMatriz = new System.Windows.Forms.Button();
            this.buttonGuardarValorMatriz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "VECTORES";
            // 
            // vectorImput
            // 
            this.vectorImput.Location = new System.Drawing.Point(42, 119);
            this.vectorImput.Name = "vectorImput";
            this.vectorImput.Size = new System.Drawing.Size(127, 20);
            this.vectorImput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese los valores para el vector";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(206, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar Valor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(506, 166);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(171, 25);
            this.mostrar.TabIndex = 4;
            this.mostrar.Text = "Mostrando Valores";
            // 
            // mostrarVector
            // 
            this.mostrarVector.Location = new System.Drawing.Point(428, 82);
            this.mostrarVector.Name = "mostrarVector";
            this.mostrarVector.Size = new System.Drawing.Size(115, 35);
            this.mostrarVector.TabIndex = 5;
            this.mostrarVector.Text = "Mostrar Vector";
            this.mostrarVector.UseVisualStyleBackColor = true;
            this.mostrarVector.Click += new System.EventHandler(this.mostrarVector_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(511, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(911, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese el tamaño \r\nde la matriz";
            // 
            // matrizN
            // 
            this.matrizN.Location = new System.Drawing.Point(881, 128);
            this.matrizN.Name = "matrizN";
            this.matrizN.Size = new System.Drawing.Size(100, 20);
            this.matrizN.TabIndex = 8;
            // 
            // matrizM
            // 
            this.matrizM.Location = new System.Drawing.Point(998, 126);
            this.matrizM.Name = "matrizM";
            this.matrizM.Size = new System.Drawing.Size(100, 20);
            this.matrizM.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1002, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Columnas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(962, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valores para la Matriz";
            // 
            // mostrarMatriz
            // 
            this.mostrarMatriz.Location = new System.Drawing.Point(634, 82);
            this.mostrarMatriz.Name = "mostrarMatriz";
            this.mostrarMatriz.Size = new System.Drawing.Size(115, 35);
            this.mostrarMatriz.TabIndex = 14;
            this.mostrarMatriz.Text = "Mostrar Matriz";
            this.mostrarMatriz.UseVisualStyleBackColor = true;
            this.mostrarMatriz.Click += new System.EventHandler(this.mostrarMatriz_Click);
            // 
            // buttonCrearMatriz
            // 
            this.buttonCrearMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.buttonCrearMatriz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearMatriz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCrearMatriz.Location = new System.Drawing.Point(925, 156);
            this.buttonCrearMatriz.Name = "buttonCrearMatriz";
            this.buttonCrearMatriz.Size = new System.Drawing.Size(137, 48);
            this.buttonCrearMatriz.TabIndex = 15;
            this.buttonCrearMatriz.Text = "Crear Matriz";
            this.buttonCrearMatriz.UseVisualStyleBackColor = false;
            this.buttonCrearMatriz.Click += new System.EventHandler(this.buttonCrearMatriz_Click);
            // 
            // buttonGuardarValorMatriz
            // 
            this.buttonGuardarValorMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.buttonGuardarValorMatriz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarValorMatriz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardarValorMatriz.Location = new System.Drawing.Point(944, 542);
            this.buttonGuardarValorMatriz.Name = "buttonGuardarValorMatriz";
            this.buttonGuardarValorMatriz.Size = new System.Drawing.Size(137, 48);
            this.buttonGuardarValorMatriz.TabIndex = 16;
            this.buttonGuardarValorMatriz.Text = "Guardar Valor";
            this.buttonGuardarValorMatriz.UseVisualStyleBackColor = false;
            this.buttonGuardarValorMatriz.Click += new System.EventHandler(this.buttonGuardarValorMatriz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(881, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 238);
            this.dataGridView1.TabIndex = 17;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Matrices_Vectores_Windows_Forms.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1228, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuardarValorMatriz);
            this.Controls.Add(this.buttonCrearMatriz);
            this.Controls.Add(this.mostrarMatriz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matrizM);
            this.Controls.Add(this.matrizN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mostrarVector);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vectorImput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vectorImput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mostrar;
        private System.Windows.Forms.Button mostrarVector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matrizN;
        private System.Windows.Forms.TextBox matrizM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mostrarMatriz;
        private System.Windows.Forms.Button buttonCrearMatriz;
        private System.Windows.Forms.Button buttonGuardarValorMatriz;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

