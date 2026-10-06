namespace Even_Getallen
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
            InputTextBox = new TextBox();
            BerekenButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Geef een geheel getal in:";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(154, 6);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 1;
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(12, 35);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(242, 23);
            BerekenButton.TabIndex = 2;
            BerekenButton.Text = "Bepaal even of oneven";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += BerekenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 74);
            Controls.Add(BerekenButton);
            Controls.Add(InputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InputTextBox;
        private Button BerekenButton;
    }
}
