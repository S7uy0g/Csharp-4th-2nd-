namespace CsharpForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventory = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.booking = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.employee1 = new CsharpForm.Employee();
            this.booking1 = new CsharpForm.Booking();
            this.inventory1 = new CsharpForm.inventory();
            this.home1 = new CsharpForm.Home();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.inventory);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.booking);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 772);
            this.panel1.TabIndex = 0;
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.White;
            this.inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventory.Location = new System.Drawing.Point(0, 247);
            this.inventory.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(340, 49);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.White;
            this.employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee.Location = new System.Drawing.Point(0, 198);
            this.employee.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(340, 49);
            this.employee.TabIndex = 4;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.button4_Click);
            // 
            // booking
            // 
            this.booking.BackColor = System.Drawing.Color.White;
            this.booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booking.Location = new System.Drawing.Point(0, 149);
            this.booking.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(340, 49);
            this.booking.TabIndex = 3;
            this.booking.Text = "Booking";
            this.booking.UseVisualStyleBackColor = false;
            this.booking.Click += new System.EventHandler(this.button3_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home.Location = new System.Drawing.Point(0, 100);
            this.home.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(340, 49);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 100);
            this.panel3.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(288, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 36);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Futsal Name Here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.home1);
            this.panel4.Controls.Add(this.inventory1);
            this.panel4.Controls.Add(this.employee1);
            this.panel4.Controls.Add(this.booking1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(340, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 672);
            this.panel4.TabIndex = 2;
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(985, 672);
            this.employee1.TabIndex = 1;
            // 
            // booking1
            // 
            this.booking1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.booking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booking1.Location = new System.Drawing.Point(0, 0);
            this.booking1.Name = "booking1";
            this.booking1.Size = new System.Drawing.Size(985, 672);
            this.booking1.TabIndex = 0;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.LightCoral;
            this.inventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory1.Location = new System.Drawing.Point(0, 0);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(985, 672);
            this.inventory1.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(985, 672);
            this.home1.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 772);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button home;
        private Panel panel3;
        private Button employee;
        private Button booking;
        private Panel panel4;
        private Button button5;
        private Label label1;
        private Booking booking1;
        private Employee employee1;
        private Button inventory;
        private Home home1;
        private inventory inventory1;
    }
}