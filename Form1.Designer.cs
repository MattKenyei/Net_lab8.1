namespace lab8._1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.utf8RadioButton = new System.Windows.Forms.RadioButton();
            this.utf16RadioButton = new System.Windows.Forms.RadioButton();
            this.ansiRadioButton = new System.Windows.Forms.RadioButton();
            this.utf32RadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 260);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // utf8RadioButton
            // 
            this.utf8RadioButton.AutoSize = true;
            this.utf8RadioButton.Location = new System.Drawing.Point(26, 40);
            this.utf8RadioButton.Name = "utf8RadioButton";
            this.utf8RadioButton.Size = new System.Drawing.Size(48, 20);
            this.utf8RadioButton.TabIndex = 4;
            this.utf8RadioButton.TabStop = true;
            this.utf8RadioButton.Text = "utf8";
            this.utf8RadioButton.UseVisualStyleBackColor = true;
            // 
            // utf16RadioButton
            // 
            this.utf16RadioButton.AutoSize = true;
            this.utf16RadioButton.Location = new System.Drawing.Point(104, 12);
            this.utf16RadioButton.Name = "utf16RadioButton";
            this.utf16RadioButton.Size = new System.Drawing.Size(55, 20);
            this.utf16RadioButton.TabIndex = 5;
            this.utf16RadioButton.TabStop = true;
            this.utf16RadioButton.Text = "utf16";
            this.utf16RadioButton.UseVisualStyleBackColor = true;
            this.utf16RadioButton.CheckedChanged += new System.EventHandler(this.utf16RadioButton_CheckedChanged);
            // 
            // ansiRadioButton
            // 
            this.ansiRadioButton.AutoSize = true;
            this.ansiRadioButton.Location = new System.Drawing.Point(104, 40);
            this.ansiRadioButton.Name = "ansiRadioButton";
            this.ansiRadioButton.Size = new System.Drawing.Size(59, 20);
            this.ansiRadioButton.TabIndex = 6;
            this.ansiRadioButton.TabStop = true;
            this.ansiRadioButton.Text = "ANSI";
            this.ansiRadioButton.UseVisualStyleBackColor = true;
            // 
            // utf32RadioButton
            // 
            this.utf32RadioButton.AutoSize = true;
            this.utf32RadioButton.Location = new System.Drawing.Point(26, 14);
            this.utf32RadioButton.Name = "utf32RadioButton";
            this.utf32RadioButton.Size = new System.Drawing.Size(55, 20);
            this.utf32RadioButton.TabIndex = 7;
            this.utf32RadioButton.TabStop = true;
            this.utf32RadioButton.Text = "utf32";
            this.utf32RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.utf32RadioButton);
            this.Controls.Add(this.ansiRadioButton);
            this.Controls.Add(this.utf16RadioButton);
            this.Controls.Add(this.utf8RadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чтение\\сохранение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton utf8RadioButton;
        private System.Windows.Forms.RadioButton utf16RadioButton;
        private System.Windows.Forms.RadioButton ansiRadioButton;
        private System.Windows.Forms.RadioButton utf32RadioButton;
    }
}

