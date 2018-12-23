namespace WebParserReborn
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.historyRtb = new System.Windows.Forms.RichTextBox();
            this.clearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyRtb
            // 
            this.historyRtb.Location = new System.Drawing.Point(12, 12);
            this.historyRtb.Name = "historyRtb";
            this.historyRtb.Size = new System.Drawing.Size(409, 402);
            this.historyRtb.TabIndex = 0;
            this.historyRtb.Text = "";
            // 
            // clearHistory
            // 
            this.clearHistory.Location = new System.Drawing.Point(12, 420);
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(409, 23);
            this.clearHistory.TabIndex = 1;
            this.clearHistory.Text = "Очистить историю";
            this.clearHistory.UseVisualStyleBackColor = true;
            this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.clearHistory);
            this.Controls.Add(this.historyRtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "История";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox historyRtb;
        private System.Windows.Forms.Button clearHistory;
    }
}