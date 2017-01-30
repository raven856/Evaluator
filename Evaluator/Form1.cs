using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Evaluator
{

    public partial class Form1 : Form
    {
        public string type = "in";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("clicked");
            var value = new double();
            var nums = new Stack<double>();
            var ops = new Stack<Char>();
            var expression = txtExpression.Text;
            var chars = expression.ToCharArray();
            if (type == "post") {
                //Goes through every character in the expression
                Debug.WriteLine("post code will run");
                foreach (char kar in chars) {
                    //checks for a space
                    if (kar == ' ')
                    {
                        continue;
                    } else
                    //checks to see if character is a number or an operator
                    {
                        if (kar >= 0 && kar <= 9)
                        {
                            nums.Push(kar);
                        }
                        else
                        {
                            ops.Push(kar);
                        }
                    }

                }

            }
            else if (type == "pre") {
                Debug.WriteLine("prefix code will run");
                var stack = new Stack<Char>();

            }
            else //Infix
            {
                Debug.WriteLine("Infix code will run");
                Debug.WriteLine("Char count: "+ chars.Count());
                //Goes through every character in the expression
                for (int i = 0; i < chars.Count(); i++)
                {
                    Debug.WriteLine("chars iteration: " + i);
                    //checks for a space
                    if (chars[i] == ' ')
                    {
                        Debug.WriteLine("space found");
                        continue;
                    }
                    else
                    //checks to see if character is a number or an operator
                    {
                        //Number
                        if (chars[i] >= 48 && chars[i] <= 57)
                        {
                            Debug.WriteLine("Number character detected");
                            //check to see if previous char was part of same number
                            if (nums.Count > 0)
                            {
                                if (chars[i - 1] >= 48 && chars[i - 1] <= 57)
                                {
                                    double temp = nums.Pop() * 10;
                                    nums.Push(chars[i]);
                                    nums.Push((nums.Pop() - 48) + temp);
                                    Debug.WriteLine("multicharacter number pushed to nums");
                                    continue;
                                } //this was for multicharacter numbers
                            }
                            //push the character and subtract 48 to get its corresponding integer value
                            
                            nums.Push(chars[i]);
                            nums.Push(nums.Pop() - 48);
                            Debug.WriteLine("pushed number kar to nums value: " + nums.Peek());
                        }
                        else
                        //Operator
                        {   // + or -
                            if (chars[i] == '+' || chars[i] == '-')
                            {
                                //cant put lower precidence on higher precidence so do those calulations before pushing next operator
                                if (ops.Count > 0 && ops.Peek() == '*')
                                {
                                    nums.Push(nums.Pop() * nums.Pop());
                                }
                                else if (ops.Count > 0 && ops.Peek() == '/')
                                {
                                    Double temp = nums.Pop();
                                    nums.Push(nums.Pop() / temp);
                                }
                                else if (ops.Count > 0 && ops.Peek() == '^')
                                {
                                    Double temp = nums.Pop();
                                    nums.Push(Math.Pow(nums.Pop(), temp));
                                }

                                Debug.WriteLine("pushed + or - ");
                            }
                            // ^
                            else if (chars[i] == '^')
                            {
                                ops.Push(chars[i]);
                            }
                            // * or /
                            else
                            {
                                if (ops.Count > 0 && ops.Peek() == '^') //cant put lower precidence on higher precidence so do those calulations before pushing next operator
                                {
                                    Double temp = nums.Pop();
                                    nums.Push(Math.Pow(nums.Pop(), temp));
                                }
                                else { ops.Push(chars[i]); }
                            }
                        }
                    }
                }//All Characters pushed  
                while (ops.Count != 0) {
                        double temp = 0;
                        switch ( ops.Pop() ) {
                            case '-':
                                temp = nums.Pop();
                                nums.Push(nums.Pop() - temp);
                                break;
                            case '+':
                                nums.Push(nums.Pop() + nums.Pop());
                                break;
                            case '/':
                                temp = nums.Pop();
                                nums.Push(nums.Pop() / temp);
                                break;
                            case '*':
                                temp = nums.Pop();
                                nums.Push(nums.Pop() * temp);
                                break;
                            case '^':
                                temp = nums.Pop();
                                nums.Push(Math.Pow(nums.Pop(), temp));
                                break;
                            default:
                                break;
                        }
                    }
                    //remaining number is value  2 decimals max!
                    value = nums.Pop();
                    lblHead.Text = value.ToString();
                } //end infix
            } //end btnEvaluate 
        }//end Class
    
}
