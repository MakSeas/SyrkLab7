namespace SyrkLab7
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
            this.funcCombo = new System.Windows.Forms.ComboBox();
            this.funcText = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unitText = new System.Windows.Forms.Label();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.precisionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // funcCombo
            // 
            this.funcCombo.FormattingEnabled = true;
            this.funcCombo.Location = new System.Drawing.Point(254, 205);
            this.funcCombo.Name = "funcCombo";
            this.funcCombo.Size = new System.Drawing.Size(119, 24);
            this.funcCombo.TabIndex = 0;
            // 
            // funcText
            // 
            this.funcText.AutoSize = true;
            this.funcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.funcText.Location = new System.Drawing.Point(275, 173);
            this.funcText.Name = "funcText";
            this.funcText.Size = new System.Drawing.Size(69, 29);
            this.funcText.TabIndex = 1;
            this.funcText.Text = "Func";
            // 
            // xText
            // 
            this.xText.AutoSize = true;
            this.xText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.xText.Location = new System.Drawing.Point(386, 173);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(30, 29);
            this.xText.TabIndex = 2;
            this.xText.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 22);
            this.textBox1.TabIndex = 3;
            // 
            // unitText
            // 
            this.unitText.AutoSize = true;
            this.unitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.unitText.Location = new System.Drawing.Point(435, 173);
            this.unitText.Name = "unitText";
            this.unitText.Size = new System.Drawing.Size(58, 29);
            this.unitText.TabIndex = 4;
            this.unitText.Text = "Unit";
            // 
            // unitCombo
            // 
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Location = new System.Drawing.Point(431, 207);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.Size = new System.Drawing.Size(62, 24);
            this.unitCombo.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(254, 235);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(286, 48);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Расчет";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // precisionText
            // 
            this.precisionText.Location = new System.Drawing.Point(499, 207);
            this.precisionText.Name = "precisionText";
            this.precisionText.Size = new System.Drawing.Size(41, 22);
            this.precisionText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(499, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precision";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precisionText);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.unitCombo);
            this.Controls.Add(this.unitText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.funcText);
            this.Controls.Add(this.funcCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcCombo;
        private System.Windows.Forms.Label funcText;
        private System.Windows.Forms.Label xText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label unitText;
        private System.Windows.Forms.ComboBox unitCombo;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox precisionText;
        private System.Windows.Forms.Label label1;
    }
}

