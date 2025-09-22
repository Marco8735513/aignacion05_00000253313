namespace aignacion05_00000253313
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnAsignacion4 = new System.Windows.Forms.Button();
            this.btnAsignacion5 = new System.Windows.Forms.Button();
            this.btnTodosLosMetodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsignacion4
            // 
            this.btnAsignacion4.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAsignacion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion4.Location = new System.Drawing.Point(294, 176);
            this.btnAsignacion4.Name = "btnAsignacion4";
            this.btnAsignacion4.Size = new System.Drawing.Size(145, 49);
            this.btnAsignacion4.TabIndex = 0;
            this.btnAsignacion4.Text = "Asigancion 4";
            this.btnAsignacion4.UseVisualStyleBackColor = false;
            this.btnAsignacion4.Click += new System.EventHandler(this.btnAsignacion4_Click);
            // 
            // btnAsignacion5
            // 
            this.btnAsignacion5.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAsignacion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion5.Location = new System.Drawing.Point(294, 258);
            this.btnAsignacion5.Name = "btnAsignacion5";
            this.btnAsignacion5.Size = new System.Drawing.Size(145, 51);
            this.btnAsignacion5.TabIndex = 1;
            this.btnAsignacion5.Text = "Asignacion 5";
            this.btnAsignacion5.UseVisualStyleBackColor = false;
            this.btnAsignacion5.Click += new System.EventHandler(this.btnAsignacion5_Click);
            // 
            // btnTodosLosMetodos
            // 
            this.btnTodosLosMetodos.BackColor = System.Drawing.Color.Crimson;
            this.btnTodosLosMetodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLosMetodos.Location = new System.Drawing.Point(274, 105);
            this.btnTodosLosMetodos.Name = "btnTodosLosMetodos";
            this.btnTodosLosMetodos.Size = new System.Drawing.Size(191, 50);
            this.btnTodosLosMetodos.TabIndex = 2;
            this.btnTodosLosMetodos.Text = "Todos los metodos";
            this.btnTodosLosMetodos.UseVisualStyleBackColor = false;
            this.btnTodosLosMetodos.Click += new System.EventHandler(this.btnTodosLosMetodos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(728, 426);
            this.Controls.Add(this.btnTodosLosMetodos);
            this.Controls.Add(this.btnAsignacion5);
            this.Controls.Add(this.btnAsignacion4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignacion4;
        private System.Windows.Forms.Button btnAsignacion5;
        private System.Windows.Forms.Button btnTodosLosMetodos;
    }
}

