using System;
using System.Windows.Forms;

namespace CalculatorByMarius
{
    /// <summary>
    /// Basic calculator project - Marius S.
    /// </summary>
    public partial class Calculator : Form
    {
        Double _result = 0; // used to store the result of the equation
        Double _lastResult = 0; // need work - in Undo action
        string _lastLbDisplay = ""; //need work - in Undo action
        String _operation = ""; //used to determine if an operator was inserted
        bool _entered_value = false; //used to determine if a value was inserted

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        #endregion

        #region Calculator form methods

        /// <summary>
        /// The form load code 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //enable the keyboard for the form
        }

        /// <summary>
        /// The KeyDown event from the form - handling keyboard for the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            /// One char keys 
            switch (key)
            {
                case Keys.D0:
                    NullButton.PerformClick();
                    break;
                case Keys.D1:
                    OneButton.PerformClick();
                    break;
                case Keys.D2:
                    TwoButton.PerformClick();
                    break;
                case Keys.D3:
                    ThreeButton.PerformClick();
                    break;
                case Keys.D4:
                    FourButton.PerformClick();
                    break;
                case Keys.D5:
                    FiveButton.PerformClick();
                    break;
                case Keys.D6:
                    SixButton.PerformClick();
                    break;
                case Keys.D7:
                    SevenButton.PerformClick();
                    break;
                case Keys.D8:
                    EightButton.PerformClick();
                    break;
                case Keys.D9:
                    NineButton.PerformClick();
                    break;
                case Keys.OemPeriod:
                    DotButton.PerformClick();
                    break;
                case Keys.Back:
                    BackspaceButton.PerformClick();
                    break;
                case Keys.OemQuestion:
                    DivisionButton.PerformClick();
                    break;
                case Keys.OemMinus:
                    MinusButton.PerformClick();
                    break;
                default:
                    break;
            }

            // keys that needs Shift control
            if (e.Shift)
            {
                switch (key)
                {
                    case Keys.D8:
                        MultiplyButton.PerformClick();
                        break;
                    case Keys.Oemplus:
                        PlusButton.PerformClick();
                        break;
                    default:
                        break;
                }
            }

            // key for equal button - prevents conflict with Plus button
            if(!e.Shift && e.KeyCode == Keys.Oemplus)
                    EqualButton.PerformClick();
            
            // For the Undo button (CTRL+Z)
            if (e.Control && e.KeyCode == Keys.Z)
            {
                UndoButton.PerformClick();
            }
        }

        #endregion

        #region Numbers&Operators event methods
        /// <summary>
        /// Event that happens when a number button is clicked
        /// Inserts a number into the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersEvent(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            
            if (TxtDisplay.Text == "0" || _entered_value)
                TxtDisplay.Clear();

            TxtDisplay.Text += btn.Text;
            _entered_value = false;
        }

        /// <summary>
        /// Event that happens when a operator button is clicked
        /// Inserts a operator to the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorsEvent(object sender, EventArgs e)
        {
            _entered_value = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            LbResult.Text = LbResult.Text + " " + TxtDisplay.Text + " " + newOperand;
            //save last label display
            _lastLbDisplay = LbResult.Text;

            switch (_operation)
            {
                case "+": TxtDisplay.Text = (_result + Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "-": TxtDisplay.Text = (_result - Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "x": TxtDisplay.Text = (_result * Double.Parse(TxtDisplay.Text)).ToString(); break;
                case "/": TxtDisplay.Text = (_result / Double.Parse(TxtDisplay.Text)).ToString(); break;
                default: break;
            }

            _result = Double.Parse(TxtDisplay.Text);
            // save last result 
            _lastResult = _result;

            _operation = newOperand;

            //reset label result when it is too large
            ResetLabelResult();
        }

        /// <summary>
        /// Handling decimals for equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!_entered_value && !TxtDisplay.Text.Contains("."))
            {
                TxtDisplay.Text += ".";
            }
            else if (_entered_value)
            {
                TxtDisplay.Text = "0";
            }

            if (!TxtDisplay.Text.Contains("."))
            {
                TxtDisplay.Text += ".";
            }

            _entered_value = false;
        }

        #endregion

        #region Actions event methods

        /// <summary>
        /// Calculates the result of the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
           LbResult.Text = "";
            _entered_value = true;

            switch (_operation)
            {
                case "+":
                    TxtDisplay.Text = (_result + Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "-":
                    TxtDisplay.Text = (_result - Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "x":
                    TxtDisplay.Text = (_result * Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case "/":
                    TxtDisplay.Text = (_result / Double.Parse(TxtDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }
            _result = Double.Parse(TxtDisplay.Text);
            TxtDisplay.Text = _result.ToString();
            _result = 0;
            _operation = "";
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
            _result = 0;
            _operation = "";
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
        /// Sends the equation one step back, sets the previous result and displayed equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Private help methods
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

        #endregion
    }
}
