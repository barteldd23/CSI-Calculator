using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB.Calculator.BL.Models
{
    public class Calc
    {
        public double dblOperand1 { get; set; }
        public double dblOperand2 { get; set; }
        public double dblSolution { get; set; }
        public bool boolOperand1_Set { get; set; }
        public bool boolOperand2_Set { get; set; }
        public bool boolOperator_Set { get; set; }
        public bool boolIsAnswered { get; set; }
        public string strMathOperator { get; set; }
        public bool boolNextOperand { get; set; }
        
        

        public Calc() 
        { 
            dblOperand1 = 0;
            dblOperand2 = 0;
            boolOperand1_Set = false;
            boolOperand2_Set = false;
            strMathOperator = string.Empty;
            boolNextOperand = true;
            boolIsAnswered = false;
            dblSolution = 0;
            
        }

        public void SetOperand(int num, string value)
        {
            double number;
            if (num == 1)
            {
                if(Double.TryParse(value, out number))
                {
                    this.dblOperand1 = number;
                    this.boolOperand1_Set = true;
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            } else if(num == 2)
            {
                if (Double.TryParse(value, out number))
                {
                    this.dblOperand2 = number;
                    this.boolOperand2_Set = true;
                }
                else
                {
                    throw new Exception("Err: Not a Number");
                }
            }
        }

        public void Reset()
        {
            this.dblOperand1 = 0;
            this.dblOperand2 = 0;
            this.boolOperand1_Set = false;
            this.boolOperand2_Set = false;
            this.strMathOperator = string.Empty;
            this.boolNextOperand = true;
            this.dblSolution = 0;
            this.boolIsAnswered = false;
        }

        public string Calculate()
        {
            double solution;
            this.boolNextOperand = true;
            if(this.boolOperand2_Set)
            {

                // 1) Check for operand type
                // 2) Do the calculation
                // 3) set boolIsAnswered to true and dblOperand to the solution
                // 4) change boolOperand2_Set to false so that GetEquation() can format properly in situations like "Ans +"
                // 5) Return the solution string.
                // 6) Returns the error if there was one.

                if (this.strMathOperator == "+")
                {
                    this.dblSolution = this.dblOperand1 + this.dblOperand2;
                    this.boolIsAnswered = true;
                    this.dblOperand1 = this.dblSolution;
                    this.boolOperand2_Set= false;
                    return this.dblSolution.ToString();
                }
                if (this.strMathOperator == "-")
                {
                    this.dblSolution = this.dblOperand1 - this.dblOperand2;
                    this.boolIsAnswered = true;
                    this.dblOperand1 = this.dblSolution;
                    this.boolOperand2_Set = false;
                    return this.dblSolution.ToString();
                }
                if (this.strMathOperator == "*")
                {
                    this.dblSolution = this.dblOperand1 * this.dblOperand2;
                    this.boolIsAnswered = true;
                    this.dblOperand1 = this.dblSolution;
                    this.boolOperand2_Set = false;
                    return this.dblSolution.ToString();
                }
                if (this.strMathOperator == "/")
                {
                    if (this.dblOperand2 == 0)
                    {
                        this.Reset();
                        return "Err: Can't Divide by 0";
                    }

                    this.dblSolution = this.dblOperand1 / this.dblOperand2;
                    this.boolIsAnswered = true;
                    this.dblOperand1 = this.dblSolution;
                    this.boolOperand2_Set = false;
                    return this.dblSolution.ToString();
                }
            } else if (this.boolOperand1_Set) //user types something like "5="
            {
                this.dblSolution = this.dblOperand1;
                return this.dblSolution.ToString();
            }
            
            return "Err";
        }
    }
}
