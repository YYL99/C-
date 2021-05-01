
namespace WinFormsApp1
{
    partial class List
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.lstBottom = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRigthAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 20;
            this.lstLeft.Items.AddRange(new object[] {
            "星期日",
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五",
            "星期六"});
            this.lstLeft.Location = new System.Drawing.Point(12, 21);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(150, 164);
            this.lstLeft.TabIndex = 0;
            this.lstLeft.SelectedIndexChanged += new System.EventHandler(this.lstLeft_SelectedIndexChanged);
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 20;
            this.lstRight.Location = new System.Drawing.Point(291, 21);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(150, 164);
            this.lstRight.TabIndex = 1;
            this.lstRight.SelectedIndexChanged += new System.EventHandler(this.lstRight_SelectedIndexChanged);
            // 
            // lstBottom
            // 
            this.lstBottom.FormattingEnabled = true;
            this.lstBottom.ItemHeight = 20;
            this.lstBottom.Location = new System.Drawing.Point(12, 217);
            this.lstBottom.Name = "lstBottom";
            this.lstBottom.Size = new System.Drawing.Size(429, 124);
            this.lstBottom.TabIndex = 2;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(201, 24);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(49, 31);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRigthAll
            // 
            this.btnRigthAll.Location = new System.Drawing.Point(201, 63);
            this.btnRigthAll.Name = "btnRigthAll";
            this.btnRigthAll.Size = new System.Drawing.Size(49, 31);
            this.btnRigthAll.TabIndex = 4;
            this.btnRigthAll.Text = ">>";
            this.btnRigthAll.UseVisualStyleBackColor = true;
            this.btnRigthAll.Click += new System.EventHandler(this.btnRigthAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(201, 101);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(49, 31);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Location = new System.Drawing.Point(201, 139);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(49, 31);
            this.btnLeftAll.TabIndex = 6;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 371);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRigthAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lstBottom);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.ListBox lstBottom;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRigthAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
    }
}