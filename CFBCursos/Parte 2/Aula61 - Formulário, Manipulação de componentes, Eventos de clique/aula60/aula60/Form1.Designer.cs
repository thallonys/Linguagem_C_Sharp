namespace aula60
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
            this.btn_texto = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.SystemColors.Window;
            this.btn_texto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_texto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_texto.Location = new System.Drawing.Point(97, 93);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(92, 37);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "OK";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_texto.Location = new System.Drawing.Point(124, 159);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(39, 36);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "...";
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(13, 42);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(261, 22);
            this.tb_texto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(289, 219);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_texto);
            this.Name = "Form1";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

