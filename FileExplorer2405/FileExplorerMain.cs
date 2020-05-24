using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240520
{
    public partial class FileExplorerMain : Form
    {

        // undo
        // at first undo button will be invisible
        // after doing the undo - the button will be invisible again
        // if changed labelcolor (last action) then undo will restore the previous color
        // if changed bk color (last action) then undo will restore the previous color

        const int CHANGED_FORE_COLOR = 1;
        const int CHANGED_BK_COLOR = 2;

        public int last_action = 0;
        public Color save_last_color;

        public FileExplorerMain()
        {
            InitializeComponent();
        }

        private void myTrackBar_Scroll(object sender, EventArgs e)
        {
            int x = 1;

            Random rnd = new Random(); // new random generator

            // -- chinese
            // creates a variable named font with the parameters of: family, size
            Font font = new Font(colorLabel.Font.FontFamily, myTrackBar.Value + 14);

            //Font font2 = new Font(FontFamily.GenericSansSerif, FontStyle.Bold, FontStyle.Bold);

            colorLabel.Font = font;
        }

        private void colorChangerBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                // save panel background color before changing it
                save_last_color = colorLabel.ForeColor;
                undoBtn.Visible = true;
                last_action = CHANGED_FORE_COLOR;

                colorLabel.ForeColor = colorPicker.Color;

            }
        }

        private void changeBkColor_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                // save panel background color before changing it
                save_last_color = textPanel.BackColor;
                last_action = CHANGED_BK_COLOR;
                undoBtn.Visible = true;

                textPanel.BackColor = colorPicker.Color;

            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            switch (last_action)
            {
                case CHANGED_BK_COLOR:
                    textPanel.BackColor = save_last_color;
                    break;
                case CHANGED_FORE_COLOR:
                    colorLabel.ForeColor = save_last_color;
                    break;
            }
            undoBtn.Visible = false;
        }

        private void openImgFileBtn_Click(object sender, EventArgs e)
        {

            openFileDialog.Title = "Choose an Image file";

            openFileDialog.Filter = "Image files (*.jpg)| *.jpg|Bimap image (*.bmp)| *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show($"user chose: {openFileDialog.FileName}");

                Bitmap image_loaded_from_file = new Bitmap(openFileDialog.FileName);

                myPictureBox.Image = image_loaded_from_file;
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            myWebBrowser.Url = new Uri(urlTextBox.Text.ToString());
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browseBtn_Click(null, null);
            }
        }

        private void checkBox_Any_Changed(object sender, EventArgs e)
        {
            int percentage = 0;

            if (checkBox1.Checked)
            {
                percentage += 25;
            }

            if (checkBox2.Checked)
            {
                percentage += 25;
            }

            if (checkBox3.Checked)
            {
                percentage += 25;
            }

            if (checkBox4.Checked)
            {
                percentage += 25;
            }

            tasksProgressBar.Value = percentage;

            if (percentage == 100)
            {
                progrssLbl.Visible = true;
            }
            else
            {
                progrssLbl.Visible = false;
            }
        }
    }
}
