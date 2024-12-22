namespace Client2
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
            cmbRequest = new ComboBox();
            btnRequest = new Button();
            label1 = new Label();
            txtResponse = new TextBox();
            SuspendLayout();
            // 
            // cmbRequest
            // 
            cmbRequest.FormattingEnabled = true;
            cmbRequest.Items.AddRange(new object[] { "date", "time" });
            cmbRequest.Location = new Point(320, 43);
            cmbRequest.Name = "cmbRequest";
            cmbRequest.Size = new Size(121, 23);
            cmbRequest.TabIndex = 0;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(320, 90);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(121, 23);
            btnRequest.TabIndex = 1;
            btnRequest.Text = "Запросити";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 172);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Запросити";
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(268, 190);
            txtResponse.Name = "txtResponse";
            txtResponse.ReadOnly = true;
            txtResponse.Size = new Size(213, 23);
            txtResponse.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResponse);
            Controls.Add(label1);
            Controls.Add(btnRequest);
            Controls.Add(cmbRequest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRequest;
        private Button btnRequest;
        private Label label1;
        private TextBox txtResponse;
    }
}
