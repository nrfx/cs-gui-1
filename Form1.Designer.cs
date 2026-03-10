namespace cs_gui_1
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
            textN = new TextBox();
            textBoxInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCalc = new Button();
            SuspendLayout();
            // 
            // textN
            // 
            textN.Location = new Point(12, 32);
            textN.Name = "textN";
            textN.Size = new Size(125, 27);
            textN.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(246, 32);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(237, 107);
            textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Число N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Числа";
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 14F);
            buttonCalc.Location = new Point(530, 42);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(226, 81);
            buttonCalc.TabIndex = 4;
            buttonCalc.Text = "Посчитать";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(textN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textN;
        private TextBox textBoxInput;
        private Label label1;
        private Label label2;
        private Button buttonCalc;
    }
}
