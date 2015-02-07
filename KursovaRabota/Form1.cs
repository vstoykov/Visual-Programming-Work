using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KursovaRabota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonAdd.Enabled = false;

            // Прави всички елементи невалидни
            this.textBoxFirstName.Tag = false;
            this.textBoxSurName.Tag = false;
            this.textBoxLastName.Tag = false;
            this.textBoxAge.Tag = false;
            this.groupBoxSex.Tag = false;
            this.groupBoxEducation.Tag = false;

            this.textBoxFirstName.Focus();

            // Задаване на новото местоположение на файла с данни
            this.data_file = Directory.GetCurrentDirectory() + "\\" + this.data_file;
            // Зареждане на стойностите от файла в listViewWorkers
            this.LoadWorkersFromFile();
        }

        private string data_file = "kursova_rabota.dat";

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] items = new string[]{
                                 this.textBoxFirstName.Text,
                                 this.textBoxSurName.Text,
                                 this.textBoxLastName.Text,
                                 this.addFormGetSex(),
                                 this.textBoxAge.Text,
                                 this.addFormGetEducation(),
                                 string.Join(", ", this.addFormGetLanguages())
                             };

            this.addNewWorker(items);
            this.clearAddForm();
            MessageBox.Show("Служителят е добавен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Връща списък от избраните езици
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

        private void addNewWorker(string[] items)
        {
            // Прехвърля записите от полтата в listViewWorkers

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
         
            lvi = new ListViewItem();
            // TODO: Оптимизиране на генерирането на новото ID
            lvi.Text = (this.listViewWorkers.Items.Count + 1).ToString();

            foreach (string item in items)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = item;
                lvi.SubItems.Add(lvsi);
            }

            this.listViewWorkers.Items.Add(lvi);
        }

        private void clearAddForm()
        {
            // Метод който нулира формата за добавяне на служител
            // за да в готова за добавяне на нов

            Color backcolor = System.Drawing.SystemColors.Window;

            this.textBoxFirstName.Clear();
            this.textBoxSurName.Clear();
            this.textBoxLastName.Clear();
            this.textBoxAge.Clear();
            this.textBoxFirstName.Focus();

            this.textBoxFirstName.BackColor = backcolor;
            this.textBoxSurName.BackColor = backcolor;
            this.textBoxLastName.BackColor = backcolor;
            this.textBoxAge.BackColor = backcolor;

            this.radioButtonMale.Checked = false;
            this.radioButtonFemale.Checked = false;

            this.radioButtonEducation1.Checked = false;
            this.radioButtonEducation2.Checked = false;
            this.radioButtonEducation3.Checked = false;
            this.radioButtonEducation4.Checked = false;
            this.radioButtonEducation5.Checked = false;

            this.checkBoxLangEn.Checked = false;
            this.checkBoxLangDe.Checked = false;
            this.checkBoxLangRu.Checked = false;
            this.checkBoxLangFr.Checked = false;
        }


        // Методи използвани за валидиране на формата

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.SaveWorkersToFile();
        }


        // Методи за записване в и зареждане от файл на информацията в listViewWorkers

        private void SaveWorkersToFile()
        {
			Int16 columns_count;
			FileStream stream = new FileStream(this.data_file, FileMode.Create);
			BinaryWriter writer = new BinaryWriter(stream);
			
			writer.Write((Int32)(this.listViewWorkers.Items.Count));
            
			foreach (ListViewItem lvi in this.listViewWorkers.Items)
            {
                columns_count = (Int16)(lvi.SubItems.Count - 1);
				
				writer.Write(columns_count);
				
				// Пропускане на първата колона и записване на всички останали
				for (int i = 1; i <= columns_count; i++){
					writer.Write(lvi.SubItems[i].Text.ToString());
				}
            }
			writer.Close();
        }

        private void LoadWorkersFromFile()
        {
            Int32 items_count;
			Int16 columns_count;
            List<string> columns;
			FileStream stream = new FileStream(this.data_file, FileMode.OpenOrCreate);
			BinaryReader reader = new BinaryReader(stream);

            this.listViewWorkers.Items.Clear();
            
            try
            {
				items_count = reader.ReadInt32();
            }
            catch (EndOfStreamException)
            {
                items_count = 0;
            }
			
            for (int i = 0; i < items_count; i++)
            {
                columns = new List<string>();
				columns_count = reader.ReadInt16();
				
                for (int ci = 0; ci < columns_count; ci++)
                {
					columns.Add(reader.ReadString());
                }
                this.addNewWorker(columns.ToArray());
            }
			reader.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sname = "", name = this.textBoxSearchName.Text;
            string ssex = "", sex = this.comboBoxSearchSex.Text;
            string seducation = "", education = this.comboBoxSearchEducation.Text;

            int counter;
            
            this.listViewSearchResults.Items.Clear();

            foreach (ListViewItem lvi in this.listViewWorkers.Items)
            {
                counter = 0;
                sname = "";
                foreach (ListViewItem.ListViewSubItem lvsi in lvi.SubItems)
                {
                    if ((new int[] { 1, 2, 3 }).Contains(counter))
                        sname += lvsi.Text + " ";
                    else if (counter == 4)
                        ssex = lvsi.Text;
                    else if (counter == 6)
                        seducation = lvsi.Text;
                    counter++;
                }
                ;
                if ((name == "" || sname.ToLower().Contains(name.ToLower())) &&
                    (sex == "" || sex.ToLower() == ssex.ToLower()) &&
                    (education == "" || education.ToLower() == seducation.ToLower()))
                {
                    this.listViewSearchResults.Items.Add((ListViewItem)lvi.Clone());
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.clearAddForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in this.listViewWorkers.SelectedItems)
            {
                lvi.Remove();
            }
            int counter = 1;
            foreach (ListViewItem lvi in this.listViewWorkers.Items)
            {
                lvi.Text = counter.ToString();
                counter++;
            }
        }

    }
}
