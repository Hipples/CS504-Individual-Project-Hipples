
namespace IP01___Windows_Calculator
{
    partial class CalculatorWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorWindow));
            this.CurrentOperationLabel = new System.Windows.Forms.Label();
            this.TextBoxResults = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonTimes = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Botton4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.Buttonthree = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentOperationLabel
            // 
            this.CurrentOperationLabel.AutoSize = true;
            this.CurrentOperationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CurrentOperationLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentOperationLabel.Location = new System.Drawing.Point(12, 13);
            this.CurrentOperationLabel.Name = "CurrentOperationLabel";
            this.CurrentOperationLabel.Size = new System.Drawing.Size(0, 31);
            this.CurrentOperationLabel.TabIndex = 44;
            this.CurrentOperationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxResults
            // 
            this.TextBoxResults.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxResults.Location = new System.Drawing.Point(12, 47);
            this.TextBoxResults.Name = "TextBoxResults";
            this.TextBoxResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxResults.Size = new System.Drawing.Size(339, 39);
            this.TextBoxResults.TabIndex = 43;
            this.TextBoxResults.Text = "0";
            this.TextBoxResults.TextChanged += new System.EventHandler(this.TextBoxResults_TextChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Location = new System.Drawing.Point(12, 97);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(80, 60);
            this.ButtonDelete.TabIndex = 42;
            this.ButtonDelete.Text = "<";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.BackSpaceClick);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.Location = new System.Drawing.Point(184, 97);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(80, 60);
            this.ButtonClear.TabIndex = 41;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDivide.Location = new System.Drawing.Point(272, 97);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(80, 60);
            this.ButtonDivide.TabIndex = 40;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtonCE
            // 
            this.ButtonCE.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCE.Location = new System.Drawing.Point(98, 97);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(80, 60);
            this.ButtonCE.TabIndex = 39;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ClearEntryClick);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEquals.Location = new System.Drawing.Point(270, 373);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(80, 60);
            this.ButtonEquals.TabIndex = 38;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ResultsClick);
            // 
            // ButtonTimes
            // 
            this.ButtonTimes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTimes.Location = new System.Drawing.Point(272, 163);
            this.ButtonTimes.Name = "ButtonTimes";
            this.ButtonTimes.Size = new System.Drawing.Size(80, 60);
            this.ButtonTimes.TabIndex = 37;
            this.ButtonTimes.Text = "x";
            this.ButtonTimes.UseVisualStyleBackColor = true;
            this.ButtonTimes.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMinus.Location = new System.Drawing.Point(272, 229);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(80, 60);
            this.ButtonMinus.TabIndex = 36;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDecimal.Location = new System.Drawing.Point(184, 373);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(80, 60);
            this.ButtonDecimal.TabIndex = 35;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = true;
            this.ButtonDecimal.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(12, 373);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(166, 60);
            this.Zero.TabIndex = 34;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(184, 163);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(80, 60);
            this.Button9.TabIndex = 33;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(184, 229);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(80, 60);
            this.Button6.TabIndex = 32;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(98, 163);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(80, 60);
            this.Button8.TabIndex = 31;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(98, 229);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(80, 60);
            this.Button5.TabIndex = 30;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(12, 163);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(80, 60);
            this.Button7.TabIndex = 29;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Botton4
            // 
            this.Botton4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Botton4.Location = new System.Drawing.Point(12, 229);
            this.Botton4.Name = "Botton4";
            this.Botton4.Size = new System.Drawing.Size(80, 60);
            this.Botton4.TabIndex = 28;
            this.Botton4.Text = "4";
            this.Botton4.UseVisualStyleBackColor = true;
            this.Botton4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(98, 295);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 60);
            this.Button2.TabIndex = 27;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlus.Location = new System.Drawing.Point(272, 295);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(80, 60);
            this.ButtonPlus.TabIndex = 26;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Buttonthree
            // 
            this.Buttonthree.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buttonthree.Location = new System.Drawing.Point(186, 295);
            this.Buttonthree.Name = "Buttonthree";
            this.Buttonthree.Size = new System.Drawing.Size(80, 60);
            this.Buttonthree.TabIndex = 25;
            this.Buttonthree.Text = "3";
            this.Buttonthree.UseVisualStyleBackColor = true;
            this.Buttonthree.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(12, 295);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 60);
            this.Button1.TabIndex = 24;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.CurrentOperationLabel);
            this.Controls.Add(this.TextBoxResults);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonTimes);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Botton4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.Buttonthree);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentOperationLabel;
        private System.Windows.Forms.TextBox TextBoxResults;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonTimes;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonDecimal;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Botton4;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button Buttonthree;
        private System.Windows.Forms.Button Button1;
    }
}

