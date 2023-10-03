namespace DDB.Calculator.UI
{
    partial class frmCalculator
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
            txtOutput = new TextBox();
            btnBack = new Button();
            btnClear = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAddition = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSQRT = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDecimal = new Button();
            btnChangeSign = new Button();
            btn0 = new Button();
            btnReciprocal = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 25);
            txtOutput.MaxLength = 32;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(199, 23);
            txtOutput.TabIndex = 0;
            txtOutput.Text = "0";
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(12, 67);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(76, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(94, 67);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 31);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(135, 104);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(35, 35);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(135, 145);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(35, 35);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(135, 186);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(35, 35);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAddition
            // 
            btnAddition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddition.ForeColor = Color.Red;
            btnAddition.Location = new Point(135, 227);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(35, 35);
            btnAddition.TabIndex = 6;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ActiveCaption;
            btn7.Location = new Point(12, 104);
            btn7.Name = "btn7";
            btn7.Size = new Size(35, 35);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ActiveCaption;
            btn8.Location = new Point(53, 104);
            btn8.Name = "btn8";
            btn8.Size = new Size(35, 35);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ActiveCaption;
            btn9.Location = new Point(94, 104);
            btn9.Name = "btn9";
            btn9.Size = new Size(35, 35);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnSQRT
            // 
            btnSQRT.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSQRT.ForeColor = SystemColors.ActiveCaption;
            btnSQRT.Location = new Point(176, 104);
            btnSQRT.Name = "btnSQRT";
            btnSQRT.Size = new Size(35, 35);
            btnSQRT.TabIndex = 10;
            btnSQRT.Text = "sqrt";
            btnSQRT.UseVisualStyleBackColor = true;
            btnSQRT.Click += btnSQRT_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ActiveCaption;
            btn6.Location = new Point(94, 145);
            btn6.Name = "btn6";
            btn6.Size = new Size(35, 35);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ActiveCaption;
            btn5.Location = new Point(53, 145);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 35);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ActiveCaption;
            btn4.Location = new Point(12, 145);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 35);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ActiveCaption;
            btn3.Location = new Point(94, 186);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 35);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ActiveCaption;
            btn2.Location = new Point(53, 186);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 35);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ActiveCaption;
            btn1.Location = new Point(12, 186);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 35);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.ForeColor = SystemColors.ActiveCaption;
            btnDecimal.Location = new Point(94, 227);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(35, 35);
            btnDecimal.TabIndex = 19;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeSign.ForeColor = SystemColors.ActiveCaption;
            btnChangeSign.Location = new Point(53, 227);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(35, 35);
            btnChangeSign.TabIndex = 18;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ActiveCaption;
            btn0.Location = new Point(12, 227);
            btn0.Name = "btn0";
            btn0.Size = new Size(35, 35);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReciprocal.ForeColor = SystemColors.ActiveCaption;
            btnReciprocal.Location = new Point(176, 145);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(35, 35);
            btnReciprocal.TabIndex = 20;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.ForeColor = Color.Red;
            btnEquals.Location = new Point(176, 188);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(35, 74);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // frmCalculator
            // 
            AcceptButton = btnEquals;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 274);
            Controls.Add(btnEquals);
            Controls.Add(btnReciprocal);
            Controls.Add(btnDecimal);
            Controls.Add(btnChangeSign);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSQRT);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnAddition);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(txtOutput);
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += frmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button btnBack;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAddition;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSQRT;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDecimal;
        private Button btnChangeSign;
        private Button btn0;
        private Button btnReciprocal;
        private Button btnEquals;
    }
}