
namespace history_negetive
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBeginDateMonth = new System.Windows.Forms.ComboBox();
            this.comboBeginDateDay = new System.Windows.Forms.ComboBox();
            this.comboBeginDateYear = new System.Windows.Forms.ComboBox();
            this.comboEndDateMonth = new System.Windows.Forms.ComboBox();
            this.comboEndDateDay = new System.Windows.Forms.ComboBox();
            this.comboEndDateYear = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(275, 230);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 2;
            // 
            // comboBeginDateMonth
            // 
            this.comboBeginDateMonth.FormattingEnabled = true;
            this.comboBeginDateMonth.Location = new System.Drawing.Point(186, 95);
            this.comboBeginDateMonth.Name = "comboBeginDateMonth";
            this.comboBeginDateMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBeginDateMonth.TabIndex = 3;
            // 
            // comboBeginDateDay
            // 
            this.comboBeginDateDay.FormattingEnabled = true;
            this.comboBeginDateDay.Location = new System.Drawing.Point(339, 95);
            this.comboBeginDateDay.Name = "comboBeginDateDay";
            this.comboBeginDateDay.Size = new System.Drawing.Size(121, 24);
            this.comboBeginDateDay.TabIndex = 4;
            // 
            // comboBeginDateYear
            // 
            this.comboBeginDateYear.FormattingEnabled = true;
            this.comboBeginDateYear.Location = new System.Drawing.Point(495, 95);
            this.comboBeginDateYear.Name = "comboBeginDateYear";
            this.comboBeginDateYear.Size = new System.Drawing.Size(121, 24);
            this.comboBeginDateYear.TabIndex = 5;
            // 
            // comboEndDateMonth
            // 
            this.comboEndDateMonth.FormattingEnabled = true;
            this.comboEndDateMonth.Location = new System.Drawing.Point(186, 137);
            this.comboEndDateMonth.Name = "comboEndDateMonth";
            this.comboEndDateMonth.Size = new System.Drawing.Size(121, 24);
            this.comboEndDateMonth.TabIndex = 6;
            // 
            // comboEndDateDay
            // 
            this.comboEndDateDay.FormattingEnabled = true;
            this.comboEndDateDay.Location = new System.Drawing.Point(339, 137);
            this.comboEndDateDay.Name = "comboEndDateDay";
            this.comboEndDateDay.Size = new System.Drawing.Size(121, 24);
            this.comboEndDateDay.TabIndex = 7;
            // 
            // comboEndDateYear
            // 
            this.comboEndDateYear.FormattingEnabled = true;
            this.comboEndDateYear.Location = new System.Drawing.Point(495, 137);
            this.comboEndDateYear.Name = "comboEndDateYear";
            this.comboEndDateYear.Size = new System.Drawing.Size(121, 24);
            this.comboEndDateYear.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(278, 307);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(182, 79);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate Difference";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboEndDateYear);
            this.Controls.Add(this.comboEndDateDay);
            this.Controls.Add(this.comboEndDateMonth);
            this.Controls.Add(this.comboBeginDateYear);
            this.Controls.Add(this.comboBeginDateDay);
            this.Controls.Add(this.comboBeginDateMonth);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Time Difference Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBeginDateMonth;
        private System.Windows.Forms.ComboBox comboBeginDateDay;
        private System.Windows.Forms.ComboBox comboBeginDateYear;
        private System.Windows.Forms.ComboBox comboEndDateMonth;
        private System.Windows.Forms.ComboBox comboEndDateDay;
        private System.Windows.Forms.ComboBox comboEndDateYear;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

