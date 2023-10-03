using DDB.Calculator.BL.Models;


namespace DDB.Calculator.UI
{
    public partial class frmCalculator : Form
    {
        Calc calc;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            calc = new Calc();
        }
        // Function to print numbers to the screen when a button is pressed.
        // Only enters an aditional digit if less than max length of the text box
        // Starts over if calc.NextOperand is true, NextOperand=true says its ready to type the next operand
        public void OutputButton(string buttonValue)
        {
            if (calc.NextOperand)
            {
                calc.NextOperand = false;
                txtOutput.Text = buttonValue;
            }
            else
            {
                if (txtOutput.Text.Length < txtOutput.MaxLength)
                {
                    txtOutput.Text += buttonValue;
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Reset();
            txtOutput.Text = calc.Operand1.ToString();
        }

        //Changes Sign of the value. Does not put '-' if 0.
        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            string value = txtOutput.Text;
            if (value.ElementAt(0).ToString() == "-")
            {
                MessageBox.Show("== -");
                value = value.Substring(1);
            }
            else if (value != "0")
            {
                value = value.Insert(0, "-");
            }
            txtOutput.Text = value;
        }

        //Square root the value on the screen.
        //Resets the Calculator with Operand1 as the SQRT value. Operand2=0, MathOperator = "";
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            double value;
            try
            {
                if (double.TryParse(txtOutput.Text, out value))
                {
                    value = Math.Sqrt(value);
                    calc.Operand1 = value;
                    calc.Operand2 = 0;
                    calc.MathOperator = string.Empty;
                    txtOutput.Text = value.ToString();
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
        }


        //Reciprocal Function.
        //Resets the Calculator with Operand1 as the SQRT value. Operand2=0, MathOperator = "";
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double value;
            try
            {
                if (double.TryParse(txtOutput.Text, out value))
                {
                    if (value != 0)
                    {
                        value = 1.0 / value;
                        calc.Operand1 = value;
                        calc.Operand2 = 0;
                        calc.MathOperator = string.Empty;
                        calc.NextOperand = true;
                        txtOutput.Text = value.ToString();
                    }
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
        }

        // Removes the last digit. If all digits removed, output.Text = "0" and reset nextOperand to true;
        private void btnBack_Click(object sender, EventArgs e)
        {
            string value = txtOutput.Text;
            value = value.Substring(0, value.Length - 1);
            if (value == string.Empty)
            {
                txtOutput.Text = "0";
                calc.NextOperand = true;
            }
            else
            {
                txtOutput.Text = value;
            }
        }


        // Add. In scenarior : "1+2+3+4+5..." it will calculate the answers without pushing = button.
        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                // NextOperand == False means digits were inputed. Scenario: "1 + 2 + " is the sequence of buttons pressed.
                if (calc.Operand1_Set && calc.NextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.MathOperator = "+";
                }
                // NextOperand == true means No Digits were inputed. Scenario: "1 -+"
                else if (calc.NextOperand == true)
                {
                    calc.MathOperator = "+";
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.MathOperator = "+";
                    calc.NextOperand = true;
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                // NextOperand == False means digits were inputed. Scenario: "1 - 2 - " is the sequence of buttons pressed.
                if (calc.Operand1_Set && calc.NextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.MathOperator = "-";
                }
                // NextOperand == true means No Digits were inputed. Scenario: "1 +-"
                else if (calc.NextOperand == true)
                {
                    calc.MathOperator = "-";
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.MathOperator = "-";
                    calc.NextOperand = true;
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                // NextOperand == False means digits were inputed. Scenario: "1 * 2 * " is the sequence of buttons pressed.
                if (calc.Operand1_Set && calc.NextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.MathOperator = "*";
                }
                // NextOperand == true means No Digits were inputed. Scenario: "1 +*"
                else if (calc.NextOperand == true)
                {
                    calc.MathOperator = "*";
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.MathOperator = "*";
                    calc.NextOperand = true;
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                // NextOperand == False means digits were inputed. Scenario: "10 / 2 / 2 / " is the sequence of buttons pressed.
                if (calc.Operand1_Set && calc.NextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.MathOperator = "/";
                }
                // NextOperand == true means No Digits were inputed. Scenario: "1 +/"
                else if (calc.NextOperand == true)
                {
                    calc.MathOperator = "/";
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.MathOperator = "/";
                    calc.NextOperand = true;
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if(calc.Operand2_Set == false && calc.NextOperand == true)// scenarior "1+=" we want it to calculate 1+1=2
                {
                    calc.SetOperand(2, txtOutput.Text);
                }
                if(calc.NextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                }
                
                txtOutput.Text = calc.Calculate();
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
            }
                
            
            
        }

        // numeric and '.' buttons just call OutputButton() function;
        #region "Numeric Buttons"
        private void btn1_Click(object sender, EventArgs e)
        {
            OutputButton("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OutputButton("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OutputButton("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OutputButton("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OutputButton("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OutputButton("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OutputButton("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OutputButton("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OutputButton("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            OutputButton("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            OutputButton(".");
        }

        #endregion



    }
}