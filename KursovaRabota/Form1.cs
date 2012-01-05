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
            this.buttonAdd.Enabled = false;

            // Make all tags invalid
            this.textBoxFirstName.Tag = false;
            this.textBoxSurName.Tag = false;
            this.textBoxLastName.Tag = false;
            this.textBoxAge.Tag = false;
            this.groupBoxSex.Tag = false;
            this.groupBoxEducation.Tag = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.addNewWorker();

            string output, fullname;
            fullname = textBoxFirstName.Text + " " + textBoxSurName.Text + " " + textBoxLastName.Text;
            output = "Информация за служителя:\r\n";
            output += "  Име: " + fullname + "\r\n";
            MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private string addFormGetSex()
        {
            if (this.radioButtonMale.Checked)
                return "Мъж";
            else if (this.radioButtonFemale.Checked)
                return "Жена";
            else
                return "N/A";
        }

        private string addFormGetEducation()
        {
            if (this.radioButtonEducation1.Checked)
                return "Начално";
            else if (this.radioButtonEducation2.Checked)
                return "Основно";
            else if (this.radioButtonEducation3.Checked)
                return "Средно";
            else if (this.radioButtonEducation4.Checked)
                return "Бакалавър";
            else if (this.radioButtonEducation5.Checked)
                return "Магистър";
            else
                return "N/A";
        }

        private List<string> addFormGetLanguages()
        {
            List<string> languages = new List<string>();

            if (this.checkBoxLangEn.Checked)
                languages.Add("Английски");
            if (this.checkBoxLangDe.Checked)
                languages.Add("Немски");
            if (this.checkBoxLangRu.Checked)
                languages.Add("Руски");
            if (this.checkBoxLangFr.Checked)
                languages.Add("Френски");

            return languages;
        }

        private string  addFormGetLanguagesText()
        {
            StringBuilder builder = new StringBuilder();
            string delimiter = "";
            foreach (string item in this.addFormGetLanguages())
            {
                builder.Append(delimiter);
                builder.Append(item);
                delimiter = ", ";
            }
            return builder.ToString();
        }


        private void validateAddForm()
        {
            if (textBoxFirstName.Text != "")
                textBoxFirstName.Tag = true;
        }

        private bool ValidateOk()
        {
            // Активира бутона "Добави", ако стойностите
            // на всички свойства Tag са True.
            this.buttonAdd.Enabled =
                ((bool)(this.textBoxFirstName.Tag)
                    && (bool)(this.textBoxSurName.Tag)
                    && (bool)(this.textBoxLastName.Tag)
                    && (bool)(this.textBoxAge.Tag)
                    && (bool)(this.groupBoxSex.Tag) 
                    && (bool)(this.groupBoxEducation.Tag)
                );
            return this.buttonAdd.Enabled;
        }

        private void addNewWorker()
        {
            // Прехвърля записите от полтата в listViewWorkers

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            lvi = new ListViewItem();
            lvi.Text = textBoxFirstName.Text;

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = textBoxSurName.Text;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = textBoxLastName.Text;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = this.addFormGetSex();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = textBoxAge.Text;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = this.addFormGetEducation();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = this.addFormGetLanguagesText();
            lvi.SubItems.Add(lvsi);

            this.listViewWorkers.Items.Add(lvi);
        }


        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private bool textBoxEmptyValidateOk(TextBox tb)
        {
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            return this.ValidateOk();
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            this.textBoxEmptyValidateOk((TextBox)sender);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.textBoxEmptyValidateOk((TextBox)sender);
        }

        private void radioButtonSex_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxSex.Tag = (this.addFormGetSex() != "N/A");
            this.ValidateOk();
        }

        private void radioButtonEducation_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxEducation.Tag = (this.addFormGetEducation() != "N/A");
            this.ValidateOk();
        }

    }
}
