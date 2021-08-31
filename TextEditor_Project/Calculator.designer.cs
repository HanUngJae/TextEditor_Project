namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.ResultScreen = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.bu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberScreen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(44, 342);
            this.NumButton1.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(88, 76);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(140, 342);
            this.NumButton2.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(88, 76);
            this.NumButton2.TabIndex = 2;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(236, 342);
            this.NumButton3.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(88, 76);
            this.NumButton3.TabIndex = 3;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // ResultScreen
            // 
            this.ResultScreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultScreen.Location = new System.Drawing.Point(43, 117);
            this.ResultScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.Size = new System.Drawing.Size(375, 41);
            this.ResultScreen.TabIndex = 4;
            this.ResultScreen.Text = "0";
            this.ResultScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(333, 174);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(88, 76);
            this.Plus.TabIndex = 5;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Opt_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(44, 258);
            this.NumButton4.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(88, 76);
            this.NumButton4.TabIndex = 6;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(140, 258);
            this.NumButton5.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(88, 76);
            this.NumButton5.TabIndex = 7;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(44, 174);
            this.NumButton7.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(88, 76);
            this.NumButton7.TabIndex = 8;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(140, 174);
            this.NumButton8.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(88, 76);
            this.NumButton8.TabIndex = 9;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(238, 258);
            this.NumButton6.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(88, 76);
            this.NumButton6.TabIndex = 10;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(238, 174);
            this.NumButton9.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(88, 76);
            this.NumButton9.TabIndex = 11;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(140, 426);
            this.NumButton0.Margin = new System.Windows.Forms.Padding(4);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(88, 76);
            this.NumButton0.TabIndex = 13;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // bu
            // 
            this.bu.Location = new System.Drawing.Point(333, 258);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(88, 76);
            this.bu.TabIndex = 14;
            this.bu.Text = "-";
            this.bu.UseVisualStyleBackColor = true;
            this.bu.Click += new System.EventHandler(this.Opt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Opt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 76);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 76);
            this.button3.TabIndex = 17;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Opt_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 76);
            this.button4.TabIndex = 18;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Opt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "결과";
            // 
            // NumberScreen
            // 
            this.NumberScreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumberScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberScreen.Location = new System.Drawing.Point(43, 63);
            this.NumberScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberScreen.Name = "NumberScreen";
            this.NumberScreen.Size = new System.Drawing.Size(375, 41);
            this.NumberScreen.TabIndex = 22;
            this.NumberScreen.Text = "0";
            this.NumberScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumberScreen.Click += new System.EventHandler(this.NumberScreen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "수식";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberScreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bu);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.ResultScreen);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Label ResultScreen;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button NumButton4;
        private System.Windows.Forms.Button NumButton5;
        private System.Windows.Forms.Button NumButton7;
        private System.Windows.Forms.Button NumButton8;
        private System.Windows.Forms.Button NumButton6;
        private System.Windows.Forms.Button NumButton9;
        private System.Windows.Forms.Button NumButton0;
        private System.Windows.Forms.Button bu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberScreen;
        private System.Windows.Forms.Label label2;
    }
}

