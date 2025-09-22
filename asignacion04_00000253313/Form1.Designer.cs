namespace asignacion04_00000253313
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblxi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtErrorMaximo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.radbtnReglaFalsa = new System.Windows.Forms.RadioButton();
            this.radbtnBiseccion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxi
            // 
            this.lblxi.AutoSize = true;
            this.lblxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxi.Location = new System.Drawing.Point(52, 86);
            this.lblxi.Name = "lblxi";
            this.lblxi.Size = new System.Drawing.Size(211, 20);
            this.lblxi.TabIndex = 0;
            this.lblxi.Text = "Ingresa el valor de la xi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el valor de la xf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el Error Aproximado Maximo";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(53, 105);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(260, 22);
            this.txtXi.TabIndex = 3;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(53, 178);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(260, 22);
            this.txtXf.TabIndex = 4;
            // 
            // txtErrorMaximo
            // 
            this.txtErrorMaximo.Location = new System.Drawing.Point(53, 253);
            this.txtErrorMaximo.Name = "txtErrorMaximo";
            this.txtErrorMaximo.Size = new System.Drawing.Size(260, 22);
            this.txtErrorMaximo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orange;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(120, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(332, 41);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.Size = new System.Drawing.Size(897, 400);
            this.dgvResultado.TabIndex = 7;
            // 
            // radbtnReglaFalsa
            // 
            this.radbtnReglaFalsa.AutoSize = true;
            this.radbtnReglaFalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReglaFalsa.Location = new System.Drawing.Point(71, 349);
            this.radbtnReglaFalsa.Name = "radbtnReglaFalsa";
            this.radbtnReglaFalsa.Size = new System.Drawing.Size(208, 20);
            this.radbtnReglaFalsa.TabIndex = 8;
            this.radbtnReglaFalsa.TabStop = true;
            this.radbtnReglaFalsa.Text = "Metodo de la Regla Falsa";
            this.radbtnReglaFalsa.UseVisualStyleBackColor = true;
            // 
            // radbtnBiseccion
            // 
            this.radbtnBiseccion.AutoSize = true;
            this.radbtnBiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnBiseccion.Location = new System.Drawing.Point(71, 393);
            this.radbtnBiseccion.Name = "radbtnBiseccion";
            this.radbtnBiseccion.Size = new System.Drawing.Size(174, 20);
            this.radbtnBiseccion.TabIndex = 9;
            this.radbtnBiseccion.TabStop = true;
            this.radbtnBiseccion.Text = "Metodo de Biseccion";
            this.radbtnBiseccion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 571);
            this.Controls.Add(this.radbtnBiseccion);
            this.Controls.Add(this.radbtnReglaFalsa);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtErrorMaximo);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblxi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Implementacion de Metodos de Raices de Funciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtErrorMaximo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.RadioButton radbtnReglaFalsa;
        private System.Windows.Forms.RadioButton radbtnBiseccion;
    }
}

