using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private int numbPadTracker = 0;
        private string numbsInDisplay = "";
        private double firstNumber;
        private double secondNumber;
        private string operation = "";
        private bool btnOperationClick = false;
        public Form1()
        {
            InitializeComponent();
            lblResultsDisplay.Text = "0";
        }

        #region Form click events
        /*The following methods are for handling the calculators button clicks.
          btnNumbPadClick() is wired to all numberpad button. Instead of creating a 
          seprate event for each numberpad button inorder to get its value, this method 
          handels it reducing complexity and code.*/
        private void btnNumbPadClick(object sender, EventArgs e)
        {
            numbPadTracker++;
            btnOperationClick = false;
            Button btn = sender as Button;
            double numbPadNumb = double.Parse(btn.Text);
            setResultsDisplay(numbPadNumb.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setOperationEvent("+");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            setOperationEvent("x");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            setOperationEvent("-");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            setOperationEvent("/");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btnOperationClick = true;
            if (isReadyForCalc())
            {
                setSecondNumber();
                Calculation calc = new Calculation(firstNumber, secondNumber, operation);
                clearResultsDisplay();
                setResultsDisplay(calc.getResult().ToString());
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numbPadTracker = 0;
            clearResultsDisplay();
            btnOperationClick = false;
            operation = "";
            firstNumber = 0;
            secondNumber = 0;
        }
        #endregion

        #region Form helper methods
        private void setResultsDisplay(string numb) {
            
            numbsInDisplay += numb;
            lblResultsDisplay.Text = numbsInDisplay;
        }

        private void setFirstNumber() {
            firstNumber = double.Parse(lblResultsDisplay.Text);
        }

        private void setSecondNumber() {
            secondNumber = double.Parse(lblResultsDisplay.Text);
        }

        

        private void clearResultsDisplay() {
            numbsInDisplay = "";
            lblResultsDisplay.Text = "";
        }

        private bool isReadyForCalc() {
            if (numbPadTracker > 0 && btnOperationClick == true) {
                return true;
            }
            return false;
        }

        private void setOperationEvent(string op) {
            btnOperationClick = true;
            operation = op;
            setFirstNumber();
            clearResultsDisplay();
            numbPadTracker = 0;
        }
        #endregion
    }
}
