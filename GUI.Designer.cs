
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
            ((System.ComponentModel.ISupportInitialize)(this.verticalOffsetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalOffsetSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(12, 82);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(442, 62);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Create Tracks";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // verticalOffsetSlider
            // 
            this.verticalOffsetSlider.Location = new System.Drawing.Point(103, 45);
            this.verticalOffsetSlider.Maximum = 500;
            this.verticalOffsetSlider.Minimum = -500;
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
            this.horizontalOffsetSlider.Maximum = 500;
            this.horizontalOffsetSlider.Minimum = -500;
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 156);
            this.Controls.Add(this.horizontalOffsetTextBox);
            this.Controls.Add(this.horizontalOffsetLabel);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.verticalOffsetSlider);
            this.Controls.Add(this.verticalOffsetLabel);
            this.Controls.Add(this.verticalOffsetTextBox);
            this.Controls.Add(this.horizontalOffsetSlider);
            this.Name = "GUI";
            this.Text = "NitroGuy\'s Chromatic Aberration";
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
    }
}

