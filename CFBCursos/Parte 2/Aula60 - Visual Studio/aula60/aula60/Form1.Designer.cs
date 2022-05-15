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
            this.btn_canal = new System.Windows.Forms.Button();
            this.lb_linkCanal = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_canal
            // 
            this.btn_canal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_canal.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canal.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_canal.Location = new System.Drawing.Point(188, 76);
            this.btn_canal.Name = "btn_canal";
            this.btn_canal.Size = new System.Drawing.Size(386, 177);
            this.btn_canal.TabIndex = 0;
            this.btn_canal.Text = "Texto do botão";
            this.btn_canal.UseVisualStyleBackColor = false;
            // 
            // lb_linkCanal
            // 
            this.lb_linkCanal.AutoSize = true;
            this.lb_linkCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linkCanal.Location = new System.Drawing.Point(262, 31);
            this.lb_linkCanal.Name = "lb_linkCanal";
            this.lb_linkCanal.Size = new System.Drawing.Size(232, 42);
            this.lb_linkCanal.TabIndex = 1;
            this.lb_linkCanal.Text = "youtube.com";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(188, 269);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(386, 22);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 385);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_linkCanal);
            this.Controls.Add(this.btn_canal);
            this.Name = "Form1";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_canal;
        private System.Windows.Forms.Label lb_linkCanal;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

