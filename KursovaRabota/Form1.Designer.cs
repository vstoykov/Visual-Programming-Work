namespace KursovaRabota
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Венелин",
            "Красимиров",
            "Стойков",
            "М",
            "24",
            "Магистър",
            "Английски"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Венелин",
            "Красимиров",
            "Стойков",
            "М",
            "24",
            "Магистър",
            "Английски"}, -1);
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.radioButtonEducation5 = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation4 = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation3 = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation2 = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation1 = new System.Windows.Forms.RadioButton();
            this.groupBoxLanguages = new System.Windows.Forms.GroupBox();
            this.checkBoxLangFr = new System.Windows.Forms.CheckBox();
            this.checkBoxLangRu = new System.Windows.Forms.CheckBox();
            this.checkBoxLangDe = new System.Windows.Forms.CheckBox();
            this.checkBoxLangEn = new System.Windows.Forms.CheckBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.tabControlWorkers = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewWorkers = new System.Windows.Forms.ListView();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEducation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLanguages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainerSearch = new System.Windows.Forms.SplitContainer();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSearchResults = new System.Windows.Forms.ListView();
            this.splitContainerPreview = new System.Windows.Forms.SplitContainer();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxSearchSex = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchEducation = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSex.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.groupBoxLanguages.SuspendLayout();
            this.tabControlWorkers.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).BeginInit();
            this.splitContainerSearch.Panel1.SuspendLayout();
            this.splitContainerSearch.Panel2.SuspendLayout();
            this.splitContainerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).BeginInit();
            this.splitContainerPreview.Panel1.SuspendLayout();
            this.splitContainerPreview.Panel2.SuspendLayout();
            this.splitContainerPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(72, 27);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(72, 54);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(200, 20);
            this.textBoxSurName.TabIndex = 1;
            this.textBoxSurName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(72, 80);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Location = new System.Drawing.Point(72, 106);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(200, 79);
            this.groupBoxSex.TabIndex = 3;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Пол";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(7, 44);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonSex_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonSex_CheckedChanged);
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEducation.Controls.Add(this.radioButtonEducation5);
            this.groupBoxEducation.Controls.Add(this.radioButtonEducation4);
            this.groupBoxEducation.Controls.Add(this.radioButtonEducation3);
            this.groupBoxEducation.Controls.Add(this.radioButtonEducation2);
            this.groupBoxEducation.Controls.Add(this.radioButtonEducation1);
            this.groupBoxEducation.Location = new System.Drawing.Point(290, 27);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(223, 139);
            this.groupBoxEducation.TabIndex = 4;
            this.groupBoxEducation.TabStop = false;
            this.groupBoxEducation.Text = "Образование";
            // 
            // radioButtonEducation5
            // 
            this.radioButtonEducation5.AutoSize = true;
            this.radioButtonEducation5.Location = new System.Drawing.Point(7, 116);
            this.radioButtonEducation5.Name = "radioButtonEducation5";
            this.radioButtonEducation5.Size = new System.Drawing.Size(111, 17);
            this.radioButtonEducation5.TabIndex = 4;
            this.radioButtonEducation5.TabStop = true;
            this.radioButtonEducation5.Text = "Висше Магистър";
            this.radioButtonEducation5.UseVisualStyleBackColor = true;
            this.radioButtonEducation5.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // radioButtonEducation4
            // 
            this.radioButtonEducation4.AutoSize = true;
            this.radioButtonEducation4.Location = new System.Drawing.Point(7, 92);
            this.radioButtonEducation4.Name = "radioButtonEducation4";
            this.radioButtonEducation4.Size = new System.Drawing.Size(117, 17);
            this.radioButtonEducation4.TabIndex = 3;
            this.radioButtonEducation4.TabStop = true;
            this.radioButtonEducation4.Text = "Висше Бакалавър";
            this.radioButtonEducation4.UseVisualStyleBackColor = true;
            this.radioButtonEducation4.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // radioButtonEducation3
            // 
            this.radioButtonEducation3.AutoSize = true;
            this.radioButtonEducation3.Location = new System.Drawing.Point(7, 68);
            this.radioButtonEducation3.Name = "radioButtonEducation3";
            this.radioButtonEducation3.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEducation3.TabIndex = 2;
            this.radioButtonEducation3.TabStop = true;
            this.radioButtonEducation3.Text = "Средно";
            this.radioButtonEducation3.UseVisualStyleBackColor = true;
            this.radioButtonEducation3.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // radioButtonEducation2
            // 
            this.radioButtonEducation2.AutoSize = true;
            this.radioButtonEducation2.Location = new System.Drawing.Point(7, 44);
            this.radioButtonEducation2.Name = "radioButtonEducation2";
            this.radioButtonEducation2.Size = new System.Drawing.Size(69, 17);
            this.radioButtonEducation2.TabIndex = 1;
            this.radioButtonEducation2.TabStop = true;
            this.radioButtonEducation2.Text = "Основно";
            this.radioButtonEducation2.UseVisualStyleBackColor = true;
            this.radioButtonEducation2.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // radioButtonEducation1
            // 
            this.radioButtonEducation1.AutoSize = true;
            this.radioButtonEducation1.Location = new System.Drawing.Point(7, 20);
            this.radioButtonEducation1.Name = "radioButtonEducation1";
            this.radioButtonEducation1.Size = new System.Drawing.Size(68, 17);
            this.radioButtonEducation1.TabIndex = 0;
            this.radioButtonEducation1.TabStop = true;
            this.radioButtonEducation1.Text = "Начално";
            this.radioButtonEducation1.UseVisualStyleBackColor = true;
            this.radioButtonEducation1.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // groupBoxLanguages
            // 
            this.groupBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLanguages.Controls.Add(this.checkBoxLangFr);
            this.groupBoxLanguages.Controls.Add(this.checkBoxLangRu);
            this.groupBoxLanguages.Controls.Add(this.checkBoxLangDe);
            this.groupBoxLanguages.Controls.Add(this.checkBoxLangEn);
            this.groupBoxLanguages.Location = new System.Drawing.Point(290, 172);
            this.groupBoxLanguages.Name = "groupBoxLanguages";
            this.groupBoxLanguages.Size = new System.Drawing.Size(223, 120);
            this.groupBoxLanguages.TabIndex = 5;
            this.groupBoxLanguages.TabStop = false;
            this.groupBoxLanguages.Text = "Чужди Езици";
            // 
            // checkBoxLangFr
            // 
            this.checkBoxLangFr.AutoSize = true;
            this.checkBoxLangFr.Location = new System.Drawing.Point(7, 92);
            this.checkBoxLangFr.Name = "checkBoxLangFr";
            this.checkBoxLangFr.Size = new System.Drawing.Size(73, 17);
            this.checkBoxLangFr.TabIndex = 3;
            this.checkBoxLangFr.Text = "Френски";
            this.checkBoxLangFr.UseVisualStyleBackColor = true;
            // 
            // checkBoxLangRu
            // 
            this.checkBoxLangRu.AutoSize = true;
            this.checkBoxLangRu.Location = new System.Drawing.Point(7, 68);
            this.checkBoxLangRu.Name = "checkBoxLangRu";
            this.checkBoxLangRu.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLangRu.TabIndex = 2;
            this.checkBoxLangRu.Text = "Руски";
            this.checkBoxLangRu.UseVisualStyleBackColor = true;
            // 
            // checkBoxLangDe
            // 
            this.checkBoxLangDe.AutoSize = true;
            this.checkBoxLangDe.Location = new System.Drawing.Point(7, 44);
            this.checkBoxLangDe.Name = "checkBoxLangDe";
            this.checkBoxLangDe.Size = new System.Drawing.Size(66, 17);
            this.checkBoxLangDe.TabIndex = 1;
            this.checkBoxLangDe.Text = "Немски";
            this.checkBoxLangDe.UseVisualStyleBackColor = true;
            // 
            // checkBoxLangEn
            // 
            this.checkBoxLangEn.AutoSize = true;
            this.checkBoxLangEn.Location = new System.Drawing.Point(7, 20);
            this.checkBoxLangEn.Name = "checkBoxLangEn";
            this.checkBoxLangEn.Size = new System.Drawing.Size(80, 17);
            this.checkBoxLangEn.TabIndex = 0;
            this.checkBoxLangEn.Text = "Английски";
            this.checkBoxLangEn.UseVisualStyleBackColor = true;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(37, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "Име";
            // 
            // labelSurName
            // 
            this.labelSurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurName.AutoSize = true;
            this.labelSurName.Location = new System.Drawing.Point(13, 57);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(53, 13);
            this.labelSurName.TabIndex = 7;
            this.labelSurName.Text = "Презиме";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 83);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Фамилия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(523, 287);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(72, 204);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 10;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // labelAge
            // 
            this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(16, 208);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 13);
            this.labelAge.TabIndex = 11;
            this.labelAge.Text = "Възраст";
            // 
            // tabControlWorkers
            // 
            this.tabControlWorkers.Controls.Add(this.tabPageAdd);
            this.tabControlWorkers.Controls.Add(this.tabPageView);
            this.tabControlWorkers.Controls.Add(this.tabPageSearch);
            this.tabControlWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWorkers.Location = new System.Drawing.Point(0, 0);
            this.tabControlWorkers.Name = "tabControlWorkers";
            this.tabControlWorkers.SelectedIndex = 0;
            this.tabControlWorkers.Size = new System.Drawing.Size(614, 342);
            this.tabControlWorkers.TabIndex = 12;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Controls.Add(this.groupBoxEducation);
            this.tabPageAdd.Controls.Add(this.textBoxAge);
            this.tabPageAdd.Controls.Add(this.labelAge);
            this.tabPageAdd.Controls.Add(this.textBoxFirstName);
            this.tabPageAdd.Controls.Add(this.textBoxSurName);
            this.tabPageAdd.Controls.Add(this.textBoxLastName);
            this.tabPageAdd.Controls.Add(this.groupBoxSex);
            this.tabPageAdd.Controls.Add(this.groupBoxLanguages);
            this.tabPageAdd.Controls.Add(this.labelLastName);
            this.tabPageAdd.Controls.Add(this.labelFirstName);
            this.tabPageAdd.Controls.Add(this.labelSurName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(606, 316);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Добави";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.splitContainerPreview);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(606, 316);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "Прегледай";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(522, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listViewWorkers
            // 
            this.listViewWorkers.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewWorkers.AllowColumnReorder = true;
            this.listViewWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnSurname,
            this.columnLastName,
            this.columnSex,
            this.columnAge,
            this.columnEducation,
            this.columnLanguages});
            this.listViewWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWorkers.FullRowSelect = true;
            this.listViewWorkers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewWorkers.Location = new System.Drawing.Point(0, 0);
            this.listViewWorkers.Name = "listViewWorkers";
            this.listViewWorkers.ShowGroups = false;
            this.listViewWorkers.Size = new System.Drawing.Size(600, 275);
            this.listViewWorkers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewWorkers.TabIndex = 0;
            this.listViewWorkers.UseCompatibleStateImageBehavior = false;
            this.listViewWorkers.View = System.Windows.Forms.View.Details;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "Име";
            this.columnFirstName.Width = 82;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Презиме";
            this.columnSurname.Width = 96;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Фамилия";
            this.columnLastName.Width = 89;
            // 
            // columnSex
            // 
            this.columnSex.Text = "Пол";
            this.columnSex.Width = 54;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Възраст";
            // 
            // columnEducation
            // 
            this.columnEducation.Text = "Образование";
            this.columnEducation.Width = 80;
            // 
            // columnLanguages
            // 
            this.columnLanguages.Text = "Езици";
            this.columnLanguages.Width = 128;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.splitContainerSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(606, 316);
            this.tabPageSearch.TabIndex = 2;
            this.tabPageSearch.Text = "Търси";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 30;
            // 
            // splitContainerSearch
            // 
            this.splitContainerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSearch.Location = new System.Drawing.Point(3, 3);
            this.splitContainerSearch.Name = "splitContainerSearch";
            this.splitContainerSearch.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSearch.Panel1
            // 
            this.splitContainerSearch.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainerSearch.Panel1.Controls.Add(this.comboBoxSearchEducation);
            this.splitContainerSearch.Panel1.Controls.Add(this.comboBoxSearchSex);
            this.splitContainerSearch.Panel1.Controls.Add(this.labelName);
            this.splitContainerSearch.Panel1.Controls.Add(this.textBoxSearchName);
            // 
            // splitContainerSearch.Panel2
            // 
            this.splitContainerSearch.Panel2.Controls.Add(this.listViewSearchResults);
            this.splitContainerSearch.Size = new System.Drawing.Size(600, 310);
            this.splitContainerSearch.SplitterDistance = 32;
            this.splitContainerSearch.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Име";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Презиме";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фамилия";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Пол";
            this.columnHeader5.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Възраст";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Образование";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Езици";
            this.columnHeader8.Width = 128;
            // 
            // listViewSearchResults
            // 
            this.listViewSearchResults.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewSearchResults.AllowColumnReorder = true;
            this.listViewSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSearchResults.FullRowSelect = true;
            this.listViewSearchResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewSearchResults.Location = new System.Drawing.Point(0, 0);
            this.listViewSearchResults.Name = "listViewSearchResults";
            this.listViewSearchResults.ShowGroups = false;
            this.listViewSearchResults.Size = new System.Drawing.Size(600, 274);
            this.listViewSearchResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSearchResults.TabIndex = 1;
            this.listViewSearchResults.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResults.View = System.Windows.Forms.View.Details;
            // 
            // splitContainerPreview
            // 
            this.splitContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPreview.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPreview.Name = "splitContainerPreview";
            this.splitContainerPreview.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPreview.Panel1
            // 
            this.splitContainerPreview.Panel1.Controls.Add(this.listViewWorkers);
            // 
            // splitContainerPreview.Panel2
            // 
            this.splitContainerPreview.Panel2.Controls.Add(this.buttonSave);
            this.splitContainerPreview.Size = new System.Drawing.Size(600, 310);
            this.splitContainerPreview.SplitterDistance = 275;
            this.splitContainerPreview.TabIndex = 2;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(76, 4);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(142, 20);
            this.textBoxSearchName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име";
            // 
            // comboBoxSearchSex
            // 
            this.comboBoxSearchSex.AutoCompleteCustomSource.AddRange(new string[] {
            "Мъж",
            "Жена"});
            this.comboBoxSearchSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSearchSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchSex.FormattingEnabled = true;
            this.comboBoxSearchSex.Items.AddRange(new object[] {
            "Мъж",
            "Жена"});
            this.comboBoxSearchSex.Location = new System.Drawing.Point(224, 4);
            this.comboBoxSearchSex.Name = "comboBoxSearchSex";
            this.comboBoxSearchSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchSex.TabIndex = 2;
            // 
            // comboBoxSearchEducation
            // 
            this.comboBoxSearchEducation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchEducation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchEducation.FormattingEnabled = true;
            this.comboBoxSearchEducation.Items.AddRange(new object[] {
            "Начално",
            "Основно",
            "Средно",
            "Бакалавър",
            "Магистър"});
            this.comboBoxSearchEducation.Location = new System.Drawing.Point(351, 4);
            this.comboBoxSearchEducation.Name = "comboBoxSearchEducation";
            this.comboBoxSearchEducation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchEducation.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(520, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 342);
            this.Controls.Add(this.tabControlWorkers);
            this.MinimumSize = new System.Drawing.Size(630, 380);
            this.Name = "Form1";
            this.Text = "Фирмени Работници";
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.groupBoxEducation.ResumeLayout(false);
            this.groupBoxEducation.PerformLayout();
            this.groupBoxLanguages.ResumeLayout(false);
            this.groupBoxLanguages.PerformLayout();
            this.tabControlWorkers.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.splitContainerSearch.Panel1.ResumeLayout(false);
            this.splitContainerSearch.Panel1.PerformLayout();
            this.splitContainerSearch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).EndInit();
            this.splitContainerSearch.ResumeLayout(false);
            this.splitContainerPreview.Panel1.ResumeLayout(false);
            this.splitContainerPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).EndInit();
            this.splitContainerPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.GroupBox groupBoxEducation;
        private System.Windows.Forms.RadioButton radioButtonEducation5;
        private System.Windows.Forms.RadioButton radioButtonEducation4;
        private System.Windows.Forms.RadioButton radioButtonEducation3;
        private System.Windows.Forms.RadioButton radioButtonEducation2;
        private System.Windows.Forms.RadioButton radioButtonEducation1;
        private System.Windows.Forms.GroupBox groupBoxLanguages;
        private System.Windows.Forms.CheckBox checkBoxLangRu;
        private System.Windows.Forms.CheckBox checkBoxLangDe;
        private System.Windows.Forms.CheckBox checkBoxLangEn;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.CheckBox checkBoxLangFr;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TabControl tabControlWorkers;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListView listViewWorkers;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnEducation;
        private System.Windows.Forms.ColumnHeader columnSex;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ColumnHeader columnLanguages;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.SplitContainer splitContainerPreview;
        private System.Windows.Forms.SplitContainer splitContainerSearch;
        private System.Windows.Forms.ListView listViewSearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchEducation;
        private System.Windows.Forms.ComboBox comboBoxSearchSex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSearchName;
    }
}

