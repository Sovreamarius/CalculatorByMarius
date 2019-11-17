using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorByMarius
{
    /// <summary>
    /// Calculator project from Dani, created by Marius S.
    /// </summary>
    public partial class Calculator : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods for cleaning buttons

        /// <summary>
        /// Clear the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.Input.Text = string.Empty;
            FocusInput();
        }


        private void CButton_Click(object sender, EventArgs e)
        {
            FocusInput();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            DeleteInput();
            FocusInput();
        }

        #endregion

        #region Methods for operation buttons

        /// <summary>
        /// Adds "/" operator to the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            InsertValue("/");
            FocusInput();
        }

        /// <summary>
        /// Adds "*" operator to the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertValue("*");
            FocusInput();
        }

        /// <summary>
        /// Adds "-" operator to the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertValue("-");
            FocusInput();
        }

        /// <summary>
        /// Adds "+" operator to the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertValue("+");
            FocusInput();
        }

        /// <summary>
        /// Adds "." to the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertValue(".");
            FocusInput();
        }

        /// <summary>
        /// Calculates the equation from the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateTheResult();
            FocusInput();
        }

        /// <summary>
        /// Sends the equation back to one operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, EventArgs e)
        {
            FocusInput();
        }

        #endregion

        #region Methods for numbers buttons

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertValue("7");
            FocusInput();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertValue("8");
            FocusInput();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertValue("9");
            FocusInput();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertValue("4");
            FocusInput();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertValue("5");
            FocusInput();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertValue("6");
            FocusInput();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertValue("1");
            FocusInput();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertValue("2");
            FocusInput();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertValue("3");
            FocusInput();
        }

        private void NullButton_Click(object sender, EventArgs e)
        {
            InsertValue("0");
            FocusInput();
        }
        #endregion

        #region Helpful private methods

        /// <summary>
        ///
        /// </summary>
        private void FocusInput()
        {
            this.Input.Focus();
        }

        /// <summary>
        /// Inserts a value in the input text
        /// </summary>
        /// <param name="s"></param>
        private void InsertValue(string s)
        {
            var selectionStart = this.Input.SelectionStart;

            this.Input.Text = this.Input.Text.Insert(this.Input.SelectionStart, s);

            this.Input.SelectionStart = selectionStart + s.Length;

            this.Input.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the value from the input text that is set after the cursor
        /// </summary>
        private void DeleteInput()
        {
            if (this.Input.Text.Length < this.Input.SelectionStart + 1)
                return;

            var selectionStart = this.Input.SelectionStart;
           
            this.Input.Text = this.Input.Text.Remove(this.Input.SelectionStart, 1);

            this.Input.SelectionStart = selectionStart;

            this.Input.SelectionLength = 0;
        }

        /// <summary>
        /// Calculates the result of the equation
        /// </summary>
        private void CalculateTheResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
