namespace Calculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.foreToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightBlueToolStripMenuItem,
            this.lightGrayToolStripMenuItem});
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.backColorToolStripMenuItem.Text = "Back Color";
            // 
            // lightBlueToolStripMenuItem
            // 
            this.lightBlueToolStripMenuItem.CheckOnClick = true;
            this.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
            this.lightBlueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lightBlueToolStripMenuItem.Text = "Light Blue";
            this.lightBlueToolStripMenuItem.CheckedChanged += new System.EventHandler(this.lightBlueToolStripMenuItem_CheckedChanged);
            // 
            // lightGrayToolStripMenuItem
            // 
            this.lightGrayToolStripMenuItem.CheckOnClick = true;
            this.lightGrayToolStripMenuItem.Name = "lightGrayToolStripMenuItem";
            this.lightGrayToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lightGrayToolStripMenuItem.Text = "Light Gray";
            this.lightGrayToolStripMenuItem.CheckedChanged += new System.EventHandler(this.lightGrayToolStripMenuItem_CheckedChanged);
            // 
            // foreToolStripMenuItem
            // 
            this.foreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.foreToolStripMenuItem.Name = "foreToolStripMenuItem";
            this.foreToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.foreToolStripMenuItem.Text = "Fore Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.CheckOnClick = true;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.CheckedChanged += new System.EventHandler(this.redToolStripMenuItem_CheckedChanged);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.CheckOnClick = true;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.greenToolStripMenuItem_CheckedChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem1.Text = "Back Color";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Light Blue";
            this.toolStripMenuItem2.CheckedChanged += new System.EventHandler(this.lightBlueToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem3.Text = "Light Gray";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.lightGrayToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem4.Text = "Fore Color";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem5.Text = "Red";
            this.toolStripMenuItem5.CheckedChanged += new System.EventHandler(this.redToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem6.Text = "Green";
            this.toolStripMenuItem6.CheckedChanged += new System.EventHandler(this.greenToolStripMenuItem_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 53);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btndot);
            this.groupBox1.Controls.Add(this.btnplus);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btneq);
            this.groupBox1.Controls.Add(this.btnminus);
            this.groupBox1.Controls.Add(this.btnmul);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btndiv);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 186);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(47, 40);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn0_MouseClick);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(58, 186);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(47, 40);
            this.btndot.TabIndex = 16;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btndot_MouseClick);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(104, 186);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(47, 40);
            this.btnplus.TabIndex = 15;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnpl_MouseClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 94);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 40);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(58, 94);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 40);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(104, 140);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 40);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(58, 140);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 40);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 140);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 40);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(104, 94);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 40);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(58, 48);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 40);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn8_MouseClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(104, 48);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 40);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseClick);
            // 
            // btneq
            // 
            this.btneq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneq.Location = new System.Drawing.Point(157, 106);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(75, 120);
            this.btneq.TabIndex = 6;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = true;
            this.btneq.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btneq_MouseClick);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(157, 48);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 23);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(157, 77);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 4;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 48);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 40);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(157, 19);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(76, 19);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(12, 19);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(58, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "<--";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 337);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnplus;
    }
}

