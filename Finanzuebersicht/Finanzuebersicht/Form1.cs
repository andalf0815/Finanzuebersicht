using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzuebersicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Left = 25;
            Top = 25;
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Left = Left;
                button.Top = Top;
                panel_items.Controls.Add(button);
                Top += button.Height + 2;
            }
        }
    }
}
