using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculation
    {
        private double numb1;
        private double numb2;
        private double result;
        private string calctype = "";
        public Calculation(double numb1, double numb2, string calctype) {
            this.numb1 = numb1;
            this.numb2 = numb2;
            this.calctype = calctype;
            makeCalculation();
        }

        public double getNumb1() { return this.numb1; }

        public double getNumb2() { return this.numb2; }

        public void setNumb1(double number) { this.numb1 = number; }

        public void setNumb2(double number) { this.numb2 = number; }

        public void setCalctype(string calctype) { this.calctype = calctype; }

        public double getResult() { return result; }

        private void multiplication() {
            result = getNumb1() * getNumb2();
        }

        private void division() {
            result = getNumb1() / getNumb2();
        }

        private void addition() {
            result = getNumb1() + getNumb2();
        }

        private void subtraction() {
            result = getNumb1() - getNumb2();
        }

        private void makeCalculation() {
            switch (calctype) {
                case "+":
                    addition();
                    break;
                case "-":
                    subtraction();
                    break;
                case "x":
                    multiplication();
                    break;
                case "/":
                    division();
                    break;
                default:
                    break;
            }
        }


    }
}
