namespace Monopoly
{
    partial class SelectionWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSelections = new System.Windows.Forms.GroupBox();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonTestEnv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTileStep = new System.Windows.Forms.Button();
            this.groupBoxSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection Menu";
            // 
            // groupBoxSelections
            // 
            this.groupBoxSelections.Controls.Add(this.buttonCredits);
            this.groupBoxSelections.Controls.Add(this.buttonTestEnv);
            this.groupBoxSelections.Controls.Add(this.button2);
            this.groupBoxSelections.Controls.Add(this.buttonTileStep);
            this.groupBoxSelections.Location = new System.Drawing.Point(12, 58);
            this.groupBoxSelections.Name = "groupBoxSelections";
            this.groupBoxSelections.Size = new System.Drawing.Size(460, 326);
            this.groupBoxSelections.TabIndex = 1;
            this.groupBoxSelections.TabStop = false;
            this.groupBoxSelections.Text = "Selections";
            // 
            // buttonCredits
            // 
            this.buttonCredits.Location = new System.Drawing.Point(18, 259);
            this.buttonCredits.Margin = new System.Windows.Forms.Padding(15);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(424, 46);
            this.buttonCredits.TabIndex = 3;
            this.buttonCredits.Tag = "4";
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonTileStep_Click);
            // 
            // buttonTestEnv
            // 
            this.buttonTestEnv.Location = new System.Drawing.Point(18, 183);
            this.buttonTestEnv.Margin = new System.Windows.Forms.Padding(15);
            this.buttonTestEnv.Name = "buttonTestEnv";
            this.buttonTestEnv.Size = new System.Drawing.Size(424, 46);
            this.buttonTestEnv.TabIndex = 2;
            this.buttonTestEnv.Tag = "3";
            this.buttonTestEnv.Text = "Test Environment";
            this.buttonTestEnv.UseVisualStyleBackColor = true;
            this.buttonTestEnv.Click += new System.EventHandler(this.buttonTileStep_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(424, 46);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = "Monopoly Simulation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonTileStep_Click);
            // 
            // buttonTileStep
            // 
            this.buttonTileStep.Location = new System.Drawing.Point(18, 31);
            this.buttonTileStep.Margin = new System.Windows.Forms.Padding(15);
            this.buttonTileStep.Name = "buttonTileStep";
            this.buttonTileStep.Size = new System.Drawing.Size(424, 46);
            this.buttonTileStep.TabIndex = 0;
            this.buttonTileStep.Tag = "1";
            this.buttonTileStep.Text = "Tile Step Simulation";
            this.buttonTileStep.UseVisualStyleBackColor = true;
            this.buttonTileStep.Click += new System.EventHandler(this.buttonTileStep_Click);
            // 
            // SelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 396);
            this.Controls.Add(this.groupBoxSelections);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionWindow";
            this.ShowIcon = false;
            this.groupBoxSelections.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSelections;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonTestEnv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTileStep;
    }
}