namespace CsharpForm
{
    partial class signUpForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.signUp = new System.Windows.Forms.Button();
            this.confirm_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageMonth = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ageDay = new System.Windows.Forms.ComboBox();
            this.dob = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.signUp);
            this.panel2.Controls.Add(this.confirm_TextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.password_TextBox);
            this.panel2.Controls.Add(this.email_TextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ageMonth);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.ageDay);
            this.panel2.Controls.Add(this.dob);
            this.panel2.Controls.Add(this.lName);
            this.panel2.Controls.Add(this.mName);
            this.panel2.Controls.Add(this.fName);
            this.panel2.Controls.Add(this.lastName);
            this.panel2.Controls.Add(this.middleName);
            this.panel2.Controls.Add(this.firstName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(43, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 613);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 461);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Gender";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(148, 484);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 19);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Custom";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 484);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 19);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 484);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 19);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.Green;
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUp.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUp.ForeColor = System.Drawing.Color.White;
            this.signUp.Location = new System.Drawing.Point(148, 534);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(283, 62);
            this.signUp.TabIndex = 28;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // confirm_TextBox
            // 
            this.confirm_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.confirm_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_TextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_TextBox.Location = new System.Drawing.Point(13, 412);
            this.confirm_TextBox.MaximumSize = new System.Drawing.Size(354, 60);
            this.confirm_TextBox.MinimumSize = new System.Drawing.Size(540, 40);
            this.confirm_TextBox.Name = "confirm_TextBox";
            this.confirm_TextBox.Size = new System.Drawing.Size(540, 40);
            this.confirm_TextBox.TabIndex = 27;
            this.confirm_TextBox.TextChanged += new System.EventHandler(this.confirm_TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // password_TextBox
            // 
            this.password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_TextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_TextBox.Location = new System.Drawing.Point(13, 346);
            this.password_TextBox.MaximumSize = new System.Drawing.Size(354, 60);
            this.password_TextBox.MinimumSize = new System.Drawing.Size(540, 40);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(540, 40);
            this.password_TextBox.TabIndex = 24;
            this.password_TextBox.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // email_TextBox
            // 
            this.email_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_TextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_TextBox.Location = new System.Drawing.Point(13, 280);
            this.email_TextBox.MaximumSize = new System.Drawing.Size(354, 60);
            this.email_TextBox.MinimumSize = new System.Drawing.Size(540, 40);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(540, 40);
            this.email_TextBox.TabIndex = 23;
            this.email_TextBox.TextChanged += new System.EventHandler(this.email_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(235, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Year:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(124, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Month:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Day:";
            // 
            // ageMonth
            // 
            this.ageMonth.FormattingEnabled = true;
            this.ageMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ageMonth.Location = new System.Drawing.Point(124, 220);
            this.ageMonth.Name = "ageMonth";
            this.ageMonth.Size = new System.Drawing.Size(105, 23);
            this.ageMonth.TabIndex = 16;
            this.ageMonth.SelectedIndexChanged += new System.EventHandler(this.ageMonth_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox2.Location = new System.Drawing.Point(235, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // ageDay
            // 
            this.ageDay.FormattingEnabled = true;
            this.ageDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ageDay.Location = new System.Drawing.Point(13, 220);
            this.ageDay.Name = "ageDay";
            this.ageDay.Size = new System.Drawing.Size(105, 23);
            this.ageDay.TabIndex = 14;
            this.ageDay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dob.Location = new System.Drawing.Point(13, 177);
            this.dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(111, 20);
            this.dob.TabIndex = 13;
            this.dob.Text = "Date of Birth:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(381, 102);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(92, 20);
            this.lName.TabIndex = 12;
            this.lName.Text = "Last Name:";
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mName.Location = new System.Drawing.Point(193, 102);
            this.mName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(115, 20);
            this.mName.TabIndex = 11;
            this.mName.Text = "Middle Name:";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fName.Location = new System.Drawing.Point(13, 102);
            this.fName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(94, 20);
            this.fName.TabIndex = 10;
            this.fName.Text = "First Name:";
            this.fName.Click += new System.EventHandler(this.fName_Click);
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(381, 125);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(171, 36);
            this.lastName.TabIndex = 3;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // middleName
            // 
            this.middleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.middleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleName.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.middleName.Location = new System.Drawing.Point(193, 125);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(171, 36);
            this.middleName.TabIndex = 2;
            this.middleName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(13, 125);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(171, 36);
            this.firstName.TabIndex = 1;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 668);
            this.Controls.Add(this.panel2);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox middleName;
        private Label mName;
        private Label fName;
        private Label dob;
        private Label lName;
        private ComboBox ageDay;
        private Label label2;
        private ComboBox ageMonth;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox email_TextBox;
        private TextBox confirm_TextBox;
        private Label label7;
        private Label label4;
        private TextBox password_TextBox;
        private Button signUp;
        private Label label8;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}