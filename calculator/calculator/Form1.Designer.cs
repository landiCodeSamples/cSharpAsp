namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.lblResultsDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(51, 187);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(59, 56);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(181, 311);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(59, 56);
            this.btnThree.TabIndex = 1;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(116, 187);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(59, 56);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(116, 249);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(59, 56);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(116, 311);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(59, 56);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(266, 187);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 56);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(51, 311);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(59, 56);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(51, 249);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(59, 56);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(181, 187);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(59, 56);
            this.btnNine.TabIndex = 16;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(181, 249);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(59, 56);
            this.btnSix.TabIndex = 17;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(333, 311);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(59, 118);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(266, 311);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(59, 56);
            this.btnSubtract.TabIndex = 20;
            this.btnSubtract.Text = "--";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(266, 249);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(59, 56);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 56);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(116, 373);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(59, 56);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumbPadClick);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(181, 373);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(59, 56);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(51, 373);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(59, 56);
            this.btnPlusMinus.TabIndex = 25;
            this.btnPlusMinus.Text = "+-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // lblResultsDisplay
            // 
            this.lblResultsDisplay.AutoSize = true;
            this.lblResultsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsDisplay.Location = new System.Drawing.Point(341, 53);
            this.lblResultsDisplay.Name = "lblResultsDisplay";
            this.lblResultsDisplay.Size = new System.Drawing.Size(23, 25);
            this.lblResultsDisplay.TabIndex = 0;
            this.lblResultsDisplay.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 118);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 472);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResultsDisplay);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSeven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Label lblResultsDisplay;
        private System.Windows.Forms.Button btnClear;
    }
}

