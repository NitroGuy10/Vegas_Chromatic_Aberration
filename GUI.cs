using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace Vegas_Chromatic_Aberration
{
    public partial class GUI : Form
    {
        public static GUI MainGUI;
        public static Vegas Vegas;

        public static Dictionary<string, CheckBox> channelBoxes = new Dictionary<string, CheckBox>();
        
        public GUI()
        {
            InitializeComponent();

            new SettingControl(horizontalOffsetSlider, horizontalOffsetTextBox, 0.001, 0, "Horizontal Offset");
            new SettingControl(verticalOffsetSlider, verticalOffsetTextBox, 0.001, 0, "Vertical Offset");

            channelBoxes["red"] = redBox;
            channelBoxes["green"] = greenBox;
            channelBoxes["blue"] = blueBox;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            int numChecked = 0;
            foreach (CheckBox box in channelBoxes.Values)
            {
                if (box.Checked)
                {
                    numChecked++;
                }
            }
            if (numChecked == 2)
            {
                ChromaticAberration.Apply();
                Close();
            }
            else
            {
                MessageBox.Show("Please choose only 2 channels");
            }
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
