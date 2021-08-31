namespace _0522
{
    partial class 찾기
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
            this.lbl_Find = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gb_Direction = new System.Windows.Forms.GroupBox();
            this.rdo_Down = new System.Windows.Forms.RadioButton();
            this.rdo_Up = new System.Windows.Forms.RadioButton();
            this.chk_Case = new System.Windows.Forms.CheckBox();
            this.gb_Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Find
            // 
            this.lbl_Find.AutoSize = true;
            this.lbl_Find.Location = new System.Drawing.Point(12, 21);
            this.lbl_Find.Name = "lbl_Find";
            this.lbl_Find.Size = new System.Drawing.Size(80, 12);
            this.lbl_Find.TabIndex = 1;
            this.lbl_Find.Text = "찾을 내용(&N):";
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(130, 18);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(218, 21);
            this.txt_Find.TabIndex = 2;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Enabled = false;
            this.btn_Find.Location = new System.Drawing.Point(387, 16);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(88, 23);
            this.btn_Find.TabIndex = 3;
            this.btn_Find.Text = "다음 찾기(&F)";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(387, 45);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // gb_Direction
            // 
            this.gb_Direction.Controls.Add(this.rdo_Down);
            this.gb_Direction.Controls.Add(this.rdo_Up);
            this.gb_Direction.Location = new System.Drawing.Point(157, 65);
            this.gb_Direction.Name = "gb_Direction";
            this.gb_Direction.Size = new System.Drawing.Size(191, 56);
            this.gb_Direction.TabIndex = 6;
            this.gb_Direction.TabStop = false;
            this.gb_Direction.Text = "방향";
            // 
            // rdo_Down
            // 
            this.rdo_Down.AutoSize = true;
            this.rdo_Down.Checked = true;
            this.rdo_Down.Location = new System.Drawing.Point(96, 21);
            this.rdo_Down.Name = "rdo_Down";
            this.rdo_Down.Size = new System.Drawing.Size(77, 16);
            this.rdo_Down.TabIndex = 1;
            this.rdo_Down.TabStop = true;
            this.rdo_Down.Text = "아래로(&D)";
            this.rdo_Down.UseVisualStyleBackColor = true;
            // 
            // rdo_Up
            // 
            this.rdo_Up.AutoSize = true;
            this.rdo_Up.Location = new System.Drawing.Point(16, 21);
            this.rdo_Up.Name = "rdo_Up";
            this.rdo_Up.Size = new System.Drawing.Size(65, 16);
            this.rdo_Up.TabIndex = 0;
            this.rdo_Up.TabStop = true;
            this.rdo_Up.Text = "위로(&U)";
            this.rdo_Up.UseVisualStyleBackColor = true;
            // 
            // chk_Case
            // 
            this.chk_Case.AutoSize = true;
            this.chk_Case.Location = new System.Drawing.Point(14, 88);
            this.chk_Case.Name = "chk_Case";
            this.chk_Case.Size = new System.Drawing.Size(125, 16);
            this.chk_Case.TabIndex = 7;
            this.chk_Case.Text = "대/소문자 구분(&C)";
            this.chk_Case.UseVisualStyleBackColor = true;
            // 
            // 찾기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 132);
            this.Controls.Add(this.chk_Case);
            this.Controls.Add(this.gb_Direction);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.lbl_Find);
            this.MaximizeBox = false;
            this.Name = "찾기";
            this.Text = "찾기";
            this.gb_Direction.ResumeLayout(false);
            this.gb_Direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox gb_Direction;
        private System.Windows.Forms.RadioButton rdo_Down;
        private System.Windows.Forms.RadioButton rdo_Up;
        private System.Windows.Forms.CheckBox chk_Case;
    }
}