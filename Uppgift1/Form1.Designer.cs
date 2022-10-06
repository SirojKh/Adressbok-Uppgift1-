namespace Uppgift1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblPhone;
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPostort = new System.Windows.Forms.TextBox();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPostnr = new System.Windows.Forms.Label();
            this.lblPostort = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.AdressList = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSearchShow = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnDelateAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(12, 324);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(68, 25);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Telefon";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 31);
            this.txtName.TabIndex = 0;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(175, 141);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(256, 31);
            this.txtAdress.TabIndex = 1;
            // 
            // txtPostort
            // 
            this.txtPostort.Location = new System.Drawing.Point(175, 200);
            this.txtPostort.Name = "txtPostort";
            this.txtPostort.Size = new System.Drawing.Size(256, 31);
            this.txtPostort.TabIndex = 2;
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(175, 263);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(256, 31);
            this.txtPostnr.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(175, 324);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(256, 31);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Namn";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(12, 141);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(66, 25);
            this.lblAdress.TabIndex = 7;
            this.lblAdress.Text = "Adress";
            // 
            // lblPostnr
            // 
            this.lblPostnr.AutoSize = true;
            this.lblPostnr.Location = new System.Drawing.Point(12, 200);
            this.lblPostnr.Name = "lblPostnr";
            this.lblPostnr.Size = new System.Drawing.Size(113, 25);
            this.lblPostnr.TabIndex = 8;
            this.lblPostnr.Text = "Postnummer";
            // 
            // lblPostort
            // 
            this.lblPostort.AutoSize = true;
            this.lblPostort.Location = new System.Drawing.Point(12, 263);
            this.lblPostort.Name = "lblPostort";
            this.lblPostort.Size = new System.Drawing.Size(69, 25);
            this.lblPostort.TabIndex = 9;
            this.lblPostort.Text = "Postort";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 385);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // AdressList
            // 
            this.AdressList.FormattingEnabled = true;
            this.AdressList.ItemHeight = 25;
            this.AdressList.Location = new System.Drawing.Point(471, 79);
            this.AdressList.Name = "AdressList";
            this.AdressList.Size = new System.Drawing.Size(495, 329);
            this.AdressList.TabIndex = 12;
            this.AdressList.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.AdressList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(592, 436);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 31);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(175, 434);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 34);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(319, 434);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 34);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Ändra";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSearchShow
            // 
            this.btnSearchShow.Location = new System.Drawing.Point(854, 434);
            this.btnSearchShow.Name = "btnSearchShow";
            this.btnSearchShow.Size = new System.Drawing.Size(112, 34);
            this.btnSearchShow.TabIndex = 17;
            this.btnSearchShow.Text = "Sök";
            this.btnSearchShow.UseVisualStyleBackColor = true;
            this.btnSearchShow.Click += new System.EventHandler(this.btnSearchShow_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.Location = new System.Drawing.Point(471, 433);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(112, 34);
            this.btnDelate.TabIndex = 18;
            this.btnDelate.Text = "Ta bort";
            this.btnDelate.UseVisualStyleBackColor = true;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // btnDelateAll
            // 
            this.btnDelateAll.Location = new System.Drawing.Point(471, 489);
            this.btnDelateAll.Name = "btnDelateAll";
            this.btnDelateAll.Size = new System.Drawing.Size(112, 34);
            this.btnDelateAll.TabIndex = 19;
            this.btnDelateAll.Text = "Töm allt";
            this.btnDelateAll.UseVisualStyleBackColor = true;
            this.btnDelateAll.Click += new System.EventHandler(this.btnDelateAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tömtxt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelateAll);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnSearchShow);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.AdressList);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.lblPostort);
            this.Controls.Add(this.lblPostnr);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.txtPostort);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private TextBox txtAdress;
        private TextBox txtPostort;
        private TextBox txtPostnr;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label lblName;
        private Label lblAdress;
        private Label lblPostnr;
        private Label lblPostort;
        private Label lblEmail;
        private ListBox AdressList;
        private TextBox txtSearch;
        private Button btnSave;
        private Button btnShow;
        private Button btnChange;
        private Button btnSearchShow;
        private Button btnDelate;
        private Button btnDelateAll;
        private Button button1;
    }
}