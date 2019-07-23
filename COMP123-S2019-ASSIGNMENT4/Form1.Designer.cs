namespace COMP123_S2019_ASSIGNMENT4
{
    partial class BMICalculatorApp
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
            this.DepatmentOfHealth = new System.Windows.Forms.TableLayoutPanel();
            this.theResult = new System.Windows.Forms.Label();
            this.scaleTextbox = new System.Windows.Forms.TextBox();
            this.scale = new System.Windows.Forms.Label();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.DepatmentOfHealth.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepatmentOfHealth
            // 
            this.DepatmentOfHealth.AccessibleName = "";
            this.DepatmentOfHealth.ColumnCount = 2;
            this.DepatmentOfHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DepatmentOfHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DepatmentOfHealth.Controls.Add(this.theResult, 1, 0);
            this.DepatmentOfHealth.Controls.Add(this.scale, 0, 0);
            this.DepatmentOfHealth.Controls.Add(this.resultTextbox, 1, 1);
            this.DepatmentOfHealth.Controls.Add(this.scaleTextbox, 0, 1);
            this.DepatmentOfHealth.Location = new System.Drawing.Point(72, 439);
            this.DepatmentOfHealth.Name = "DepatmentOfHealth";
            this.DepatmentOfHealth.RowCount = 2;
            this.DepatmentOfHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.DepatmentOfHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.42105F));
            this.DepatmentOfHealth.Size = new System.Drawing.Size(492, 196);
            this.DepatmentOfHealth.TabIndex = 0;
            // 
            // theResult
            // 
            this.theResult.AutoSize = true;
            this.theResult.Location = new System.Drawing.Point(249, 0);
            this.theResult.Name = "theResult";
            this.theResult.Size = new System.Drawing.Size(133, 46);
            this.theResult.TabIndex = 1;
            this.theResult.Text = "Result";
            // 
            // scaleTextbox
            // 
            this.scaleTextbox.Enabled = false;
            this.scaleTextbox.Location = new System.Drawing.Point(3, 107);
            this.scaleTextbox.Name = "scaleTextbox";
            this.scaleTextbox.Size = new System.Drawing.Size(240, 53);
            this.scaleTextbox.TabIndex = 2;
            // 
            // scale
            // 
            this.scale.AutoSize = true;
            this.scale.Location = new System.Drawing.Point(3, 0);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(202, 46);
            this.scale.TabIndex = 0;
            this.scale.Text = "BMI Scale";
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(249, 107);
            this.resultTextbox.Multiline = true;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(240, 53);
            this.resultTextbox.TabIndex = 3;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(102, 41);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(185, 50);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(333, 41);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(154, 50);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(36, 133);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(199, 46);
            this.MyHeightLabel.TabIndex = 3;
            this.MyHeightLabel.Text = "My Height";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(322, 133);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(322, 53);
            this.Height.TabIndex = 4;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(27, 216);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(208, 46);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(322, 216);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(322, 53);
            this.Weight.TabIndex = 6;
            this.Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_KeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(44, 333);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(386, 58);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "CalculateBMIButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Bisque;
            this.result.Enabled = false;
            this.result.ForeColor = System.Drawing.Color.Cornsilk;
            this.result.Location = new System.Drawing.Point(469, 333);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(175, 53);
            this.result.TabIndex = 8;
            // 
            // BMICalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 975);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.DepatmentOfHealth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculatorApp_Load);
            this.DepatmentOfHealth.ResumeLayout(false);
            this.DepatmentOfHealth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DepatmentOfHealth;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label scale;
        private System.Windows.Forms.Label theResult;
        private System.Windows.Forms.TextBox scaleTextbox;
        private System.Windows.Forms.TextBox resultTextbox;
    }
}

