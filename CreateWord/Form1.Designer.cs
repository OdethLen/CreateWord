namespace CreateWord
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
            btnSaveWord = new Button();
            txtDoc = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSaveWord
            // 
            btnSaveWord.Location = new Point(186, 223);
            btnSaveWord.Name = "btnSaveWord";
            btnSaveWord.Size = new Size(75, 23);
            btnSaveWord.TabIndex = 1;
            btnSaveWord.Text = "Save Word";
            btnSaveWord.UseVisualStyleBackColor = true;
            btnSaveWord.Click += btnSaveWord_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(79, 67);
            txtDoc.Multiline = true;
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(275, 135);
            txtDoc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 36);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Write";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 270);
            Controls.Add(label1);
            Controls.Add(txtDoc);
            Controls.Add(btnSaveWord);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSaveWord;
        private TextBox txtDoc;
        private Label label1;
    }
}
