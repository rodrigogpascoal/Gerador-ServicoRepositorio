using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            var pathName = pathNameTxt.Text;
            var entityName = entityNameTxt.Text;
            var folderName = folderNameText.Text;
            AppCoreCreator.Create(pathName, entityName, folderName, addAppCoreFolder.Checked);
            InfrastructureeCreator.Create(pathName, entityName, folderName, addInfrafolder.Checked); ;

            string injectorText1 =  String.Format(WebTemplates.repositoryTemplate, entityName, entityName);
            string injectorText2 = String.Format(WebTemplates.serviceTemplate, entityName, entityName);


            labelResult.Text = "Adicionar ao SimpleInjectorContainer: \n" + injectorText1 + "\n" + injectorText2;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
