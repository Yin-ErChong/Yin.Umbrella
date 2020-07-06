using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yin.Umbrella.CodeGenerator.Core;

namespace Yin.Umbrella.CodeGenerator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void EntityCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EntityCheck.Checked)
            {
                Template.Text = GeneratorFactory.GetGeneratorByName(GeneratorEnum.EntityGenerator)._templateText;
                //Template.AppendText(DTOCheck.Text + "\n");
            }
        }
        void DTOCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DTOCheck.Checked)
            {
                //Template.Text = GetGeneratorByName();
                // Template.AppendText(DTOCheck.Text + "\n");
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string _tableNmae = TableName.Text;
            GeneratorBase generator = GeneratorFactory.GetGeneratorByName(GeneratorEnum.EntityGenerator);
            generator.SetTableName(_tableNmae);
            Code.Text = generator.GetCode();
        }
    }
}
