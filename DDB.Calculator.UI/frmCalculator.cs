using DDB.Calculator.BL.Models;
using System.Configuration;


/*
 *      Dean Bartel
 *      2 Oct 2023
 *      C# Intermediate
 *      Project #3 - Calculator
 *      V2 - Added more properties to Calculator class
 *           Uses more bools to determine if properties are set.
 *           This helps with displaying proper Equation formats.
 *           Helps with situations "1+2+3+-*5= / 3"
 * 
 */

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

        //Functions: OutPutButton(), GetEquation(), Clear, change sign, back
        #region "Non Calculation Functions"
        // Function to print numbers to the screen when a button is pressed.
        // Only enters an aditional digit if less than max length of the text box
        // Starts over if calc.boolNextOperand is true, boolNextOperand=true says its ready to type the next operand
        public void OutputButton(string buttonValue)
        {
            // Scenarior. User hit = this set boolOperator_Set to false but not clear strMathOperator
            // After = the user hits a number which needs to triger starting a new equation. So need to reset calculator
            if( !calc.boolOperator_Set && calc.boolIsAnswered)
            {
                calc.Reset();
                txtEquation.Text = "";
            }
            if (calc.boolNextOperand)
            {
                calc.boolNextOperand = false;
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

        public string GetEquation()
        {
            if(calc.boolIsAnswered && calc.boolOperator_Set && calc.boolOperand2_Set) 
            {
                return $"{calc.dblSolution} {calc.strMathOperator} {calc.dblOperand2} = ";
            } else if (calc.boolIsAnswered && calc.boolOperand1_Set && calc.boolOperator_Set)
            {
                return $"{calc.dblSolution} {calc.strMathOperator}";
            } else if (!calc.boolIsAnswered && calc.boolOperand2_Set && calc.boolOperator_Set && calc.boolOperand1_Set)
            {
                return $"{calc.dblOperand1} {calc.strMathOperator} {calc.dblOperand2}";
            } else if (!calc.boolIsAnswered && calc.boolOperator_Set && calc.boolOperand1_Set)
            {
                return $"{calc.dblOperand1} {calc.strMathOperator}";
            }
            else if (calc.boolOperand1_Set && !calc.boolOperator_Set)
            {
                return $"{calc.dblOperand1}";
            }
            else
            {
                return "";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Reset();
            txtEquation.Text = GetEquation();
            txtOutput.Text = calc.dblOperand1.ToString();
        }

        //Changes Sign of the value. Does not put '-' if 0.
        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            string value = txtOutput.Text;
            if (value.ElementAt(0).ToString() == "-")
            {
                value = value.Substring(1);
            }
            else if (value != "0")
            {
                value = value.Insert(0, "-");
            }
            txtOutput.Text = value;
        }

        // Removes the last digit. If all digits removed, output.Text = "0" and reset nextOperand to true;
        private void btnBack_Click(object sender, EventArgs e)
        {
            string value = txtOutput.Text;
            value = value.Substring(0, value.Length - 1);
            if (value == string.Empty)
            {
                txtOutput.Text = "0";
                calc.boolNextOperand = true;
            }
            else
            {
                txtOutput.Text = value;
            }
        }
        #endregion //

        // Functions: sqrt, 1/x, +, - , * , /, = 
        #region "Calculation Button_Click Functions"
        //Square root the value on the screen.
        //Resets the Calculator with dblOperand1 as the SQRT value. dblOperand2=0 , strMathOperator = "" set/unset proper bool properties;
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            double value;
            try
            {
                
                if (double.TryParse(txtOutput.Text, out value))
                {
                    txtEquation.Text = $"Sqrt({value})";
                    value = Math.Sqrt(value);
                    calc.dblOperand1 = value;
                    calc.dblSolution = value;
                    calc.boolIsAnswered = true;
                    calc.boolNextOperand = true;
                    calc.boolOperand1_Set = true;
                    calc.dblOperand2 = 0;
                    calc.boolOperand2_Set = false;
                    calc.strMathOperator = string.Empty;
                    calc.boolOperator_Set = false;
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
                txtEquation.Text = string.Empty;
            }
        }


        //Reciprocal Function.
        //Resets the Calculator with dblOperand1 as the SQRT value. dblOperand2=0, strMathOperator = "";
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double value;
            try
            {
                if (double.TryParse(txtOutput.Text, out value))
                {
                    if (value != 0)
                    {
                        txtEquation.Text = $"1/({value})";
                        value = 1.0 / value;
                        calc.dblOperand1 = value;
                        calc.dblSolution = value;
                        calc.boolIsAnswered = true;
                        calc.dblOperand2 = 0;
                        calc.boolOperand1_Set = true;
                        calc.boolOperand2_Set = false;
                        calc.strMathOperator = string.Empty;
                        calc.boolOperator_Set = false;
                        calc.boolNextOperand = true;
                        txtOutput.Text = value.ToString();

                    }
                    else
                    {
                        txtEquation.Text = $"1/({value})";
                        txtOutput.Text = "UNDEFINED";
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
                txtEquation.Text = string.Empty;
            }
        }

        // Add. In scenarior : "1+2+3+4+5..." it will calculate the answers without pushing = button.
        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                // boolNextOperand == False means digits were inputed. Scenario: "1 + 2 + " is the sequence of buttons pressed.
                if (calc.boolOperand1_Set && calc.boolNextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.strMathOperator = "+";
                    txtEquation.Text = GetEquation();
                    calc.boolOperator_Set = true;
                }
                // boolNextOperand == true means No Digits were inputed. Scenario: "1 -+"
                else if (calc.boolNextOperand == true)
                {
                    calc.strMathOperator = "+";
                    calc.boolOperator_Set = true;
                    txtEquation.Text = GetEquation();
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.strMathOperator = "+";
                    calc.boolOperator_Set = true;
                    calc.boolNextOperand = true;
                    txtEquation.Text = GetEquation();
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
                txtEquation.Text = string.Empty;
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                // boolNextOperand == False means digits were inputed. Scenario: "1 - 2 - " is the sequence of buttons pressed.
                if (calc.boolOperand1_Set && calc.boolNextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.strMathOperator = "-";
                    txtEquation.Text = GetEquation();
                    calc.boolOperator_Set = true;
                }
                // boolNextOperand == true means No Digits were inputed. Scenario: "1 +-"
                else if (calc.boolNextOperand == true)
                {
                    calc.strMathOperator = "-";
                    calc.boolOperator_Set = true;
                    txtEquation.Text = GetEquation();
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.strMathOperator = "-";
                    calc.boolOperator_Set = true;
                    calc.boolNextOperand = true;
                    txtEquation.Text = GetEquation();
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
                txtEquation.Text = string.Empty;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                // boolNextOperand == False means digits were inputed. Scenario: "1 * 2 * " is the sequence of buttons pressed.
                if (calc.boolOperand1_Set && calc.boolNextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.strMathOperator = "*";
                    txtEquation.Text = GetEquation();
                    calc.boolOperator_Set = true;
                }
                // boolNextOperand == true means No Digits were inputed. Scenario: "1 +*"
                else if (calc.boolNextOperand == true)
                {
                    calc.strMathOperator = "*";
                    calc.boolOperator_Set = true;
                    txtEquation.Text = GetEquation();
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.strMathOperator = "*";
                    calc.boolOperator_Set = true;
                    calc.boolNextOperand = true;
                    txtEquation.Text = GetEquation();
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
                txtEquation.Text = string.Empty;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                // boolNextOperand == False means digits were inputed. Scenario: "10 / 2 / " is the sequence of buttons pressed.
                if (calc.boolOperand1_Set && calc.boolNextOperand == false)
                {
                    calc.SetOperand(2, txtOutput.Text);
                    txtOutput.Text = calc.Calculate();
                    calc.strMathOperator = "/";
                    txtEquation.Text = GetEquation();
                    calc.boolOperator_Set = true;
                }
                // boolNextOperand == true means No Digits were inputed. Scenario: "1 +/"
                else if (calc.boolNextOperand == true)
                {
                    calc.strMathOperator = "/";
                    calc.boolOperator_Set = true;
                    txtEquation.Text = GetEquation();
                }
                else
                {
                    calc.SetOperand(1, txtOutput.Text);
                    calc.strMathOperator = "/";
                    calc.boolOperator_Set = true;
                    calc.boolNextOperand = true;
                    txtEquation.Text = GetEquation();
                }
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
                txtEquation.Text = string.Empty;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                //if(calc.strMathOperator != "" && calc.boolOperator_Set == false)
                //{
                //    calc.boolOperator_Set = true;
                //}
                if (calc.boolOperand2_Set == false && calc.boolNextOperand == true)// scenarior "1+=" we want it to calculate 1+1=2
                {
                    calc.SetOperand(2, txtOutput.Text);
                }
                if (calc.boolNextOperand == false && calc.boolOperand1_Set)
                {
                    calc.SetOperand(2, txtOutput.Text);
                }else if (!calc.boolOperand1_Set)
                {
                    calc.SetOperand(1, txtOutput.Text);
                }
                txtEquation.Text = GetEquation();
                txtOutput.Text = calc.Calculate();
                calc.boolOperator_Set = false;
                
            }
            catch (Exception ex)
            {
                calc.Reset();
                txtOutput.Text = ex.Message;
                txtEquation.Text = string.Empty;
            }
        }
        #endregion

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
            if (txtOutput.Text != "0") OutputButton("0");

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            OutputButton(".");
        }

        #endregion

    }
}