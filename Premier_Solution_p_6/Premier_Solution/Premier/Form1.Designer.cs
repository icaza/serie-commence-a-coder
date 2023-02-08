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
            this.Chk_Google = new System.Windows.Forms.CheckBox();
            this.Chk_Wiki = new System.Windows.Forms.CheckBox();
            this.Liste_Lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Bouton_Btn
            // 
            this.Bouton_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bouton_Btn.Location = new System.Drawing.Point(200, 11);
            this.Bouton_Btn.Name = "Bouton_Btn";
            this.Bouton_Btn.Size = new System.Drawing.Size(120, 23);
            this.Bouton_Btn.TabIndex = 0;
            this.Bouton_Btn.Text = "Clique";
            this.Bouton_Btn.UseVisualStyleBackColor = true;
            this.Bouton_Btn.Click += new System.EventHandler(this.Bouton_Btn_Click);
            // 
            // ZoneText_Txt
            // 
            this.ZoneText_Txt.Location = new System.Drawing.Point(12, 12);
            this.ZoneText_Txt.Name = "ZoneText_Txt";
            this.ZoneText_Txt.Size = new System.Drawing.Size(182, 20);
            this.ZoneText_Txt.TabIndex = 1;
            // 
            // Chk_Google
            // 
            this.Chk_Google.AutoSize = true;
            this.Chk_Google.Checked = true;
            this.Chk_Google.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Google.Location = new System.Drawing.Point(100, 49);
            this.Chk_Google.Name = "Chk_Google";
            this.Chk_Google.Size = new System.Drawing.Size(60, 17);
            this.Chk_Google.TabIndex = 2;
            this.Chk_Google.Text = "Google";
            this.Chk_Google.UseVisualStyleBackColor = true;
            // 
            // Chk_Wiki
            // 
            this.Chk_Wiki.AutoSize = true;
            this.Chk_Wiki.Location = new System.Drawing.Point(187, 49);
            this.Chk_Wiki.Name = "Chk_Wiki";
            this.Chk_Wiki.Size = new System.Drawing.Size(73, 17);
            this.Chk_Wiki.TabIndex = 3;
            this.Chk_Wiki.Text = "Wikipedia";
            this.Chk_Wiki.UseVisualStyleBackColor = true;
            // 
            // Liste_Lst
            // 
            this.Liste_Lst.FormattingEnabled = true;
            this.Liste_Lst.Location = new System.Drawing.Point(12, 72);
            this.Liste_Lst.Name = "Liste_Lst";
            this.Liste_Lst.Size = new System.Drawing.Size(308, 212);
            this.Liste_Lst.Sorted = true;
            this.Liste_Lst.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 295);
            this.Controls.Add(this.Liste_Lst);
            this.Controls.Add(this.Chk_Wiki);
            this.Controls.Add(this.Chk_Google);
            this.Controls.Add(this.ZoneText_Txt);
            this.Controls.Add(this.Bouton_Btn);
            this.Name = "Form1";
            this.Text = "Premier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Btn;
        private System.Windows.Forms.TextBox ZoneText_Txt;
        private System.Windows.Forms.CheckBox Chk_Google;
        private System.Windows.Forms.CheckBox Chk_Wiki;
        private System.Windows.Forms.ListBox Liste_Lst;
    }
}

