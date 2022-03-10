
namespace lv1_objektno_zad2
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
            this.valueA = new System.Windows.Forms.TextBox();
            this.varA = new System.Windows.Forms.Label();
            this.varB = new System.Windows.Forms.Label();
            this.valueB = new System.Windows.Forms.TextBox();
            this.valueC = new System.Windows.Forms.TextBox();
            this.varC = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.solutionX1 = new System.Windows.Forms.Label();
            this.solutionX2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueA
            // 
            this.valueA.Location = new System.Drawing.Point(194, 36);
            this.valueA.Name = "valueA";
            this.valueA.Size = new System.Drawing.Size(100, 20);
            this.valueA.TabIndex = 0;
            // 
            // varA
            // 
            this.varA.AutoSize = true;
            this.varA.Location = new System.Drawing.Point(153, 39);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(29, 13);
            this.varA.TabIndex = 1;
            this.varA.Text = "varA";
            // 
            // varB
            // 
            this.varB.AutoSize = true;
            this.varB.Location = new System.Drawing.Point(317, 39);
            this.varB.Name = "varB";
            this.varB.Size = new System.Drawing.Size(29, 13);
            this.varB.TabIndex = 2;
            this.varB.Text = "varB";
            // 
            // valueB
            // 
            this.valueB.Location = new System.Drawing.Point(358, 36);
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(100, 20);
            this.valueB.TabIndex = 3;
            // 
            // valueC
            // 
            this.valueC.Location = new System.Drawing.Point(521, 36);
            this.valueC.Name = "valueC";
            this.valueC.Size = new System.Drawing.Size(100, 20);
            this.valueC.TabIndex = 5;
            // 
            // varC
            // 
            this.varC.AutoSize = true;
            this.varC.Location = new System.Drawing.Point(480, 39);
            this.varC.Name = "varC";
            this.varC.Size = new System.Drawing.Size(29, 13);
            this.varC.TabIndex = 4;
            this.varC.Text = "varC";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(346, 84);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(133, 24);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X1:";
            // 
            // solutionX1
            // 
            this.solutionX1.AutoSize = true;
            this.solutionX1.Location = new System.Drawing.Point(267, 146);
            this.solutionX1.Name = "solutionX1";
            this.solutionX1.Size = new System.Drawing.Size(56, 13);
            this.solutionX1.TabIndex = 8;
            this.solutionX1.Text = "solutionX1";
            // 
            // solutionX2
            // 
            this.solutionX2.AutoSize = true;
            this.solutionX2.Location = new System.Drawing.Point(549, 146);
            this.solutionX2.Name = "solutionX2";
            this.solutionX2.Size = new System.Drawing.Size(56, 13);
            this.solutionX2.TabIndex = 10;
            this.solutionX2.Text = "solutionX2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solutionX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.solutionX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.valueC);
            this.Controls.Add(this.varC);
            this.Controls.Add(this.valueB);
            this.Controls.Add(this.varB);
            this.Controls.Add(this.varA);
            this.Controls.Add(this.valueA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueA;
        private System.Windows.Forms.Label varA;
        private System.Windows.Forms.Label varB;
        private System.Windows.Forms.TextBox valueB;
        private System.Windows.Forms.TextBox valueC;
        private System.Windows.Forms.Label varC;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label solutionX1;
        private System.Windows.Forms.Label solutionX2;
        private System.Windows.Forms.Label label4;
    }
}

