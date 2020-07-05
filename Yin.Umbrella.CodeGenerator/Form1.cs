using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yin.Umbrella.CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void EntityCheckCheckedChanged(object sender, EventArgs e)
        {
            if (EntityCheck.Checked)
            {
                Template.AppendText(DTOCheck.Text + "\n");
            }
        }
        void DTOCheckCheckedChanged(object sender, EventArgs e)
        {
            if (DTOCheck.Checked)
            {
                Template.AppendText(DTOCheck.Text + "\n");
            }
        }
    }
}
