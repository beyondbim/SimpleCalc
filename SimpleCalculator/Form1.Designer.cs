namespace SimpleCalculator
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.RichTextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 52);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDisplay.Size = new System.Drawing.Size(473, 31);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "0";
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCE.Location = new System.Drawing.Point(12, 110);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCE.Size = new System.Drawing.Size(80, 39);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.b_click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonC.Location = new System.Drawing.Point(135, 110);
            this.buttonC.Name = "buttonC";
            this.buttonC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonC.Size = new System.Drawing.Size(80, 39);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.b_click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDel.Location = new System.Drawing.Point(265, 110);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDel.Size = new System.Drawing.Size(80, 39);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "DEL";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.b_click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDivide.Location = new System.Drawing.Point(405, 110);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDivide.Size = new System.Drawing.Size(80, 39);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.b_click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonMultiply.Location = new System.Drawing.Point(407, 161);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMultiply.Size = new System.Drawing.Size(80, 39);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.b_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(267, 161);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(80, 39);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.b_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(137, 161);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(80, 39);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.b_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(14, 161);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(80, 39);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.b_click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSub.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSub.Location = new System.Drawing.Point(405, 216);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSub.Size = new System.Drawing.Size(80, 39);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.b_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(265, 216);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(80, 39);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.b_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(135, 216);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(80, 39);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.b_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(12, 216);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(80, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.b_click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEqual.Location = new System.Drawing.Point(405, 323);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEqual.Size = new System.Drawing.Size(80, 39);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.b_click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDecimal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDecimal.Location = new System.Drawing.Point(265, 323);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(80, 39);
            this.buttonDecimal.TabIndex = 19;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = false;
            this.buttonDecimal.Click += new System.EventHandler(this.b_click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button0.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button0.Location = new System.Drawing.Point(135, 323);
            this.button0.Name = "button0";
            this.button0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button0.Size = new System.Drawing.Size(80, 39);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.b_click);
            // 
            // buttonSign
            // 
            this.buttonSign.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSign.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSign.Location = new System.Drawing.Point(12, 323);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSign.Size = new System.Drawing.Size(80, 39);
            this.buttonSign.TabIndex = 17;
            this.buttonSign.Text = "+_";
            this.buttonSign.UseVisualStyleBackColor = false;
            this.buttonSign.Click += new System.EventHandler(this.b_click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAdd.Location = new System.Drawing.Point(405, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdd.Size = new System.Drawing.Size(80, 39);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.b_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(265, 268);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(80, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.b_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(135, 268);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(80, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.b_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 268);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.b_click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ControlDark;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(267, 16);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(218, 22);
            this.history.TabIndex = 21;
            this.history.Text = "";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.Location = new System.Drawing.Point(203, 16);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(58, 20);
            this.labelHistory.TabIndex = 22;
            this.labelHistory.Text = "History";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 397);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.history);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.textBoxDisplay);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.Label labelHistory;
    }
}

