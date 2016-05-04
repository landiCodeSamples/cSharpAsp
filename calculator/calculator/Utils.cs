using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    class Utils
    {
        public static double getNumberFromButton(Button numbPadBtn) {
            return double.Parse(numbPadBtn.Text);
        }

        public static string getStrvalueFromButton(Button numbPadBtn) {
            return numbPadBtn.Text;
        }

        public static void displayResults(double newnumber, Label lblresultdisplay) {
            string newNumber = newnumber.ToString();
            lblresultdisplay.Text = newNumber;
        }

        public static void displayResults(double newnumber, double prvnumb, Label lblresultdisplay)
        {
            string newNumber = newnumber.ToString();
            string prvNumber = prvnumb.ToString();
            lblresultdisplay.Text = newNumber + prvNumber;
        }

        public static bool isNewNumber(int numberpadtracker) {
            return numberpadtracker % 2 == 0;
        }

        public static void clearIfFirstNumbpadClick(int numbpadtracker, Label lblresultdisplay) {
            if (numbpadtracker == 1) {
                lblresultdisplay.Text = "";
            }
        }
    }
}
