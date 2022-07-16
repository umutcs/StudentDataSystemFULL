namespace StudentDataProgram
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtUni = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OGRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OGRAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIVERCİTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(115, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(215, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(215, 20);
            this.txtID.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz",
            "ORTA DOĞU TEKNİK ÜNİVERSİTESİ",
            "İSTANBUL TEKNİK ÜNİVERSİTESİ",
            "CELAL BAYAR ÜNİVERSİTESİ",
            "KONYA SELÇUK ÜNİVERSİTESİ"});
            this.comboBox1.Location = new System.Drawing.Point(115, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Seçiniz",
            "Yazılım Mühendisliği",
            "Makine Mühendisliği",
            "Makine Mühendisliği",
            "Elektrik Elektronik Mühendisliği",
            "Bilgisayar Mühendisliği"});
            this.comboBox2.Location = new System.Drawing.Point(115, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Seçiniz",
            "1. Sınıf",
            "2. Sınıf",
            "3. Sınıf",
            "4. Sınıf"});
            this.comboBox3.Location = new System.Drawing.Point(115, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(22, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "AD";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 45);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "SOYAD";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ÖĞRENCİ NO";
            // 
            // txtUni
            // 
            this.txtUni.AutoSize = true;
            this.txtUni.Location = new System.Drawing.Point(9, 93);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(72, 13);
            this.txtUni.TabIndex = 9;
            this.txtUni.Text = "ÜNİVERSİTE";
            // 
            // txtDepartment
            // 
            this.txtDepartment.AutoSize = true;
            this.txtDepartment.Location = new System.Drawing.Point(9, 120);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(45, 13);
            this.txtDepartment.TabIndex = 10;
            this.txtDepartment.Text = "BÖLÜM";
            // 
            // txtGrade
            // 
            this.txtGrade.AutoSize = true;
            this.txtGrade.Location = new System.Drawing.Point(9, 144);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(34, 13);
            this.txtGrade.TabIndex = 11;
            this.txtGrade.Text = "SINIF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(539, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OGRID,
            this.OGRAD,
            this.LASTNAME,
            this.UNIVERCİTY,
            this.department,
            this.GRADE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 339);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OGRID
            // 
            this.OGRID.HeaderText = "OGRID";
            this.OGRID.Name = "OGRID";
            this.OGRID.ReadOnly = true;
            // 
            // OGRAD
            // 
            this.OGRAD.HeaderText = "İSİM";
            this.OGRAD.Name = "OGRAD";
            this.OGRAD.ReadOnly = true;
            // 
            // LASTNAME
            // 
            this.LASTNAME.HeaderText = "SOYİSİM";
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.ReadOnly = true;
            // 
            // UNIVERCİTY
            // 
            this.UNIVERCİTY.HeaderText = "UNİVERSİTE";
            this.UNIVERCİTY.Name = "UNIVERCİTY";
            this.UNIVERCİTY.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "BÖLÜM";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // GRADE
            // 
            this.GRADE.HeaderText = "SINIF";
            this.GRADE.Name = "GRADE";
            this.GRADE.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtGrade);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.txtUni);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 198);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label txtUni;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.Label txtGrade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OGRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OGRAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIVERCİTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADE;
        private System.Windows.Forms.Panel panel1;
    }
}

