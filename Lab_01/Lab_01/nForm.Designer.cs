namespace Lab_01
{
    partial class nForm
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
            checkBoxClose = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBoxClose
            // 
            checkBoxClose.AutoSize = true;
            checkBoxClose.Location = new Point(637, 23);
            checkBoxClose.Name = "checkBoxClose";
            checkBoxClose.Size = new Size(129, 24);
            checkBoxClose.TabIndex = 0;
            checkBoxClose.Text = "checkBoxClose";
            checkBoxClose.UseVisualStyleBackColor = true;
            checkBoxClose.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(447, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBoxClose);
            Name = "nForm";
            Text = "nForm";
            FormClosing += nForm_FormClosing;
            Load += nForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxClose;
        private Button button1;
    }
}