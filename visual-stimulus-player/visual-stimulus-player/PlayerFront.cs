using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_player
{
    public partial class PlayerFront : Form
    {
        public PlayerFront()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.SetMedia(new System.IO.FileInfo("d:/video/2.avi"));
            vlcControl1.Play();
        }
    }
}
