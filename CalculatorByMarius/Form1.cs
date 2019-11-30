﻿using System;
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
        bool _operatorInserted = false;
        public const string PLUS_OPERATOR = "+";
        public const string MINUS_OPERATOR = "-";
        public const string DIVISION_OPERATOR = "/";
        public const string MULTIPLY_OPERATOR = "x";


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
            
            switch (key)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    NullButton.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    //OneButton.PerformClick();
                    NumbersEvent(OneButton,e); // ask Dani question regarding NumbersEvent
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    TwoButton.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    ThreeButton.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    FourButton.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    FiveButton.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    SixButton.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    SevenButton.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    EightButton.PerformClick();
                    if (e.Shift)
                        MultiplyButton.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    NineButton.PerformClick();
                    break;
                case Keys.Multiply:
                    MultiplyButton.PerformClick();
                    break;
                case Keys.OemPeriod:
                    DotButton.PerformClick();
                    break;
                case Keys.Back:
                    BackspaceButton.PerformClick();
                    break;
                case Keys.OemQuestion:
                case Keys.Divide:
                    DivisionButton.PerformClick();
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    MinusButton.PerformClick();
                    break;
                case Keys.Oemplus:
                    if (e.Shift)
                    {
                        PlusButton.PerformClick();
                    }
                    else
                    {
                        EqualButton.PerformClick();
                    }
                    break;
                case Keys.Add:
                    PlusButton.PerformClick();
                    break;
                // For the Undo button (CTRL+Z)
                case Keys.Z:
                    if (e.Control)
                        UndoButton.PerformClick();
                    break;
                default:
                    break;
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
            _operatorInserted = false;
        }

        /// <summary>
        /// Event that happens when a operator button is clicked
        /// Inserts a operator to the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorsEvent(object sender, EventArgs e)
        {
            if (_operatorInserted == false)
            {
                _entered_value = true;
                Button btn = (Button)sender;
                string newOperand = btn.Text;

                LbResult.Text = LbResult.Text + " " + TxtDisplay.Text + " " + newOperand;
                //save last label display
                _lastLbDisplay = LbResult.Text;

                switch (_operation)
                {
                    case PLUS_OPERATOR:
                        TxtDisplay.Text = (_result + Double.Parse(TxtDisplay.Text)).ToString(); break;
                    case MINUS_OPERATOR:
                        TxtDisplay.Text = (_result - Double.Parse(TxtDisplay.Text)).ToString(); break;
                    case MULTIPLY_OPERATOR:
                        TxtDisplay.Text = (_result * Double.Parse(TxtDisplay.Text)).ToString(); break;
                    case DIVISION_OPERATOR:
                        TxtDisplay.Text = (_result / Double.Parse(TxtDisplay.Text)).ToString(); break;
                    default: break;
                }

                _result = Double.Parse(TxtDisplay.Text);
                // save last result 
                _lastResult = _result;

                _operation = newOperand;

                //reset label result when it is too large
                ResetLabelResult();
                _operatorInserted = true;
            }
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
            else if (_entered_value && !_operatorInserted)
            {
                TxtDisplay.Text = "0";
            }

            if (!TxtDisplay.Text.Contains(".") && !_operatorInserted)
                TxtDisplay.Text += ".";

            if (!_operatorInserted)
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
           LbResult.Text = string.Empty;
            _entered_value = true;

            switch (_operation)
            {
                case PLUS_OPERATOR:
                    TxtDisplay.Text = (_result + Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case MINUS_OPERATOR:
                    TxtDisplay.Text = (_result - Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case MULTIPLY_OPERATOR:
                    TxtDisplay.Text = (_result * Double.Parse(TxtDisplay.Text)).ToString();
                    break;
                case DIVISION_OPERATOR:
                    TxtDisplay.Text = (_result / Double.Parse(TxtDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }
            _result = Double.Parse(TxtDisplay.Text);
            TxtDisplay.Text = _result.ToString();
            _result = 0;
            _operation = string.Empty;
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
            _operation = string.Empty;
            LbResult.Text = string.Empty;
        }

        /// <summary>
        /// Removes the last number from the displayed text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1);
            
            if (TxtDisplay.Text == string.Empty)
                TxtDisplay.Text = "0";
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
                LbResult.Text = string.Empty;
            }
        }

        #endregion
    }
}
