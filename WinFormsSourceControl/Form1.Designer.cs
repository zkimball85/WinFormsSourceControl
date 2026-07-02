namespace WinFormsSourceControl
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
            label1 = new Label();
            label2 = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 72);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 158);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(219, 65);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(200, 39);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(219, 151);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(200, 39);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(97, 234);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(322, 92);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Area and Perimeter";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(163, 368);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(256, 39);
            txtArea.TabIndex = 5;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(163, 447);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(256, 39);
            txtPerimeter.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 544);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Area and Perimeter Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private TextBox txtArea;
        private TextBox txtPerimeter;
    }
}
