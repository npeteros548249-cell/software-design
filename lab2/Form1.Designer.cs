namespace lab2
{
	partial class Form1
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
            textInput = new TextBox();
            lblResult = new Label();
            btnFactorial = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            txtArrayInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCalculateFibonacci = new Button();
            lblResultFibonacci = new Label();
            txtInputFibonnaci = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnCalculatePower = new Button();
            lblResultPower = new Label();
            txtInputBase = new TextBox();
            label7 = new Label();
            txtInputPower = new TextBox();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.Location = new Point(31, 130);
            textInput.Name = "textInput";
            textInput.Size = new Size(282, 27);
            textInput.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(31, 223);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 23);
            lblResult.TabIndex = 1;
            lblResult.Text = "label";
            // 
            // btnFactorial
            // 
            btnFactorial.Location = new Point(120, 172);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(94, 52);
            btnFactorial.TabIndex = 2;
            btnFactorial.Text = "Calculate";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 107);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "Input Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 43);
            label2.Name = "label2";
            label2.Size = new Size(157, 46);
            label2.TabIndex = 4;
            label2.Text = "Factorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 289);
            label3.Name = "label3";
            label3.Size = new Size(290, 46);
            label3.TabIndex = 9;
            label3.Text = "Sum of the Array";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 353);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Input Array";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(119, 419);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(95, 53);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(31, 469);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(49, 23);
            lblSumResult.TabIndex = 6;
            lblSumResult.Text = "label";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(31, 376);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(282, 27);
            txtArrayInput.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(494, 43);
            label5.Name = "label5";
            label5.Size = new Size(171, 46);
            label5.TabIndex = 14;
            label5.Text = "Fibonacci";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 107);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 13;
            label6.Text = "Input Number";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(571, 172);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(94, 52);
            btnCalculateFibonacci.TabIndex = 12;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblResultFibonacci
            // 
            lblResultFibonacci.AutoSize = true;
            lblResultFibonacci.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultFibonacci.Location = new Point(502, 234);
            lblResultFibonacci.Name = "lblResultFibonacci";
            lblResultFibonacci.Size = new Size(49, 23);
            lblResultFibonacci.TabIndex = 11;
            lblResultFibonacci.Text = "label";
            // 
            // txtInputFibonnaci
            // 
            txtInputFibonnaci.Location = new Point(502, 130);
            txtInputFibonnaci.Name = "txtInputFibonnaci";
            txtInputFibonnaci.Size = new Size(218, 27);
            txtInputFibonnaci.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(494, 289);
            label8.Name = "label8";
            label8.Size = new Size(120, 46);
            label8.TabIndex = 19;
            label8.Text = "Power";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(502, 353);
            label9.Name = "label9";
            label9.Size = new Size(136, 20);
            label9.TabIndex = 18;
            label9.Text = "Input Base Number";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(571, 485);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(94, 53);
            btnCalculatePower.TabIndex = 17;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblResultPower
            // 
            lblResultPower.AutoSize = true;
            lblResultPower.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultPower.Location = new Point(502, 538);
            lblResultPower.Name = "lblResultPower";
            lblResultPower.Size = new Size(49, 23);
            lblResultPower.TabIndex = 16;
            lblResultPower.Text = "label";
            // 
            // txtInputBase
            // 
            txtInputBase.Location = new Point(502, 376);
            txtInputBase.Name = "txtInputBase";
            txtInputBase.Size = new Size(218, 27);
            txtInputBase.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(502, 413);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 21;
            label7.Text = "Input Exponent";
            // 
            // txtInputPower
            // 
            txtInputPower.Location = new Point(502, 436);
            txtInputPower.Name = "txtInputPower";
            txtInputPower.Size = new Size(218, 27);
            txtInputPower.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(803, 662);
            Controls.Add(label7);
            Controls.Add(txtInputPower);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnCalculatePower);
            Controls.Add(lblResultPower);
            Controls.Add(txtInputBase);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblResultFibonacci);
            Controls.Add(txtInputFibonnaci);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFactorial);
            Controls.Add(lblResult);
            Controls.Add(textInput);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Label lblResult;
        private Button btnFactorial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private TextBox txtArrayInput;
        private Label label5;
        private Label label6;
        private Button btnCalculateFibonacci;
        private Label lblResultFibonacci;
        private TextBox txtInputFibonnaci;
        private Label label8;
        private Label label9;
        private Button btnCalculatePower;
        private Label lblResultPower;
        private TextBox txtInputBase;
        private Label label7;
        private TextBox txtInputPower;
    }
}
