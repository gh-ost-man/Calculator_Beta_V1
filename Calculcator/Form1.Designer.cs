namespace Calculcator
{
    partial class Calculator
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
            System.Windows.Forms.Button button1_Editing;
            System.Windows.Forms.Button button_total;
            System.Windows.Forms.Button button_sum;
            System.Windows.Forms.Button button_MC;
            System.Windows.Forms.Button button_diff;
            System.Windows.Forms.Button button_M;
            System.Windows.Forms.Button button_MR;
            System.Windows.Forms.Button button_multi;
            System.Windows.Forms.Button button_div;
            System.Windows.Forms.Button button_9;
            System.Windows.Forms.Button button_6;
            System.Windows.Forms.Button button_3;
            System.Windows.Forms.Button button_Mod;
            System.Windows.Forms.Button button_Zero;
            System.Windows.Forms.Button button_8;
            System.Windows.Forms.Button button_5;
            System.Windows.Forms.Button button_2;
            System.Windows.Forms.Button button_sum_and_diff;
            System.Windows.Forms.Button button_7;
            System.Windows.Forms.Button button_4;
            System.Windows.Forms.Button button_1;
            this.groupBox_Editing = new System.Windows.Forms.GroupBox();
            this.button_Backspace = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button2_Editing = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Expression = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_Expression = new System.Windows.Forms.Label();
            button1_Editing = new System.Windows.Forms.Button();
            button_total = new System.Windows.Forms.Button();
            button_sum = new System.Windows.Forms.Button();
            button_MC = new System.Windows.Forms.Button();
            button_diff = new System.Windows.Forms.Button();
            button_M = new System.Windows.Forms.Button();
            button_MR = new System.Windows.Forms.Button();
            button_multi = new System.Windows.Forms.Button();
            button_div = new System.Windows.Forms.Button();
            button_9 = new System.Windows.Forms.Button();
            button_6 = new System.Windows.Forms.Button();
            button_3 = new System.Windows.Forms.Button();
            button_Mod = new System.Windows.Forms.Button();
            button_Zero = new System.Windows.Forms.Button();
            button_8 = new System.Windows.Forms.Button();
            button_5 = new System.Windows.Forms.Button();
            button_2 = new System.Windows.Forms.Button();
            button_sum_and_diff = new System.Windows.Forms.Button();
            button_7 = new System.Windows.Forms.Button();
            button_4 = new System.Windows.Forms.Button();
            button_1 = new System.Windows.Forms.Button();
            this.groupBox_Editing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Editing
            // 
            this.groupBox_Editing.Controls.Add(this.button_Backspace);
            this.groupBox_Editing.Controls.Add(this.button_C);
            this.groupBox_Editing.Controls.Add(this.button2_Editing);
            this.groupBox_Editing.Controls.Add(button1_Editing);
            this.groupBox_Editing.Location = new System.Drawing.Point(12, 61);
            this.groupBox_Editing.Name = "groupBox_Editing";
            this.groupBox_Editing.Size = new System.Drawing.Size(271, 70);
            this.groupBox_Editing.TabIndex = 27;
            this.groupBox_Editing.TabStop = false;
            this.groupBox_Editing.Text = "Editing";
            // 
            // button_Backspace
            // 
            this.button_Backspace.ForeColor = System.Drawing.Color.Red;
            this.button_Backspace.Location = new System.Drawing.Point(102, 29);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(102, 26);
            this.button_Backspace.TabIndex = 0;
            this.button_Backspace.Text = "Backspace";
            this.button_Backspace.UseVisualStyleBackColor = true;
            this.button_Backspace.Click += new System.EventHandler(this.button_Backspace_Click);
            // 
            // button_C
            // 
            this.button_C.ForeColor = System.Drawing.Color.Red;
            this.button_C.Location = new System.Drawing.Point(210, 24);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(52, 37);
            this.button_C.TabIndex = 0;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button2_Editing
            // 
            this.button2_Editing.Location = new System.Drawing.Point(53, 24);
            this.button2_Editing.Name = "button2_Editing";
            this.button2_Editing.Size = new System.Drawing.Size(41, 37);
            this.button2_Editing.TabIndex = 0;
            this.button2_Editing.Text = ")";
            this.button2_Editing.UseVisualStyleBackColor = true;
            this.button2_Editing.Click += new System.EventHandler(this.button2_Editing_Click);
            // 
            // button1_Editing
            // 
            button1_Editing.Location = new System.Drawing.Point(6, 24);
            button1_Editing.Name = "button1_Editing";
            button1_Editing.Size = new System.Drawing.Size(41, 37);
            button1_Editing.TabIndex = 0;
            button1_Editing.Text = "(";
            button1_Editing.UseVisualStyleBackColor = true;
            button1_Editing.Click += new System.EventHandler(this.button1_Editing_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(100, 40);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(164, 20);
            this.textBox_Result.TabIndex = 26;
            // 
            // textBox_Expression
            // 
            this.textBox_Expression.Location = new System.Drawing.Point(100, 12);
            this.textBox_Expression.Name = "textBox_Expression";
            this.textBox_Expression.ReadOnly = true;
            this.textBox_Expression.Size = new System.Drawing.Size(164, 20);
            this.textBox_Expression.TabIndex = 25;
            // 
            // button_total
            // 
            button_total.ForeColor = System.Drawing.Color.Red;
            button_total.Location = new System.Drawing.Point(233, 268);
            button_total.Name = "button_total";
            button_total.Size = new System.Drawing.Size(41, 37);
            button_total.TabIndex = 23;
            button_total.Text = "=";
            button_total.UseVisualStyleBackColor = true;
            button_total.Click += new System.EventHandler(this.button_total_Click);
            // 
            // button_sum
            // 
            button_sum.ForeColor = System.Drawing.Color.Red;
            button_sum.Location = new System.Drawing.Point(161, 268);
            button_sum.Name = "button_sum";
            button_sum.Size = new System.Drawing.Size(41, 37);
            button_sum.TabIndex = 22;
            button_sum.Text = "+";
            button_sum.UseVisualStyleBackColor = true;
            button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_MC
            // 
            button_MC.ForeColor = System.Drawing.Color.Blue;
            button_MC.Location = new System.Drawing.Point(233, 225);
            button_MC.Name = "button_MC";
            button_MC.Size = new System.Drawing.Size(41, 37);
            button_MC.TabIndex = 21;
            button_MC.Text = "MC";
            button_MC.UseVisualStyleBackColor = true;
            // 
            // button_diff
            // 
            button_diff.ForeColor = System.Drawing.Color.Red;
            button_diff.Location = new System.Drawing.Point(161, 225);
            button_diff.Name = "button_diff";
            button_diff.Size = new System.Drawing.Size(41, 37);
            button_diff.TabIndex = 20;
            button_diff.Text = "-";
            button_diff.UseVisualStyleBackColor = true;
            button_diff.Click += new System.EventHandler(this.button_diff_Click);
            // 
            // button_M
            // 
            button_M.ForeColor = System.Drawing.Color.Blue;
            button_M.Location = new System.Drawing.Point(233, 182);
            button_M.Name = "button_M";
            button_M.Size = new System.Drawing.Size(41, 37);
            button_M.TabIndex = 19;
            button_M.Text = "M+";
            button_M.UseVisualStyleBackColor = true;
            // 
            // button_MR
            // 
            button_MR.ForeColor = System.Drawing.Color.Blue;
            button_MR.Location = new System.Drawing.Point(233, 139);
            button_MR.Name = "button_MR";
            button_MR.Size = new System.Drawing.Size(41, 37);
            button_MR.TabIndex = 18;
            button_MR.Text = "MR";
            button_MR.UseVisualStyleBackColor = true;
            // 
            // button_multi
            // 
            button_multi.ForeColor = System.Drawing.Color.Red;
            button_multi.Location = new System.Drawing.Point(161, 182);
            button_multi.Name = "button_multi";
            button_multi.Size = new System.Drawing.Size(41, 37);
            button_multi.TabIndex = 17;
            button_multi.Text = "*";
            button_multi.UseVisualStyleBackColor = true;
            button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // button_div
            // 
            button_div.ForeColor = System.Drawing.Color.Red;
            button_div.Location = new System.Drawing.Point(161, 139);
            button_div.Name = "button_div";
            button_div.Size = new System.Drawing.Size(41, 37);
            button_div.TabIndex = 16;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_9
            // 
            button_9.Location = new System.Drawing.Point(114, 225);
            button_9.Name = "button_9";
            button_9.Size = new System.Drawing.Size(41, 37);
            button_9.TabIndex = 24;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_6
            // 
            button_6.Location = new System.Drawing.Point(114, 182);
            button_6.Name = "button_6";
            button_6.Size = new System.Drawing.Size(41, 37);
            button_6.TabIndex = 3;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_3
            // 
            button_3.Location = new System.Drawing.Point(114, 139);
            button_3.Name = "button_3";
            button_3.Size = new System.Drawing.Size(41, 37);
            button_3.TabIndex = 13;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_Mod
            // 
            button_Mod.ForeColor = System.Drawing.Color.Red;
            button_Mod.Location = new System.Drawing.Point(114, 268);
            button_Mod.Name = "button_Mod";
            button_Mod.Size = new System.Drawing.Size(41, 37);
            button_Mod.TabIndex = 12;
            button_Mod.Text = "Mod";
            button_Mod.UseVisualStyleBackColor = true;
            // 
            // button_Zero
            // 
            button_Zero.Location = new System.Drawing.Point(65, 268);
            button_Zero.Name = "button_Zero";
            button_Zero.Size = new System.Drawing.Size(41, 37);
            button_Zero.TabIndex = 11;
            button_Zero.Text = "0";
            button_Zero.UseVisualStyleBackColor = true;
            button_Zero.Click += new System.EventHandler(this.button_Zero_Click);
            // 
            // button_8
            // 
            button_8.Location = new System.Drawing.Point(65, 225);
            button_8.Name = "button_8";
            button_8.Size = new System.Drawing.Size(41, 37);
            button_8.TabIndex = 10;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_5
            // 
            button_5.Location = new System.Drawing.Point(65, 182);
            button_5.Name = "button_5";
            button_5.Size = new System.Drawing.Size(41, 37);
            button_5.TabIndex = 9;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_2
            // 
            button_2.Location = new System.Drawing.Point(65, 139);
            button_2.Name = "button_2";
            button_2.Size = new System.Drawing.Size(41, 37);
            button_2.TabIndex = 8;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_sum_and_diff
            // 
            button_sum_and_diff.Location = new System.Drawing.Point(18, 268);
            button_sum_and_diff.Name = "button_sum_and_diff";
            button_sum_and_diff.Size = new System.Drawing.Size(41, 37);
            button_sum_and_diff.TabIndex = 7;
            button_sum_and_diff.Text = "+/-";
            button_sum_and_diff.UseVisualStyleBackColor = true;
            // 
            // button_7
            // 
            button_7.Location = new System.Drawing.Point(18, 225);
            button_7.Name = "button_7";
            button_7.Size = new System.Drawing.Size(41, 37);
            button_7.TabIndex = 6;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_4
            // 
            button_4.Location = new System.Drawing.Point(18, 182);
            button_4.Name = "button_4";
            button_4.Size = new System.Drawing.Size(41, 37);
            button_4.TabIndex = 5;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_1
            // 
            button_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button_1.Location = new System.Drawing.Point(18, 139);
            button_1.Name = "button_1";
            button_1.Size = new System.Drawing.Size(41, 37);
            button_1.TabIndex = 4;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // groupBox_Editing
            // 
            this.groupBox_Editing.Controls.Add(this.button_Backspace);
            this.groupBox_Editing.Controls.Add(this.button_C);
            this.groupBox_Editing.Controls.Add(this.button2_Editing);
            this.groupBox_Editing.Controls.Add(button1_Editing);
            this.groupBox_Editing.Location = new System.Drawing.Point(12, 61);
            this.groupBox_Editing.Name = "groupBox_Editing";
            this.groupBox_Editing.Size = new System.Drawing.Size(271, 70);
            this.groupBox_Editing.TabIndex = 27;
            this.groupBox_Editing.TabStop = false;
            this.groupBox_Editing.Text = "Editing";
            // 
            // button_Backspace
            // 
            this.button_Backspace.ForeColor = System.Drawing.Color.Red;
            this.button_Backspace.Location = new System.Drawing.Point(102, 29);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(102, 26);
            this.button_Backspace.TabIndex = 0;
            this.button_Backspace.Text = "Backspace";
            this.button_Backspace.UseVisualStyleBackColor = true;
            // 
            // button_C
            // 
            this.button_C.ForeColor = System.Drawing.Color.Red;
            this.button_C.Location = new System.Drawing.Point(210, 24);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(52, 37);
            this.button_C.TabIndex = 0;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            // 
            // button2_Editing
            // 
            this.button2_Editing.Location = new System.Drawing.Point(53, 24);
            this.button2_Editing.Name = "button2_Editing";
            this.button2_Editing.Size = new System.Drawing.Size(41, 37);
            this.button2_Editing.TabIndex = 0;
            this.button2_Editing.Text = ")";
            this.button2_Editing.UseVisualStyleBackColor = true;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(86, 35);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(188, 20);
            this.textBox_Result.TabIndex = 26;
            // 
            // textBox_Expression
            // 
            this.textBox_Expression.Location = new System.Drawing.Point(86, 7);
            this.textBox_Expression.Name = "textBox_Expression";
            this.textBox_Expression.Size = new System.Drawing.Size(188, 20);
            this.textBox_Expression.TabIndex = 25;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(36, 43);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(37, 13);
            this.label_Result.TabIndex = 14;
            this.label_Result.Text = "Result";
            // 
            // label_Expression
            // 
            this.label_Expression.AutoSize = true;
            this.label_Expression.Location = new System.Drawing.Point(36, 15);
            this.label_Expression.Name = "label_Expression";
            this.label_Expression.Size = new System.Drawing.Size(58, 13);
            this.label_Expression.TabIndex = 15;
            this.label_Expression.Text = "Expression";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(296, 315);
            this.Controls.Add(this.groupBox_Editing);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Expression);
            this.Controls.Add(button_total);
            this.Controls.Add(button_sum);
            this.Controls.Add(button_MC);
            this.Controls.Add(button_diff);
            this.Controls.Add(button_M);
            this.Controls.Add(button_MR);
            this.Controls.Add(button_multi);
            this.Controls.Add(button_div);
            this.Controls.Add(button_9);
            this.Controls.Add(button_6);
            this.Controls.Add(button_3);
            this.Controls.Add(button_Mod);
            this.Controls.Add(button_Zero);
            this.Controls.Add(button_8);
            this.Controls.Add(button_5);
            this.Controls.Add(button_2);
            this.Controls.Add(button_sum_and_diff);
            this.Controls.Add(button_7);
            this.Controls.Add(button_4);
            this.Controls.Add(button_1);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Expression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox_Editing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Editing;
        private System.Windows.Forms.Button button_Backspace;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button2_Editing;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Expression;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_Expression;
    }
}

