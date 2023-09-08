using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL_Activity2
{
    public partial class frmApplicationForm : Form
    {
        public frmApplicationForm()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string userName = nameText.Text;
            string userDate = dateTimePicker.Value.ToString("dd/MM/yyy");
            string userPreference = comboBox.Text;

            MessageBox.Show($"NAME: {userName} \n" +
                $"DOB: {userDate} \n" +
                $"LIKES: {userPreference}", "Summary of your Application"
                );
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                applyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn.PerformClick();
            }
        }

        private void nameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                applyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn.PerformClick();
            }
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                applyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn.PerformClick();
            }
        }
    }
}
