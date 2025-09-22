namespace aignacion05_00000253313
{
    partial class MetodoNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoNS));
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtErrorMaximo = new System.Windows.Forms.TextBox();
            this.lblErrorMaximo = new System.Windows.Forms.Label();
            this.radSecante = new System.Windows.Forms.RadioButton();
            this.radNewton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblX1 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lblMetodoSecante = new System.Windows.Forms.Label();
            this.lblMetodoNewton = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(423, 261);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(282, 22);
            this.txtXi.TabIndex = 0;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXi.Location = new System.Drawing.Point(468, 218);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(154, 16);
            this.lblXi.TabIndex = 1;
            this.lblXi.Text = "Ingresa el valor de Xi";
            this.lblXi.Click += new System.EventHandler(this.lblXi_Click);
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(573, 218);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(158, 16);
            this.lblX2.TabIndex = 2;
            this.lblX2.Text = "Ingresa el valor de X2";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(576, 237);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(138, 22);
            this.txtX2.TabIndex = 3;
            // 
            // txtErrorMaximo
            // 
            this.txtErrorMaximo.Location = new System.Drawing.Point(412, 176);
            this.txtErrorMaximo.Name = "txtErrorMaximo";
            this.txtErrorMaximo.Size = new System.Drawing.Size(282, 22);
            this.txtErrorMaximo.TabIndex = 4;
            // 
            // lblErrorMaximo
            // 
            this.lblErrorMaximo.AutoSize = true;
            this.lblErrorMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMaximo.Location = new System.Drawing.Point(480, 157);
            this.lblErrorMaximo.Name = "lblErrorMaximo";
            this.lblErrorMaximo.Size = new System.Drawing.Size(167, 16);
            this.lblErrorMaximo.TabIndex = 5;
            this.lblErrorMaximo.Text = "Ingresa el ErrorMaximo";
            // 
            // radSecante
            // 
            this.radSecante.AutoSize = true;
            this.radSecante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSecante.Location = new System.Drawing.Point(356, 113);
            this.radSecante.Name = "radSecante";
            this.radSecante.Size = new System.Drawing.Size(180, 20);
            this.radSecante.TabIndex = 6;
            this.radSecante.TabStop = true;
            this.radSecante.Text = "Metodo de la Secante";
            this.radSecante.UseVisualStyleBackColor = true;
            this.radSecante.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radNewton
            // 
            this.radNewton.AutoSize = true;
            this.radNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNewton.Location = new System.Drawing.Point(576, 113);
            this.radNewton.Name = "radNewton";
            this.radNewton.Size = new System.Drawing.Size(219, 20);
            this.radNewton.TabIndex = 7;
            this.radNewton.TabStop = true;
            this.radNewton.Text = "Metodo de NewtonRaphson";
            this.radNewton.UseVisualStyleBackColor = true;
            this.radNewton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(398, 218);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(158, 16);
            this.lblX1.TabIndex = 8;
            this.lblX1.Text = "Ingresa el valor de X1";
            this.lblX1.Click += new System.EventHandler(this.lblX1_Click);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(412, 237);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(147, 22);
            this.txtX1.TabIndex = 9;
            // 
            // lblMetodoSecante
            // 
            this.lblMetodoSecante.AutoSize = true;
            this.lblMetodoSecante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoSecante.Location = new System.Drawing.Point(449, 32);
            this.lblMetodoSecante.Name = "lblMetodoSecante";
            this.lblMetodoSecante.Size = new System.Drawing.Size(210, 22);
            this.lblMetodoSecante.TabIndex = 10;
            this.lblMetodoSecante.Text = "Metodo de La Secante";
            // 
            // lblMetodoNewton
            // 
            this.lblMetodoNewton.AutoSize = true;
            this.lblMetodoNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoNewton.Location = new System.Drawing.Point(419, 54);
            this.lblMetodoNewton.Name = "lblMetodoNewton";
            this.lblMetodoNewton.Size = new System.Drawing.Size(261, 22);
            this.lblMetodoNewton.TabIndex = 11;
            this.lblMetodoNewton.Text = "Metodo de Newton Raphson";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(33, 355);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.Size = new System.Drawing.Size(1078, 325);
            this.dgvResultado.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orange;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(504, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 35);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // MetodoNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1123, 694);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.lblMetodoNewton);
            this.Controls.Add(this.lblMetodoSecante);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.radNewton);
            this.Controls.Add(this.radSecante);
            this.Controls.Add(this.lblErrorMaximo);
            this.Controls.Add(this.txtErrorMaximo);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.txtXi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetodoNS";
            this.Text = "MetodoNewtonSecuencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtErrorMaximo;
        private System.Windows.Forms.Label lblErrorMaximo;
        private System.Windows.Forms.RadioButton radSecante;
        private System.Windows.Forms.RadioButton radNewton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lblMetodoSecante;
        private System.Windows.Forms.Label lblMetodoNewton;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}