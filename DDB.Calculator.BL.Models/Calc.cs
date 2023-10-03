using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB.Calculator.BL.Models
{
    public class Calc
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public bool Operand1_Set { get; set; }
        public bool Operand2_Set { get; set; }
        public string MathOperator { get; set; }
        public bool NextOperand { get; set; }

        public Calc() 
        { 
            Operand1 = 0;
            Operand2 = 0;
            Operand1_Set = false;
            Operand2_Set = false;
            MathOperator = string.Empty;
            NextOperand = true;
        }

        public void SetOperand(int num, string value)
        {
            double number;
            if (num == 1)
            {
                if(Double.TryParse(value, out number))
                {
                    this.Operand1 = number;
                    this.Operand1_Set = true;
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            } else if(num == 2)
            {
                if (Double.TryParse(value, out number))
                {
                    this.Operand2 = number;
                    this.Operand2_Set = true;
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            }
        }

        public void Reset()
        {
            this.Operand1 = 0;
            this.Operand2 = 0;
            this.Operand1_Set = false;
            this.Operand2_Set = false;
            this.MathOperator = string.Empty;
            this.NextOperand = true;
        }

        public string Calculate()
        {
            double solution;
            this.NextOperand = true;
            if(this.Operand2_Set)
            {
                if (this.MathOperator == "+")
                {
                    solution = this.Operand1 + this.Operand2;
                    this.Operand1 = solution;
                    return solution.ToString();
                }
                if (this.MathOperator == "-")
                {
                    solution = this.Operand1 - this.Operand2;
                    this.Operand1 = solution;
                    return solution.ToString();
                }
                if (this.MathOperator == "*")
                {
                    solution = this.Operand1 * this.Operand2;
                    this.Operand1 = solution;
                    return solution.ToString();
                }
                if (this.MathOperator == "/")
                {
                    if (this.Operand2 == 0)
                    {
                        return "Err: Can't Divide by 0";
                    }

                    solution = this.Operand1 / this.Operand2;
                    this.Operand1 = solution;
                    return solution.ToString();

                }
            }
            
            return "Err";
        }


    }
}
