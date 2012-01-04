using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output, fullname;
            fullname = textBoxFirstName.Text + " " + textBoxSurName.Text + " " + textBoxLastName.Text;
            output = "Информация за служителя:\r\n";
            output += "  Име: " + fullname + "\r\n";
            MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
