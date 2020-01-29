using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class FrmAddGenre : Form
    {
        public FrmAddGenre()
        {
            InitializeComponent();
        }



        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAddGenre frm = new FrmAddGenre())
            {
                frm.ShowDialog();
            }
        }
    }
}
