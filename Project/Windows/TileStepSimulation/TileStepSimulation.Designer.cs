namespace Monopoly
{
    partial class TileStepSimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileStepSimulation));
            this.groupBoxSimSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmountRounds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxPrisonTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxSimSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSimSettings
            // 
            this.groupBoxSimSettings.Controls.Add(this.textBoxPrisonTime);
            this.groupBoxSimSettings.Controls.Add(this.label3);
            this.groupBoxSimSettings.Controls.Add(this.textBoxAmountRounds);
            this.groupBoxSimSettings.Controls.Add(this.label1);
            this.groupBoxSimSettings.Location = new System.Drawing.Point(12, 214);
            this.groupBoxSimSettings.Name = "groupBoxSimSettings";
            this.groupBoxSimSettings.Size = new System.Drawing.Size(459, 89);
            this.groupBoxSimSettings.TabIndex = 0;
            this.groupBoxSimSettings.TabStop = false;
            this.groupBoxSimSettings.Text = "Simulation Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of rounds to play :";
            // 
            // textBoxAmountRounds
            // 
            this.textBoxAmountRounds.Location = new System.Drawing.Point(168, 26);
            this.textBoxAmountRounds.Name = "textBoxAmountRounds";
            this.textBoxAmountRounds.Size = new System.Drawing.Size(127, 20);
            this.textBoxAmountRounds.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tile Step Simulation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxDescription.Size = new System.Drawing.Size(446, 127);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // textBoxPrisonTime
            // 
            this.textBoxPrisonTime.Location = new System.Drawing.Point(168, 52);
            this.textBoxPrisonTime.Name = "textBoxPrisonTime";
            this.textBoxPrisonTime.Size = new System.Drawing.Size(127, 20);
            this.textBoxPrisonTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time in prison (rounds) :";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 309);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(459, 33);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run simulation";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // TileStepSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 680);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxSimSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TileStepSimulation";
            this.Load += new System.EventHandler(this.TileStepSimulation_Load);
            this.groupBoxSimSettings.ResumeLayout(false);
            this.groupBoxSimSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSimSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmountRounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrisonTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRun;
    }
}

