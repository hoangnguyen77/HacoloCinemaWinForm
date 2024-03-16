using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacoloCinema_Team2
{
    public partial class frmH : Form
    {
        public frmH()
        {
            InitializeComponent();
            AddControlsToPanel();
        }
        private void AddControlsToPanel()
        {
            // Add some controls to the panel
            Panel my_panel = new Panel();
            VScrollBar vScroller = new VScrollBar();
            vScroller.Dock = DockStyle.Right;
            vScroller.Width = 30;
            vScroller.Height = 200;
            vScroller.Name = "VScrollBar2";
            my_panel.Controls.Add(vScroller);
        }

        private void frmH_Load(object sender, EventArgs e)
        {

        }

        
    }
}
