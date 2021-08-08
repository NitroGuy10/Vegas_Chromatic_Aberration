using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace Vegas_Chromatic_Aberration
{
    public partial class GUI : Form
    {
        public static GUI MainGUI;
        public static Vegas Vegas;

        public static Dictionary<string, RadioButton> channelButtons = new Dictionary<string, RadioButton>();
        
        public GUI()
        {
            InitializeComponent();

            new SettingControl(horizontalOffsetSlider, horizontalOffsetTextBox, 0.001, 0, "Horizontal Offset");
            new SettingControl(verticalOffsetSlider, verticalOffsetTextBox, 0.001, 0, "Vertical Offset");

            channelButtons["RED"] = redButton;
            channelButtons["GREEN"] = greenButton;
            channelButtons["BLUE"] = blueButton;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            ChromaticAberration.Apply();
            Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After choosing your settings and pressing \"Create Tracks\", the plugin will create 2 tracks (one for your target channel and one for the other channels) nested in a third parent channel. To apply to chromatic aberration effect to a clip, copy and paste that clip into BOTH nested tracks. Feel free to move the parent track around to your desired \"height\" in the timeline.");
        }

        private void horizontalOffsetSlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Horizontal Offset"))
            {
                SettingControl.SettingControls["Horizontal Offset"].UpdateFromSlider();
            }
        }

        private void horizontalOffsetTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Horizontal Offset"].UpdateFromTextBox();
                e.Handled = true;
            }
        }

        private void verticalOffsetSlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Vertical Offset"))
            {
                SettingControl.SettingControls["Vertical Offset"].UpdateFromSlider();
            }
        }
        private void verticalOffsetTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Vertical Offset"].UpdateFromTextBox();
                e.Handled = true;
            }
        }
    }
}
