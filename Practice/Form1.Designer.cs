
namespace Practice
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SEE = new System.Windows.Forms.ToolStripMenuItem();
            this.WRITE = new System.Windows.Forms.ToolStripMenuItem();
            this.HELP = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.RED = new System.Windows.Forms.Button();
            this.MUL = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.SPOT = new System.Windows.Forms.Button();
            this.EQUAL = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SEE,
            this.WRITE,
            this.HELP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SEE
            // 
            this.SEE.Name = "SEE";
            this.SEE.Size = new System.Drawing.Size(73, 24);
            this.SEE.Text = "查看(V)";
            // 
            // WRITE
            // 
            this.WRITE.Name = "WRITE";
            this.WRITE.Size = new System.Drawing.Size(71, 24);
            this.WRITE.Text = "编辑(E)";
            // 
            // HELP
            // 
            this.HELP.Name = "HELP";
            this.HELP.Size = new System.Drawing.Size(75, 24);
            this.HELP.Text = "帮助(H)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 83);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 29);
            this.Back.TabIndex = 2;
            this.Back.Text = "后退一个";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(140, 82);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(94, 29);
            this.CE.TabIndex = 3;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.button2_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(264, 82);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(94, 29);
            this.C.TabIndex = 4;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Number7
            // 
            this.Number7.Location = new System.Drawing.Point(13, 133);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(94, 29);
            this.Number7.TabIndex = 5;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number8
            // 
            this.Number8.Location = new System.Drawing.Point(140, 133);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(94, 29);
            this.Number8.TabIndex = 6;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number9
            // 
            this.Number9.Location = new System.Drawing.Point(264, 132);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(94, 29);
            this.Number9.TabIndex = 7;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(13, 186);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(94, 29);
            this.Number4.TabIndex = 8;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(140, 186);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(94, 29);
            this.Number5.TabIndex = 9;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(264, 186);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(94, 29);
            this.Number6.TabIndex = 10;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(13, 237);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(94, 29);
            this.Number1.TabIndex = 11;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(140, 237);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(94, 29);
            this.Number2.TabIndex = 12;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(264, 237);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(94, 29);
            this.Number3.TabIndex = 13;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.button12_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(381, 83);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(94, 29);
            this.ADD.TabIndex = 14;
            this.ADD.Text = "+";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // RED
            // 
            this.RED.Location = new System.Drawing.Point(381, 133);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(94, 29);
            this.RED.TabIndex = 15;
            this.RED.Text = "-";
            this.RED.UseVisualStyleBackColor = true;
            this.RED.Click += new System.EventHandler(this.RED_Click);
            // 
            // MUL
            // 
            this.MUL.Location = new System.Drawing.Point(381, 186);
            this.MUL.Name = "MUL";
            this.MUL.Size = new System.Drawing.Size(94, 29);
            this.MUL.TabIndex = 16;
            this.MUL.Text = "*";
            this.MUL.UseVisualStyleBackColor = true;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // DIV
            // 
            this.DIV.Location = new System.Drawing.Point(381, 237);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(94, 29);
            this.DIV.TabIndex = 17;
            this.DIV.Text = "/";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(14, 280);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(94, 29);
            this.Number0.TabIndex = 18;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // SPOT
            // 
            this.SPOT.Location = new System.Drawing.Point(140, 280);
            this.SPOT.Name = "SPOT";
            this.SPOT.Size = new System.Drawing.Size(94, 29);
            this.SPOT.TabIndex = 19;
            this.SPOT.Text = ".";
            this.SPOT.UseVisualStyleBackColor = true;
            this.SPOT.Click += new System.EventHandler(this.SPOT_Click);
            // 
            // EQUAL
            // 
            this.EQUAL.Location = new System.Drawing.Point(264, 280);
            this.EQUAL.Name = "EQUAL";
            this.EQUAL.Size = new System.Drawing.Size(211, 29);
            this.EQUAL.TabIndex = 20;
            this.EQUAL.Text = "=";
            this.EQUAL.UseVisualStyleBackColor = true;
            this.EQUAL.Click += new System.EventHandler(this.EQUAL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 358);
            this.Controls.Add(this.EQUAL);
            this.Controls.Add(this.SPOT);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.MUL);
            this.Controls.Add(this.RED);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "计算器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SEE;
        private System.Windows.Forms.ToolStripMenuItem WRITE;
        private System.Windows.Forms.ToolStripMenuItem HELP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button RED;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button SPOT;
        private System.Windows.Forms.Button EQUAL;
    }
}

