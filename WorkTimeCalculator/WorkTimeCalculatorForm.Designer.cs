namespace WorkTimeCalculator
{
    partial class WorkTimeCalculatorForm
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
            this.InInputFieldLabel = new System.Windows.Forms.Label();
            this.OutTimeTableLabel = new System.Windows.Forms.Label();
            this.InTimeTableInputText = new System.Windows.Forms.TextBox();
            this.OutTimeTableInputText = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InInputFieldLabel
            // 
            this.InInputFieldLabel.AutoSize = true;
            this.InInputFieldLabel.Location = new System.Drawing.Point(12, 9);
            this.InInputFieldLabel.Name = "InInputFieldLabel";
            this.InInputFieldLabel.Size = new System.Drawing.Size(80, 13);
            this.InInputFieldLabel.TabIndex = 0;
            this.InInputFieldLabel.Text = "\"In\" time table";
            // 
            // OutTimeTableLabel
            // 
            this.OutTimeTableLabel.AutoSize = true;
            this.OutTimeTableLabel.Location = new System.Drawing.Point(12, 146);
            this.OutTimeTableLabel.Name = "OutTimeTableLabel";
            this.OutTimeTableLabel.Size = new System.Drawing.Size(82, 13);
            this.OutTimeTableLabel.TabIndex = 1;
            this.OutTimeTableLabel.Text = "\"Out\" time table";
            // 
            // InTimeTableInputText
            // 
            this.InTimeTableInputText.AcceptsReturn = true;
            this.InTimeTableInputText.AcceptsTab = true;
            this.InTimeTableInputText.AllowDrop = true;
            this.InTimeTableInputText.Location = new System.Drawing.Point(15, 25);
            this.InTimeTableInputText.Multiline = true;
            this.InTimeTableInputText.Name = "InTimeTableInputText";
            this.InTimeTableInputText.Size = new System.Drawing.Size(261, 118);
            this.InTimeTableInputText.TabIndex = 2;
            this.InTimeTableInputText.WordWrap = false;
            this.InTimeTableInputText.TextChanged += new System.EventHandler(this.InTimeTableInputText_TextChanged);
            // 
            // OutTimeTableInputText
            // 
            this.OutTimeTableInputText.AcceptsReturn = true;
            this.OutTimeTableInputText.AcceptsTab = true;
            this.OutTimeTableInputText.AllowDrop = true;
            this.OutTimeTableInputText.Location = new System.Drawing.Point(15, 162);
            this.OutTimeTableInputText.Multiline = true;
            this.OutTimeTableInputText.Name = "OutTimeTableInputText";
            this.OutTimeTableInputText.Size = new System.Drawing.Size(261, 122);
            this.OutTimeTableInputText.TabIndex = 3;
            this.OutTimeTableInputText.WordWrap = false;
            this.OutTimeTableInputText.TextChanged += new System.EventHandler(this.OutTimeTableInputText_TextChanged);
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(12, 290);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(134, 38);
            this.ParseButton.TabIndex = 4;
            this.ParseButton.Text = "Parse shit";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.AcceptsReturn = true;
            this.OutputText.AcceptsTab = true;
            this.OutputText.AllowDrop = true;
            this.OutputText.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.OutputText.Location = new System.Drawing.Point(291, 25);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(396, 303);
            this.OutputText.TabIndex = 5;
            this.OutputText.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output";
            // 
            // WorkTimeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.OutTimeTableInputText);
            this.Controls.Add(this.InTimeTableInputText);
            this.Controls.Add(this.OutTimeTableLabel);
            this.Controls.Add(this.InInputFieldLabel);
            this.Name = "WorkTimeCalculatorForm";
            this.Text = "Wolololololol buggy calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InInputFieldLabel;
        private System.Windows.Forms.Label OutTimeTableLabel;
        private System.Windows.Forms.TextBox InTimeTableInputText;
        private System.Windows.Forms.TextBox OutTimeTableInputText;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label label1;
    }
}

