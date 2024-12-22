namespace Client
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
            txtInput = new TextBox();
            txtResponse = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(69, 86);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(296, 23);
            txtInput.TabIndex = 0;
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(408, 86);
            txtResponse.Name = "txtResponse";
            txtResponse.ReadOnly = true;
            txtResponse.Size = new Size(337, 23);
            txtResponse.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(326, 161);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(119, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Відправити";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtResponse);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtResponse;
        private Button btnSend;
    }
}
