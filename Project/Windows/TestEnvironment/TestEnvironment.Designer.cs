namespace Monopoly
{
    partial class TestEnvironment
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
            this.groupBoxMonopoly = new System.Windows.Forms.GroupBox();
            this.buttonRunMonopoly = new System.Windows.Forms.Button();
            this.groupBoxMonopoly.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMonopoly
            // 
            this.groupBoxMonopoly.Controls.Add(this.buttonRunMonopoly);
            this.groupBoxMonopoly.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMonopoly.Name = "groupBoxMonopoly";
            this.groupBoxMonopoly.Size = new System.Drawing.Size(259, 146);
            this.groupBoxMonopoly.TabIndex = 0;
            this.groupBoxMonopoly.TabStop = false;
            this.groupBoxMonopoly.Text = "Monopoly";
            // 
            // buttonRunMonopoly
            // 
            this.buttonRunMonopoly.Location = new System.Drawing.Point(13, 26);
            this.buttonRunMonopoly.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRunMonopoly.Name = "buttonRunMonopoly";
            this.buttonRunMonopoly.Size = new System.Drawing.Size(233, 32);
            this.buttonRunMonopoly.TabIndex = 0;
            this.buttonRunMonopoly.Text = "Run Monopoly";
            this.buttonRunMonopoly.UseVisualStyleBackColor = true;
            // 
            // TestEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.groupBoxMonopoly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestEnvironment";
            this.groupBoxMonopoly.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMonopoly;
        private System.Windows.Forms.Button buttonRunMonopoly;
    }
}