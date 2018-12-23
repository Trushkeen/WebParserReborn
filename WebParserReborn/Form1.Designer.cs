namespace WebParserReborn
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkBox = new System.Windows.Forms.TextBox();
            this.labelAboveTextBox = new System.Windows.Forms.Label();
            this.parseBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.advancedMode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.method3 = new System.Windows.Forms.RadioButton();
            this.method2 = new System.Windows.Forms.RadioButton();
            this.method1 = new System.Windows.Forms.RadioButton();
            this.autoRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.autoBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.showHistory = new System.Windows.Forms.Button();
            this.clearLinkBox = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(12, 29);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(328, 20);
            this.linkBox.TabIndex = 0;
            // 
            // labelAboveTextBox
            // 
            this.labelAboveTextBox.AutoSize = true;
            this.labelAboveTextBox.Location = new System.Drawing.Point(13, 13);
            this.labelAboveTextBox.Name = "labelAboveTextBox";
            this.labelAboveTextBox.Size = new System.Drawing.Size(62, 13);
            this.labelAboveTextBox.TabIndex = 1;
            this.labelAboveTextBox.Text = "Веб-адрес:";
            // 
            // parseBtn
            // 
            this.parseBtn.Location = new System.Drawing.Point(11, 55);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(175, 23);
            this.parseBtn.TabIndex = 2;
            this.parseBtn.Text = "Парсить";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(192, 55);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(175, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Сохранить в ,doc";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // advancedMode
            // 
            this.advancedMode.AutoSize = true;
            this.advancedMode.Location = new System.Drawing.Point(269, 84);
            this.advancedMode.Name = "advancedMode";
            this.advancedMode.Size = new System.Drawing.Size(98, 17);
            this.advancedMode.TabIndex = 4;
            this.advancedMode.Text = "Ручной режим";
            this.advancedMode.UseVisualStyleBackColor = true;
            this.advancedMode.CheckedChanged += new System.EventHandler(this.advancedMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.method3);
            this.groupBox1.Controls.Add(this.method2);
            this.groupBox1.Controls.Add(this.method1);
            this.groupBox1.Controls.Add(this.autoRadioBtn1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод";
            // 
            // method3
            // 
            this.method3.AutoSize = true;
            this.method3.Location = new System.Drawing.Point(190, 19);
            this.method3.Name = "method3";
            this.method3.Size = new System.Drawing.Size(31, 17);
            this.method3.TabIndex = 3;
            this.method3.Text = "3";
            this.method3.UseVisualStyleBackColor = true;
            this.method3.CheckedChanged += new System.EventHandler(this.method3_CheckedChanged_1);
            // 
            // method2
            // 
            this.method2.AutoSize = true;
            this.method2.Location = new System.Drawing.Point(153, 19);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(31, 17);
            this.method2.TabIndex = 2;
            this.method2.Text = "2";
            this.method2.UseVisualStyleBackColor = true;
            this.method2.CheckedChanged += new System.EventHandler(this.method2_CheckedChanged_1);
            // 
            // method1
            // 
            this.method1.AutoSize = true;
            this.method1.Location = new System.Drawing.Point(116, 19);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(31, 17);
            this.method1.TabIndex = 1;
            this.method1.Text = "1";
            this.method1.UseMnemonic = false;
            this.method1.UseVisualStyleBackColor = true;
            this.method1.CheckedChanged += new System.EventHandler(this.method1_CheckedChanged_1);
            // 
            // autoRadioBtn1
            // 
            this.autoRadioBtn1.AutoSize = true;
            this.autoRadioBtn1.Checked = true;
            this.autoRadioBtn1.Location = new System.Drawing.Point(6, 19);
            this.autoRadioBtn1.Name = "autoRadioBtn1";
            this.autoRadioBtn1.Size = new System.Drawing.Size(103, 17);
            this.autoRadioBtn1.TabIndex = 0;
            this.autoRadioBtn1.TabStop = true;
            this.autoRadioBtn1.Text = "Автоматически";
            this.autoRadioBtn1.UseVisualStyleBackColor = true;
            this.autoRadioBtn1.CheckedChanged += new System.EventHandler(this.autoRadioBtn1_CheckedChanged);
            // 
            // autoBtn
            // 
            this.autoBtn.Location = new System.Drawing.Point(11, 55);
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.Size = new System.Drawing.Size(355, 23);
            this.autoBtn.TabIndex = 6;
            this.autoBtn.Text = "Парсинг и сохранение";
            this.autoBtn.UseVisualStyleBackColor = true;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(11, 85);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Ожидание ввода";
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(252, 13);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerLabel.Size = new System.Drawing.Size(114, 13);
            this.timerLabel.TabIndex = 8;
            this.timerLabel.Text = "Время";
            // 
            // showHistory
            // 
            this.showHistory.Location = new System.Drawing.Point(292, 137);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(75, 23);
            this.showHistory.TabIndex = 9;
            this.showHistory.Text = "История";
            this.showHistory.UseVisualStyleBackColor = true;
            this.showHistory.Click += new System.EventHandler(this.showHistory_Click);
            // 
            // clearLinkBox
            // 
            this.clearLinkBox.Location = new System.Drawing.Point(346, 29);
            this.clearLinkBox.Name = "clearLinkBox";
            this.clearLinkBox.Size = new System.Drawing.Size(20, 20);
            this.clearLinkBox.TabIndex = 10;
            this.clearLinkBox.Text = "X";
            this.clearLinkBox.UseVisualStyleBackColor = true;
            this.clearLinkBox.Click += new System.EventHandler(this.clearLinkBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 111);
            this.Controls.Add(this.clearLinkBox);
            this.Controls.Add(this.showHistory);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.advancedMode);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.labelAboveTextBox);
            this.Controls.Add(this.linkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebParser v1.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Label labelAboveTextBox;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.CheckBox advancedMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton method3;
        private System.Windows.Forms.RadioButton method2;
        private System.Windows.Forms.RadioButton method1;
        private System.Windows.Forms.RadioButton autoRadioBtn1;
        private System.Windows.Forms.Button autoBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button showHistory;
        private System.Windows.Forms.Button clearLinkBox;
    }
}

