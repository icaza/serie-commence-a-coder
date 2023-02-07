namespace Premier
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
            this.Bouton_Btn = new System.Windows.Forms.Button();
            this.ZoneText_Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bouton_Btn
            // 
            this.Bouton_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bouton_Btn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton_Btn.Location = new System.Drawing.Point(38, 21);
            this.Bouton_Btn.Name = "Bouton_Btn";
            this.Bouton_Btn.Size = new System.Drawing.Size(120, 23);
            this.Bouton_Btn.TabIndex = 0;
            this.Bouton_Btn.Text = "Clique";
            this.Bouton_Btn.UseVisualStyleBackColor = true;
            this.Bouton_Btn.Click += new System.EventHandler(this.Bouton_Btn_Click);
            // 
            // ZoneText_Txt
            // 
            this.ZoneText_Txt.BackColor = System.Drawing.Color.SkyBlue;
            this.ZoneText_Txt.Location = new System.Drawing.Point(164, 23);
            this.ZoneText_Txt.Name = "ZoneText_Txt";
            this.ZoneText_Txt.Size = new System.Drawing.Size(447, 20);
            this.ZoneText_Txt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 68);
            this.Controls.Add(this.ZoneText_Txt);
            this.Controls.Add(this.Bouton_Btn);
            this.Name = "Form1";
            this.Text = "Premier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Btn;
        private System.Windows.Forms.TextBox ZoneText_Txt;
    }
}

