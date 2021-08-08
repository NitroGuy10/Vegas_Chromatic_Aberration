
namespace Vegas_Chromatic_Aberration
{
    partial class GUI
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.verticalOffsetSlider = new System.Windows.Forms.TrackBar();
            this.verticalOffsetTextBox = new System.Windows.Forms.TextBox();
            this.verticalOffsetLabel = new System.Windows.Forms.Label();
            this.horizontalOffsetLabel = new System.Windows.Forms.Label();
            this.horizontalOffsetSlider = new System.Windows.Forms.TrackBar();
            this.horizontalOffsetTextBox = new System.Windows.Forms.TextBox();
            this.offsetChannelsLabel = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verticalOffsetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalOffsetSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(103, 118);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(351, 62);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Create Tracks";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // verticalOffsetSlider
            // 
            this.verticalOffsetSlider.Location = new System.Drawing.Point(103, 45);
            this.verticalOffsetSlider.Maximum = 50;
            this.verticalOffsetSlider.Minimum = -50;
            this.verticalOffsetSlider.Name = "verticalOffsetSlider";
            this.verticalOffsetSlider.Size = new System.Drawing.Size(245, 45);
            this.verticalOffsetSlider.TabIndex = 1;
            this.verticalOffsetSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.verticalOffsetSlider.Scroll += new System.EventHandler(this.verticalOffsetSlider_Scroll);
            // 
            // verticalOffsetTextBox
            // 
            this.verticalOffsetTextBox.Location = new System.Drawing.Point(354, 45);
            this.verticalOffsetTextBox.Name = "verticalOffsetTextBox";
            this.verticalOffsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.verticalOffsetTextBox.TabIndex = 2;
            this.verticalOffsetTextBox.Text = "0";
            this.verticalOffsetTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verticalOffsetTextBox_KeyDown);
            // 
            // verticalOffsetLabel
            // 
            this.verticalOffsetLabel.AutoSize = true;
            this.verticalOffsetLabel.Location = new System.Drawing.Point(24, 48);
            this.verticalOffsetLabel.Name = "verticalOffsetLabel";
            this.verticalOffsetLabel.Size = new System.Drawing.Size(73, 13);
            this.verticalOffsetLabel.TabIndex = 3;
            this.verticalOffsetLabel.Text = "Vertical Offset";
            // 
            // horizontalOffsetLabel
            // 
            this.horizontalOffsetLabel.AutoSize = true;
            this.horizontalOffsetLabel.Location = new System.Drawing.Point(12, 18);
            this.horizontalOffsetLabel.Name = "horizontalOffsetLabel";
            this.horizontalOffsetLabel.Size = new System.Drawing.Size(85, 13);
            this.horizontalOffsetLabel.TabIndex = 4;
            this.horizontalOffsetLabel.Text = "Horizontal Offset";
            // 
            // horizontalOffsetSlider
            // 
            this.horizontalOffsetSlider.Location = new System.Drawing.Point(103, 16);
            this.horizontalOffsetSlider.Maximum = 50;
            this.horizontalOffsetSlider.Minimum = -50;
            this.horizontalOffsetSlider.Name = "horizontalOffsetSlider";
            this.horizontalOffsetSlider.Size = new System.Drawing.Size(245, 45);
            this.horizontalOffsetSlider.TabIndex = 5;
            this.horizontalOffsetSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalOffsetSlider.Scroll += new System.EventHandler(this.horizontalOffsetSlider_Scroll);
            // 
            // horizontalOffsetTextBox
            // 
            this.horizontalOffsetTextBox.Location = new System.Drawing.Point(354, 16);
            this.horizontalOffsetTextBox.Name = "horizontalOffsetTextBox";
            this.horizontalOffsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.horizontalOffsetTextBox.TabIndex = 6;
            this.horizontalOffsetTextBox.Text = "0";
            this.horizontalOffsetTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.horizontalOffsetTextBox_KeyDown);
            // 
            // offsetChannelsLabel
            // 
            this.offsetChannelsLabel.AutoSize = true;
            this.offsetChannelsLabel.Location = new System.Drawing.Point(17, 78);
            this.offsetChannelsLabel.Name = "offsetChannelsLabel";
            this.offsetChannelsLabel.Size = new System.Drawing.Size(80, 13);
            this.offsetChannelsLabel.TabIndex = 7;
            this.offsetChannelsLabel.Text = "Target Channel";
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Checked = true;
            this.redButton.Location = new System.Drawing.Point(117, 76);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 12;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(206, 76);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 13;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(302, 76);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 14;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(15, 118);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(82, 62);
            this.helpBtn.TabIndex = 15;
            this.helpBtn.Text = "How to Use";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 192);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.offsetChannelsLabel);
            this.Controls.Add(this.horizontalOffsetTextBox);
            this.Controls.Add(this.horizontalOffsetLabel);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.verticalOffsetSlider);
            this.Controls.Add(this.verticalOffsetLabel);
            this.Controls.Add(this.verticalOffsetTextBox);
            this.Controls.Add(this.horizontalOffsetSlider);
            this.Name = "GUI";
            this.Text = "NitroGuy\'s Chromatic Aberration (v1.0)";
            ((System.ComponentModel.ISupportInitialize)(this.verticalOffsetSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalOffsetSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TrackBar verticalOffsetSlider;
        private System.Windows.Forms.TextBox verticalOffsetTextBox;
        private System.Windows.Forms.Label verticalOffsetLabel;
        private System.Windows.Forms.Label horizontalOffsetLabel;
        private System.Windows.Forms.TrackBar horizontalOffsetSlider;
        private System.Windows.Forms.TextBox horizontalOffsetTextBox;
        private System.Windows.Forms.Label offsetChannelsLabel;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.Button helpBtn;
    }
}

