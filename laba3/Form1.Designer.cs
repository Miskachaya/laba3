namespace laba3
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
            label = new Label();
            generateButton = new Button();
            aceptButton = new Button();
            textBox = new TextBox();
            labelColor = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.BackColor = Color.Linen;
            label.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(592, 110);
            label.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            generateButton.Location = new Point(396, 351);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(187, 87);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // aceptButton
            // 
            aceptButton.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            aceptButton.Location = new Point(12, 351);
            aceptButton.Name = "aceptButton";
            aceptButton.Size = new Size(271, 87);
            aceptButton.TabIndex = 2;
            aceptButton.Text = "Acept";
            aceptButton.UseVisualStyleBackColor = true;
            aceptButton.Click += aceptButton_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(12, 122);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(592, 145);
            textBox.TabIndex = 3;
            // 
            // labelColor
            // 
            labelColor.BackColor = Color.Yellow;
            labelColor.Location = new Point(623, 9);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(125, 429);
            labelColor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 450);
            Controls.Add(labelColor);
            Controls.Add(textBox);
            Controls.Add(aceptButton);
            Controls.Add(generateButton);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button generateButton;
        private Button aceptButton;
        private TextBox textBox;
        private Label labelColor;
    }
}