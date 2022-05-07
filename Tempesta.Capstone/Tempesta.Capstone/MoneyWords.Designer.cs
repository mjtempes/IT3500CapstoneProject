
namespace Tempesta.Capstone
{
    partial class frmMoneyWords
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
            this.lblWordsOutput = new System.Windows.Forms.Label();
            this.txtMoneyInput = new System.Windows.Forms.TextBox();
            this.lblDollorSign = new System.Windows.Forms.Label();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWordsOutput
            // 
            this.lblWordsOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWordsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordsOutput.Location = new System.Drawing.Point(12, 333);
            this.lblWordsOutput.Name = "lblWordsOutput";
            this.lblWordsOutput.Size = new System.Drawing.Size(890, 37);
            this.lblWordsOutput.TabIndex = 0;
            this.lblWordsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMoneyInput
            // 
            this.txtMoneyInput.Location = new System.Drawing.Point(202, 135);
            this.txtMoneyInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyInput.Name = "txtMoneyInput";
            this.txtMoneyInput.Size = new System.Drawing.Size(465, 27);
            this.txtMoneyInput.TabIndex = 1;
            // 
            // lblDollorSign
            // 
            this.lblDollorSign.AutoSize = true;
            this.lblDollorSign.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDollorSign.Location = new System.Drawing.Point(169, 128);
            this.lblDollorSign.Name = "lblDollorSign";
            this.lblDollorSign.Size = new System.Drawing.Size(28, 35);
            this.lblDollorSign.TabIndex = 2;
            this.lblDollorSign.Text = "$";
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(381, 233);
            this.btnSumbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(86, 31);
            this.btnSumbit.TabIndex = 3;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 485);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(381, 427);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMoneyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.lblDollorSign);
            this.Controls.Add(this.txtMoneyInput);
            this.Controls.Add(this.lblWordsOutput);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMoneyWords";
            this.Text = "Money to Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordsOutput;
        private System.Windows.Forms.TextBox txtMoneyInput;
        private System.Windows.Forms.Label lblDollorSign;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

