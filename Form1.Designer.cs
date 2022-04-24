namespace flab1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.solutionPanel = new System.Windows.Forms.Panel();
            this.ptPanel = new System.Windows.Forms.Panel();
            this.ptLabelAnswer = new System.Windows.Forms.Label();
            this.ptLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lambdaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.ptCheckBox = new System.Windows.Forms.CheckBox();
            this.ftCheckBox = new System.Windows.Forms.CheckBox();
            this.ftPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ft1Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ft2Label = new System.Windows.Forms.Label();
            this.ftResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.solutionPanel.SuspendLayout();
            this.ptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(217, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 650);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // solutionPanel
            // 
            this.solutionPanel.Controls.Add(this.ftPanel);
            this.solutionPanel.Controls.Add(this.ptPanel);
            this.solutionPanel.Controls.Add(this.label2);
            this.solutionPanel.Location = new System.Drawing.Point(245, 0);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(709, 441);
            this.solutionPanel.TabIndex = 2;
            // 
            // ptPanel
            // 
            this.ptPanel.BackColor = System.Drawing.Color.White;
            this.ptPanel.Controls.Add(this.ptLabelAnswer);
            this.ptPanel.Controls.Add(this.ptLabel);
            this.ptPanel.Controls.Add(this.label3);
            this.ptPanel.Controls.Add(this.pictureBox2);
            this.ptPanel.Location = new System.Drawing.Point(3, 32);
            this.ptPanel.Name = "ptPanel";
            this.ptPanel.Size = new System.Drawing.Size(292, 45);
            this.ptPanel.TabIndex = 8;
            this.ptPanel.Visible = false;
            // 
            // ptLabelAnswer
            // 
            this.ptLabelAnswer.AutoSize = true;
            this.ptLabelAnswer.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptLabelAnswer.Location = new System.Drawing.Point(195, 22);
            this.ptLabelAnswer.Name = "ptLabelAnswer";
            this.ptLabelAnswer.Size = new System.Drawing.Size(0, 15);
            this.ptLabelAnswer.TabIndex = 3;
            // 
            // ptLabel
            // 
            this.ptLabel.AutoSize = true;
            this.ptLabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptLabel.Location = new System.Drawing.Point(171, 6);
            this.ptLabel.Name = "ptLabel";
            this.ptLabel.Size = new System.Drawing.Size(0, 15);
            this.ptLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "P(t)= e  =";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Решение:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lambdaBox
            // 
            this.lambdaBox.Location = new System.Drawing.Point(62, 50);
            this.lambdaBox.Name = "lambdaBox";
            this.lambdaBox.Size = new System.Drawing.Size(100, 20);
            this.lambdaBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "t";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(62, 77);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(99, 20);
            this.timeBox.TabIndex = 6;
            // 
            // ptCheckBox
            // 
            this.ptCheckBox.AutoSize = true;
            this.ptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptCheckBox.Location = new System.Drawing.Point(5, 396);
            this.ptCheckBox.Name = "ptCheckBox";
            this.ptCheckBox.Size = new System.Drawing.Size(51, 20);
            this.ptCheckBox.TabIndex = 7;
            this.ptCheckBox.Text = "P(t)";
            this.ptCheckBox.UseVisualStyleBackColor = true;
            // 
            // ftCheckBox
            // 
            this.ftCheckBox.AutoSize = true;
            this.ftCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ftCheckBox.Location = new System.Drawing.Point(5, 421);
            this.ftCheckBox.Name = "ftCheckBox";
            this.ftCheckBox.Size = new System.Drawing.Size(45, 20);
            this.ftCheckBox.TabIndex = 8;
            this.ftCheckBox.Text = "f(t)";
            this.ftCheckBox.UseVisualStyleBackColor = true;
            this.ftCheckBox.CheckedChanged += new System.EventHandler(this.FtCheckBox_CheckedChanged);
            // 
            // ftPanel
            // 
            this.ftPanel.BackColor = System.Drawing.Color.White;
            this.ftPanel.Controls.Add(this.ftResult);
            this.ftPanel.Controls.Add(this.ft2Label);
            this.ftPanel.Controls.Add(this.label5);
            this.ftPanel.Controls.Add(this.ft1Label);
            this.ftPanel.Controls.Add(this.label4);
            this.ftPanel.Controls.Add(this.pictureBox3);
            this.ftPanel.Location = new System.Drawing.Point(307, 32);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(332, 45);
            this.ftPanel.TabIndex = 9;
            this.ftPanel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "f(t)=";
            // 
            // ft1Label
            // 
            this.ft1Label.AutoSize = true;
            this.ft1Label.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ft1Label.Location = new System.Drawing.Point(160, 19);
            this.ft1Label.Name = "ft1Label";
            this.ft1Label.Size = new System.Drawing.Size(45, 15);
            this.ft1Label.TabIndex = 2;
            this.ft1Label.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(206, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "*e  =";
            // 
            // ft2Label
            // 
            this.ft2Label.AutoSize = true;
            this.ft2Label.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ft2Label.Location = new System.Drawing.Point(220, 5);
            this.ft2Label.Name = "ft2Label";
            this.ft2Label.Size = new System.Drawing.Size(45, 15);
            this.ft2Label.TabIndex = 4;
            this.ft2Label.Text = "label6";
            // 
            // ftResult
            // 
            this.ftResult.AutoSize = true;
            this.ftResult.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ftResult.Location = new System.Drawing.Point(242, 20);
            this.ftResult.Name = "ftResult";
            this.ftResult.Size = new System.Drawing.Size(45, 15);
            this.ftResult.TabIndex = 5;
            this.ftResult.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дано:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // mtBox
            // 
            this.mtBox.Location = new System.Drawing.Point(62, 103);
            this.mtBox.Name = "mtBox";
            this.mtBox.Size = new System.Drawing.Size(100, 20);
            this.mtBox.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 16);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(966, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mtBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ftCheckBox);
            this.Controls.Add(this.ptCheckBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lambdaBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.solutionPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.solutionPanel.ResumeLayout(false);
            this.solutionPanel.PerformLayout();
            this.ptPanel.ResumeLayout(false);
            this.ptPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ftPanel.ResumeLayout(false);
            this.ftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel solutionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lambdaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ptPanel;
        private System.Windows.Forms.Label ptLabelAnswer;
        private System.Windows.Forms.Label ptLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ptCheckBox;
        private System.Windows.Forms.CheckBox ftCheckBox;
        private System.Windows.Forms.Panel ftPanel;
        private System.Windows.Forms.Label ft1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ftResult;
        private System.Windows.Forms.Label ft2Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox mtBox;
        private System.Windows.Forms.Panel panel2;
    }
}

