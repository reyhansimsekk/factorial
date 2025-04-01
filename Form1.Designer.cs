namespace FactorialApp
{
    partial class Form1
    {
     
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            txtNumber = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 12F);
            txtNumber.Location = new Point(26, 22);
            txtNumber.Margin = new Padding(3, 2, 3, 2);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(132, 29);
            txtNumber.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(175, 22);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(103, 29);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(26, 60);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 112);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumber);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Factorial Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
