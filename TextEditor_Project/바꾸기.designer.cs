namespace TextEditor_Project
{
    partial class 바꾸기
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
            this.lbl_Replace = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.chk_Case = new System.Windows.Forms.CheckBox();
            this.gb_Direction = new System.Windows.Forms.GroupBox();
            this.rdo_Down = new System.Windows.Forms.RadioButton();
            this.rdo_Up = new System.Windows.Forms.RadioButton();
            this.gb_Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Find
            // 
            this.lbl_Find.AutoSize = true;
            this.lbl_Find.Location = new System.Drawing.Point(12, 25);
            this.lbl_Find.Name = "lbl_Find";
            this.lbl_Find.Size = new System.Drawing.Size(80, 12);
            this.lbl_Find.TabIndex = 7;
            this.lbl_Find.Text = "찾을 내용(&N):";
            // 
            // lbl_Replace
            // 
            this.lbl_Replace.AutoSize = true;
            this.lbl_Replace.Location = new System.Drawing.Point(13, 56);
            this.lbl_Replace.Name = "lbl_Replace";
            this.lbl_Replace.Size = new System.Drawing.Size(79, 12);
            this.lbl_Replace.TabIndex = 8;
            this.lbl_Replace.Text = "바꿀 내용(&P):";
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(119, 20);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(218, 21);
            this.txt_Find.TabIndex = 0;
            this.txt_Find.TextChanged += new System.EventHandler(this.Find_TextChanged);
            // 
            // txt_Replace
            // 
            this.txt_Replace.Location = new System.Drawing.Point(119, 52);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(218, 21);
            this.txt_Replace.TabIndex = 1;
            this.txt_Replace.TextChanged += new System.EventHandler(this.Find_TextChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Enabled = false;
            this.btn_Find.Location = new System.Drawing.Point(361, 19);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(95, 23);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "다음 찾기(&F)";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Location = new System.Drawing.Point(361, 48);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(95, 23);
            this.btn_Replace.TabIndex = 6;
            this.btn_Replace.Text = "바꾸기(&R)";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ReplaceAll.Location = new System.Drawing.Point(361, 77);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(95, 23);
            this.btn_ReplaceAll.TabIndex = 7;
            this.btn_ReplaceAll.Text = "모두 바꾸기(&A)";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(361, 106);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // chk_Case
            // 
            this.chk_Case.AutoSize = true;
            this.chk_Case.Location = new System.Drawing.Point(15, 107);
            this.chk_Case.Name = "chk_Case";
            this.chk_Case.Size = new System.Drawing.Size(125, 16);
            this.chk_Case.TabIndex = 2;
            this.chk_Case.Text = "대/소문자 구분(&C)";
            this.chk_Case.UseVisualStyleBackColor = true;
            // 
            // gb_Direction
            // 
            this.gb_Direction.Controls.Add(this.rdo_Down);
            this.gb_Direction.Controls.Add(this.rdo_Up);
            this.gb_Direction.Location = new System.Drawing.Point(146, 83);
            this.gb_Direction.Name = "gb_Direction";
            this.gb_Direction.Size = new System.Drawing.Size(191, 56);
            this.gb_Direction.TabIndex = 16;
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
            this.rdo_Down.TabIndex = 4;
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
            this.rdo_Up.TabIndex = 3;
            this.rdo_Up.Text = "위로(&U)";
            this.rdo_Up.UseVisualStyleBackColor = true;
            // 
            // 바꾸기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 152);
            this.Controls.Add(this.gb_Direction);
            this.Controls.Add(this.chk_Case);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ReplaceAll);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Replace);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.lbl_Find);
            this.MaximizeBox = false;
            this.Name = "바꾸기";
            this.Text = "바꾸기";
            this.Load += new System.EventHandler(this.바꾸기_Load);
            this.gb_Direction.ResumeLayout(false);
            this.gb_Direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Find;
        private System.Windows.Forms.Label lbl_Replace;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.TextBox txt_Replace;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox chk_Case;
        private System.Windows.Forms.GroupBox gb_Direction;
        private System.Windows.Forms.RadioButton rdo_Down;
        private System.Windows.Forms.RadioButton rdo_Up;
    }
}