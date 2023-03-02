namespace Monopoly
{
    partial class Testing
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
            this.button = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(131, 39);
            this.button.TabIndex = 0;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 57);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(337, 381);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button);
            this.Name = "Testing";
            this.Text = "Testing Env.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}