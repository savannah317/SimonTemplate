namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.marekLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.Location = new System.Drawing.Point(40, 149);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(110, 110);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.Location = new System.Drawing.Point(152, 149);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(110, 110);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redButton.Location = new System.Drawing.Point(152, 37);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(110, 110);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.Location = new System.Drawing.Point(40, 37);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(110, 110);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.Black;
            this.endButton.Enabled = false;
            this.endButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endButton.Location = new System.Drawing.Point(98, 265);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(95, 32);
            this.endButton.TabIndex = 4;
            this.endButton.Text = "Give Up?";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Visible = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // marekLabel
            // 
            this.marekLabel.AutoSize = true;
            this.marekLabel.BackColor = System.Drawing.Color.Transparent;
            this.marekLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marekLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marekLabel.Location = new System.Drawing.Point(145, 6);
            this.marekLabel.Name = "marekLabel";
            this.marekLabel.Size = new System.Drawing.Size(117, 21);
            this.marekLabel.TabIndex = 5;
            this.marekLabel.Text = "Marek Counter:";
            this.marekLabel.Visible = false;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.counterLabel.Location = new System.Drawing.Point(268, 6);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(19, 21);
            this.counterLabel.TabIndex = 6;
            this.counterLabel.Text = "#";
            this.counterLabel.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.marekLabel);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label marekLabel;
        private System.Windows.Forms.Label counterLabel;
    }
}
