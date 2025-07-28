using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgasiaBattleship
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        //closes rules
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButtonEnter(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close2.png";
        }
        private void CloseButtonLeave(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close.png";
        }
    }
}
