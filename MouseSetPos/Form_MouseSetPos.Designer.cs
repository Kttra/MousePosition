namespace MouseSetPos
{
    partial class Form_MouseSetPos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPos = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPos
            // 
            this.labelPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPos.AutoSize = true;
            this.labelPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPos.Location = new System.Drawing.Point(12, 28);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(275, 40);
            this.labelPos.TabIndex = 0;
            this.labelPos.Text = "x=0000; y=0000";
            // 
            // BtnChange
            // 
            this.BtnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChange.Location = new System.Drawing.Point(109, 84);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(75, 23);
            this.BtnChange.TabIndex = 1;
            this.BtnChange.Text = "Reset";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // Form_MouseSetPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 124);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.labelPos);
            this.Name = "Form_MouseSetPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Position Changer";
            this.Load += new System.EventHandler(this.Form_MouseSetPos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPos;
        private Button BtnChange;
    }
}