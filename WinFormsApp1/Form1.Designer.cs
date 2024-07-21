namespace WinFormsApp1
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
            label1 = new Label();
            tb_Result = new TextBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button18 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button25 = new Button();
            button29 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button36 = new Button();
            lb_Result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // tb_Result
            // 
            tb_Result.Font = new Font("Segoe UI", 23F);
            tb_Result.Location = new Point(34, 73);
            tb_Result.Multiline = true;
            tb_Result.Name = "tb_Result";
            tb_Result.Size = new Size(235, 50);
            tb_Result.TabIndex = 1;
            tb_Result.Text = "0";
            tb_Result.TextAlign = HorizontalAlignment.Right;
            tb_Result.Click += textBox1_Click;
            tb_Result.TextChanged += textBox1_TextChanged;
            // 
            // button8
            // 
            button8.Location = new Point(78, 185);
            button8.Name = "button8";
            button8.Size = new Size(38, 33);
            button8.TabIndex = 2;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button22_Click;
            // 
            // button9
            // 
            button9.Location = new Point(122, 185);
            button9.Name = "button9";
            button9.Size = new Size(38, 33);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button22_Click;
            // 
            // button10
            // 
            button10.Location = new Point(78, 224);
            button10.Name = "button10";
            button10.Size = new Size(38, 33);
            button10.TabIndex = 2;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button22_Click;
            // 
            // button11
            // 
            button11.Location = new Point(166, 185);
            button11.Name = "button11";
            button11.Size = new Size(38, 33);
            button11.TabIndex = 2;
            button11.Text = "/";
            button11.UseVisualStyleBackColor = true;
            button11.Click += operation_Perform;
            // 
            // button12
            // 
            button12.Location = new Point(122, 224);
            button12.Name = "button12";
            button12.Size = new Size(38, 33);
            button12.TabIndex = 2;
            button12.Text = "6";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button22_Click;
            // 
            // button13
            // 
            button13.Location = new Point(78, 263);
            button13.Name = "button13";
            button13.Size = new Size(38, 33);
            button13.TabIndex = 2;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button22_Click;
            // 
            // button18
            // 
            button18.Location = new Point(34, 185);
            button18.Name = "button18";
            button18.Size = new Size(38, 33);
            button18.TabIndex = 2;
            button18.Text = "7";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button22_Click;
            // 
            // button20
            // 
            button20.Location = new Point(122, 263);
            button20.Name = "button20";
            button20.Size = new Size(38, 33);
            button20.TabIndex = 2;
            button20.Text = "3";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button22_Click;
            // 
            // button21
            // 
            button21.Location = new Point(219, 185);
            button21.Name = "button21";
            button21.Size = new Size(50, 33);
            button21.TabIndex = 2;
            button21.Text = "CE";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.Location = new Point(34, 302);
            button22.Name = "button22";
            button22.Size = new Size(82, 33);
            button22.TabIndex = 2;
            button22.Text = "0";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Location = new Point(34, 224);
            button23.Name = "button23";
            button23.Size = new Size(38, 33);
            button23.TabIndex = 2;
            button23.Text = "4";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button22_Click;
            // 
            // button25
            // 
            button25.Location = new Point(34, 263);
            button25.Name = "button25";
            button25.Size = new Size(38, 33);
            button25.TabIndex = 2;
            button25.Text = "1";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button22_Click;
            // 
            // button29
            // 
            button29.Location = new Point(219, 224);
            button29.Name = "button29";
            button29.Size = new Size(50, 33);
            button29.TabIndex = 2;
            button29.Text = "C";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button29_Click;
            // 
            // button31
            // 
            button31.Location = new Point(122, 302);
            button31.Name = "button31";
            button31.Size = new Size(38, 33);
            button31.TabIndex = 2;
            button31.Text = ".";
            button31.UseVisualStyleBackColor = true;
            button31.Click += button22_Click;
            // 
            // button32
            // 
            button32.Location = new Point(166, 224);
            button32.Name = "button32";
            button32.Size = new Size(38, 33);
            button32.TabIndex = 2;
            button32.Text = "*";
            button32.UseVisualStyleBackColor = true;
            button32.Click += operation_Perform;
            // 
            // button33
            // 
            button33.Location = new Point(219, 263);
            button33.Name = "button33";
            button33.Size = new Size(50, 72);
            button33.TabIndex = 2;
            button33.Text = "=";
            button33.UseVisualStyleBackColor = true;
            button33.Click += button33_Click;
            // 
            // button34
            // 
            button34.Location = new Point(166, 302);
            button34.Name = "button34";
            button34.Size = new Size(38, 33);
            button34.TabIndex = 2;
            button34.Text = "+";
            button34.UseVisualStyleBackColor = true;
            button34.Click += operation_Perform;
            // 
            // button36
            // 
            button36.Location = new Point(166, 263);
            button36.Name = "button36";
            button36.Size = new Size(38, 33);
            button36.TabIndex = 2;
            button36.Text = "-";
            button36.UseVisualStyleBackColor = true;
            button36.Click += operation_Perform;
            // 
            // lb_Result
            // 
            lb_Result.AutoSize = true;
            lb_Result.Location = new Point(40, 22);
            lb_Result.Name = "lb_Result";
            lb_Result.Size = new Size(0, 15);
            lb_Result.TabIndex = 3;
            lb_Result.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 450);
            Controls.Add(lb_Result);
            Controls.Add(button22);
            Controls.Add(button13);
            Controls.Add(button33);
            Controls.Add(button29);
            Controls.Add(button21);
            Controls.Add(button10);
            Controls.Add(button20);
            Controls.Add(button8);
            Controls.Add(button34);
            Controls.Add(button36);
            Controls.Add(button32);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button31);
            Controls.Add(button9);
            Controls.Add(button25);
            Controls.Add(button23);
            Controls.Add(button18);
            Controls.Add(tb_Result);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(50, 50);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Result;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button18;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button25;
        private Button button29;
        private Button button31;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button36;
        private Label lb_Result;
    }
}
