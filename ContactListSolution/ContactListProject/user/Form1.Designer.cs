namespace ContactListProject
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxContactType = new System.Windows.Forms.ComboBox();
            this.labelContactType = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.groupBoxMeetingDate = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.labelMinute = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.labelHour = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.labelYear = new System.Windows.Forms.Label();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.labelDay = new System.Windows.Forms.Label();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.labelMonth = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonReadXmlFile = new System.Windows.Forms.Button();
            this.buttonWriteXmlFile = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxContactsList = new System.Windows.Forms.GroupBox();
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.columnHeaderContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContactType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMeetingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxContactInfo.SuspendLayout();
            this.groupBoxMeetingDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxContactsList.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTitle.Location = new System.Drawing.Point(400, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(346, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Contact List Management";
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.comboBoxContactType);
            this.groupBoxContactInfo.Controls.Add(this.labelContactType);
            this.groupBoxContactInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxContactInfo.Controls.Add(this.labelEmail);
            this.groupBoxContactInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxContactInfo.Controls.Add(this.labelLastName);
            this.groupBoxContactInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxContactInfo.Controls.Add(this.labelFirstName);
            this.groupBoxContactInfo.Controls.Add(this.textBoxContactNumber);
            this.groupBoxContactInfo.Controls.Add(this.labelContactNumber);
            this.groupBoxContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContactInfo.Location = new System.Drawing.Point(20, 68);
            this.groupBoxContactInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo";
            this.groupBoxContactInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactInfo.Size = new System.Drawing.Size(533, 246);
            this.groupBoxContactInfo.TabIndex = 1;
            this.groupBoxContactInfo.TabStop = false;
            this.groupBoxContactInfo.Text = "Contact Information";
            // 
            // comboBoxContactType
            // 
            this.comboBoxContactType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContactType.FormattingEnabled = true;
            this.comboBoxContactType.Location = new System.Drawing.Point(160, 181);
            this.comboBoxContactType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxContactType.Name = "comboBoxContactType";
            this.comboBoxContactType.Size = new System.Drawing.Size(332, 25);
            this.comboBoxContactType.TabIndex = 9;
            // 
            // labelContactType
            // 
            this.labelContactType.AutoSize = true;
            this.labelContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactType.Location = new System.Drawing.Point(20, 185);
            this.labelContactType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactType.Name = "labelContactType";
            this.labelContactType.Size = new System.Drawing.Size(96, 17);
            this.labelContactType.TabIndex = 8;
            this.labelContactType.Text = "Contact Type:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(160, 144);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(332, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(20, 148);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(160, 107);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(332, 23);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(20, 111);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 17);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(160, 70);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(332, 23);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(20, 74);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber.Location = new System.Drawing.Point(160, 33);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(332, 23);
            this.textBoxContactNumber.TabIndex = 1;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNumber.Location = new System.Drawing.Point(20, 37);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(114, 17);
            this.labelContactNumber.TabIndex = 0;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // groupBoxMeetingDate
            // 
            this.groupBoxMeetingDate.Controls.Add(this.numericUpDownMinute);
            this.groupBoxMeetingDate.Controls.Add(this.labelMinute);
            this.groupBoxMeetingDate.Controls.Add(this.numericUpDownHour);
            this.groupBoxMeetingDate.Controls.Add(this.labelHour);
            this.groupBoxMeetingDate.Controls.Add(this.numericUpDownYear);
            this.groupBoxMeetingDate.Controls.Add(this.labelYear);
            this.groupBoxMeetingDate.Controls.Add(this.numericUpDownDay);
            this.groupBoxMeetingDate.Controls.Add(this.labelDay);
            this.groupBoxMeetingDate.Controls.Add(this.numericUpDownMonth);
            this.groupBoxMeetingDate.Controls.Add(this.labelMonth);
            this.groupBoxMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMeetingDate.Location = new System.Drawing.Point(573, 68);
            this.groupBoxMeetingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMeetingDate.Name = "groupBoxMeetingDate";
            this.groupBoxMeetingDate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMeetingDate.Size = new System.Drawing.Size(467, 246);
            this.groupBoxMeetingDate.TabIndex = 2;
            this.groupBoxMeetingDate.TabStop = false;
            this.groupBoxMeetingDate.Text = "Meeting DateTime";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinute.Location = new System.Drawing.Point(307, 145);
            this.numericUpDownMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownMinute.TabIndex = 9;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(240, 148);
            this.labelMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(54, 17);
            this.labelMinute.TabIndex = 8;
            this.labelMinute.Text = "Minute:";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHour.Location = new System.Drawing.Point(93, 145);
            this.numericUpDownHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownHour.TabIndex = 7;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(20, 148);
            this.labelHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(43, 17);
            this.labelHour.TabIndex = 6;
            this.labelHour.Text = "Hour:";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYear.Location = new System.Drawing.Point(93, 96);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(107, 23);
            this.numericUpDownYear.TabIndex = 5;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(20, 98);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(42, 17);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDay.Location = new System.Drawing.Point(293, 47);
            this.numericUpDownDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownDay.TabIndex = 3;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(240, 49);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(37, 17);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day:";
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMonth.Location = new System.Drawing.Point(93, 47);
            this.numericUpDownMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownMonth.TabIndex = 1;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(20, 49);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(51, 17);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "Month:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonReadXmlFile);
            this.groupBoxActions.Controls.Add(this.buttonWriteXmlFile);
            this.groupBoxActions.Controls.Add(this.buttonDisplay);
            this.groupBoxActions.Controls.Add(this.buttonSearch);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActions.Location = new System.Drawing.Point(1067, 68);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxActions.Size = new System.Drawing.Size(240, 246);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonReadXmlFile
            // 
            this.buttonReadXmlFile.BackColor = System.Drawing.Color.Lavender;
            this.buttonReadXmlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadXmlFile.Location = new System.Drawing.Point(20, 215);
            this.buttonReadXmlFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReadXmlFile.Name = "buttonReadXmlFile";
            this.buttonReadXmlFile.Size = new System.Drawing.Size(200, 31);
            this.buttonReadXmlFile.TabIndex = 5;
            this.buttonReadXmlFile.Text = "Read XML File";
            this.buttonReadXmlFile.UseVisualStyleBackColor = false;
            this.buttonReadXmlFile.Click += new System.EventHandler(this.buttonReadXmlFile_Click);
            // 
            // buttonWriteXmlFile
            // 
            this.buttonWriteXmlFile.BackColor = System.Drawing.Color.LightCyan;
            this.buttonWriteXmlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteXmlFile.Location = new System.Drawing.Point(20, 178);
            this.buttonWriteXmlFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWriteXmlFile.Name = "buttonWriteXmlFile";
            this.buttonWriteXmlFile.Size = new System.Drawing.Size(200, 31);
            this.buttonWriteXmlFile.TabIndex = 4;
            this.buttonWriteXmlFile.Text = "Write XML File";
            this.buttonWriteXmlFile.UseVisualStyleBackColor = false;
            this.buttonWriteXmlFile.Click += new System.EventHandler(this.buttonWriteXmlFile_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.LightYellow;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(20, 142);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(200, 31);
            this.buttonDisplay.TabIndex = 3;
            this.buttonDisplay.Text = "Display All Contacts";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(20, 105);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(200, 31);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search Contact";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(20, 68);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 31);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete Contact";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(20, 31);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 31);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Contact";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxContactsList
            // 
            this.groupBoxContactsList.Controls.Add(this.listViewContacts);
            this.groupBoxContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContactsList.Location = new System.Drawing.Point(20, 332);
            this.groupBoxContactsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactsList.Name = "groupBoxContactsList";
            this.groupBoxContactsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactsList.Size = new System.Drawing.Size(1287, 345);
            this.groupBoxContactsList.TabIndex = 4;
            this.groupBoxContactsList.TabStop = false;
            this.groupBoxContactsList.Text = "Contacts List";
            // 
            // listViewContacts
            // 
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderContactNumber,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmail,
            this.columnHeaderContactType,
            this.columnHeaderMeetingDate});
            this.listViewContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewContacts.FullRowSelect = true;
            this.listViewContacts.GridLines = true;
            this.listViewContacts.HideSelection = false;
            this.listViewContacts.Location = new System.Drawing.Point(20, 31);
            this.listViewContacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewContacts.MultiSelect = false;
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(1245, 294);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            this.listViewContacts.SelectedIndexChanged += new System.EventHandler(this.listViewContacts_SelectedIndexChanged);
            // 
            // columnHeaderContactNumber
            // 
            this.columnHeaderContactNumber.Text = "Contact Number";
            this.columnHeaderContactNumber.Width = 120;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 150;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 200;
            // 
            // columnHeaderContactType
            // 
            this.columnHeaderContactType.Text = "Contact Type";
            this.columnHeaderContactType.Width = 120;
            // 
            // columnHeaderMeetingDate
            // 
            this.columnHeaderMeetingDate.Text = "Meeting Date";
            this.columnHeaderMeetingDate.Width = 180;
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 696);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1333, 26);
            this.statusStripMain.TabIndex = 5;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabelMain.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1333, 722);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxContactsList);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxMeetingDate);
            this.Controls.Add(this.groupBoxContactInfo);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact List Management System - ContactListProject";
            this.groupBoxContactInfo.ResumeLayout(false);
            this.groupBoxContactInfo.PerformLayout();
            this.groupBoxMeetingDate.ResumeLayout(false);
            this.groupBoxMeetingDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxContactsList.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxContactInfo;
        private System.Windows.Forms.ComboBox comboBoxContactType;
        private System.Windows.Forms.Label labelContactType;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.GroupBox groupBoxMeetingDate;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReadXmlFile;
        private System.Windows.Forms.Button buttonWriteXmlFile;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxContactsList;
        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.ColumnHeader columnHeaderContactNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderContactType;
        private System.Windows.Forms.ColumnHeader columnHeaderMeetingDate;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
    }
}