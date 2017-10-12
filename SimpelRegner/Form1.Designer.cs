namespace SimpelRegner
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.NumericUpDown();
            this.secondNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udregnKnap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(17, 100);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(86, 20);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Resultat";
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(128, 39);
            this.firstNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.firstNumber.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(65, 20);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.ValueChanged += new System.EventHandler(this.firstNumber_ValueChanged);
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(128, 98);
            this.secondNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secondNumber.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(65, 20);
            this.secondNumber.TabIndex = 2;
            this.secondNumber.ValueChanged += new System.EventHandler(this.secondNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Første tal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Andet tal";
            // 
            // udregnKnap
            // 
            this.udregnKnap.Location = new System.Drawing.Point(17, 59);
            this.udregnKnap.Name = "udregnKnap";
            this.udregnKnap.Size = new System.Drawing.Size(67, 23);
            this.udregnKnap.TabIndex = 5;
            this.udregnKnap.Text = "Udregn!";
            this.udregnKnap.UseVisualStyleBackColor = true;
            this.udregnKnap.Click += new System.EventHandler(this.udregnKnap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GitHub test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Plus",
            "Minus",
            "Gange",
            "Division"});
            this.comboBox1.Location = new System.Drawing.Point(17, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Vælg:";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(244, 198);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.udregnKnap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.ResultLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simpel Regner";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.NumericUpDown firstNumber;
        private System.Windows.Forms.NumericUpDown secondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button udregnKnap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

