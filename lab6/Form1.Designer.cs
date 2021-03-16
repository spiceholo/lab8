
namespace lab6
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
            this.compute = new System.Windows.Forms.Button();
            this.billBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.tipPercentageBox = new System.Windows.Forms.TextBox();
            this.totallyAmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(89, 283);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(75, 23);
            this.compute.TabIndex = 0;
            this.compute.Text = "compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(185, 125);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(100, 21);
            this.billBox.TabIndex = 1;
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(185, 201);
            this.tipBox.Name = "tipBox";
            this.tipBox.ReadOnly = true;
            this.tipBox.Size = new System.Drawing.Size(100, 21);
            this.tipBox.TabIndex = 2;
            // 
            // tipPercentageBox
            // 
            this.tipPercentageBox.Location = new System.Drawing.Point(185, 164);
            this.tipPercentageBox.Name = "tipPercentageBox";
            this.tipPercentageBox.Size = new System.Drawing.Size(100, 21);
            this.tipPercentageBox.TabIndex = 3;
            // 
            // totallyAmountBox
            // 
            this.totallyAmountBox.Location = new System.Drawing.Point(185, 239);
            this.totallyAmountBox.Name = "totallyAmountBox";
            this.totallyAmountBox.ReadOnly = true;
            this.totallyAmountBox.Size = new System.Drawing.Size(100, 21);
            this.totallyAmountBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "tip percentages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "billAmount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "totally amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "tips";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totallyAmountBox);
            this.Controls.Add(this.tipPercentageBox);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.compute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.TextBox tipPercentageBox;
        private System.Windows.Forms.TextBox totallyAmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

