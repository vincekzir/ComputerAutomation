using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CAL_Activity1
{
    public partial class frmStarSign : Form
    {
        internal static string sName;
        internal static string sChar;

        public frmStarSign()
        {
            InitializeComponent();
        }

        private void starSignName_Enter(object sender, EventArgs e)
        {
            if (starSignName.Text == "Type in the name of the Star Sign")
            {
                starSignName.Text = "";
                starSignName.ForeColor = Color.Black;
            }
        }

        private void starSignName_Leave(object sender, EventArgs e)
        {
            if (starSignName.Text == "")
            {
                starSignName.Text = "Type in the name of the Star Sign";
                starSignName.ForeColor = Color.Silver;
            }
        }

        private void starSignChar_Enter(object sender, EventArgs e)
        {
            if (starSignChar.Text == "Type in this what Star Sign's main characteristics")
            {
                starSignChar.Text = "";
                starSignChar.ForeColor = Color.Black;
            }
        }

        private void starSignChar_Leave(object sender, EventArgs e)
        {
            if (starSignChar.Text == "")
            {
                starSignChar.Text = "Type in this what Star Sign's main characteristics";
                starSignChar.ForeColor = Color.Silver;
            }
        }

        public void showBtn_Click(object sender, EventArgs e)
        { 
            string sName = starSignName.Text;
            string sChar = starSignChar.Text;

            MessageBox.Show($"Star Sign: {sName} \n" +
                $"Star Characteristics: {sChar}", "Result"
            );  
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStarSign_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void frmStarSign_Activated(object sender, EventArgs e)
        {
            starSignChar.Text = "Type in this what Star Sign's main characteristics";
            starSignChar.ForeColor = Color.Silver;
            starSignName.Text = "Type in the name of the Star Sign";
            starSignName.ForeColor = Color.Silver;
            this.ActiveControl = null;
        }

        private void starSignName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn.PerformClick();
            }
        }

        private void starSignChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn.PerformClick();
            }
        }
    }
}
