namespace ExemploWFA
{
    partial class Exemplo05
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
            this.cbLeu = new System.Windows.Forms.CheckBox();
            this.cbComprou = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLeu
            // 
            this.cbLeu.AutoSize = true;
            this.cbLeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeu.Location = new System.Drawing.Point(12, 31);
            this.cbLeu.Name = "cbLeu";
            this.cbLeu.Size = new System.Drawing.Size(253, 28);
            this.cbLeu.TabIndex = 0;
            this.cbLeu.Text = "Confirma que leu tudo ?";
            this.cbLeu.UseVisualStyleBackColor = true;
            // 
            // cbComprou
            // 
            this.cbComprou.AutoSize = true;
            this.cbComprou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComprou.Location = new System.Drawing.Point(12, 97);
            this.cbComprou.Name = "cbComprou";
            this.cbComprou.Size = new System.Drawing.Size(259, 28);
            this.cbComprou.TabIndex = 1;
            this.cbComprou.Text = "Você comprou o WinRar";
            this.cbComprou.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exemplo05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbComprou);
            this.Controls.Add(this.cbLeu);
            this.Name = "Exemplo05";
            this.Text = "Exemplo05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLeu;
        private System.Windows.Forms.CheckBox cbComprou;
        private System.Windows.Forms.Button button1;
    }
}