using System;
using System.Windows.Forms;

namespace CalculatorByMarius
{
    /// <summary>
    /// Basic calculator project - Marius S.
    /// </summary>
    public partial class Calculator : Form
    {
        Double result = 0;
        Double lastResult = 0;
        string lastLbDisplay = "";
        String operation = "";
        bool enter_value = false;

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        #endregion
        
        /// <summary>
        /// Event that happens when a number button is clicked
        /// Inserts a number into the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersEvent(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            if (TxtDisplay.Text == "0" || enter_value)
                TxtDisplay.Clear();

            TxtDisplay.Text += btn.Text;
            enter_value = false;
        }

        /// <summary>
        /// Event that happens when a operator button is clicked
        /// Inserts a operator to the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorsEvent(object sender, EventArgs e)
        {
            enter_value = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            LbResult.Text = LbResult.Text + " " + TxtDisplay.Text + " " + newOperand;
            //save last label display
            lastLbDisplay = LbResult.Text;

            switch (operation)
            {
                case "+": TxtDisplay.Text = (result + Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "-": TxtDisplay.Text = (result - Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "x": TxtDisplay.Text = (result * Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "/": TxtDisplay.Text = (result / Double.Parse(TxtDisplay.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(TxtDisplay.Text);

            // save last result
            lastResult = result;


            operation = newOperand;

            ResetLabelResult();
        }
        
        /// <summary>
        /// Calculates the result of the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
           LbResult.Text = "";
            enter_value = true;

            switch (operation)
            {
                case "+":
                    TxtDisplay.Text = (result + Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "-":
                    TxtDisplay.Text = (result - Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "x":
                    TxtDisplay.Text = (result * Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "/":
                    TxtDisplay.Text = (result / Double.Parse(TxtDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }
            result = Double.Parse(TxtDisplay.Text);
            TxtDisplay.Text = result.ToString();
            result = 0;
            operation = "";
        }

        /// <summary>
        /// Clears the displayed number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }

        /// <summary>
        /// Clears the entire calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CButton_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            result = 0;
            operation = "";
            LbResult.Text = "";
        }

        /// <summary>
        /// Removes the last number from the displayed text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1);
            }

            if (TxtDisplay.Text == "")
            {
                TxtDisplay.Text = "0";
            }
        }

        /// <summary>
        /// Handling decimals for equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!enter_value && !TxtDisplay.Text.Contains("."))
            {
                TxtDisplay.Text += ".";
            }
            else if (enter_value)
            {
                TxtDisplay.Text = "0";
            }

            if (!TxtDisplay.Text.Contains("."))
            {
                TxtDisplay.Text += ".";
            }

            enter_value = false;
        }

        /// <summary>
        /// Sends the equation one step back, sets the previous result and displayed equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Reset the displayed history label when it gets too long
        /// </summary>
        private void ResetLabelResult()
        {
            if (LbResult.Text.Length > 52)
            {
                LbResult.Text = "";
            }
        }

     
    }
}
