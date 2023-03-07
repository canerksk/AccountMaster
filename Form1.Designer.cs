namespace AccountMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.charcount_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pc_textBox = new System.Windows.Forms.TextBox();
            this.account_refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.uuid_textBox = new System.Windows.Forms.TextBox();
            this.uuid = new System.Windows.Forms.Label();
            this.lastconnecttime_label = new System.Windows.Forms.Label();
            this.lastconnecttime = new System.Windows.Forms.Label();
            this.lastconnecttime_textBox = new System.Windows.Forms.TextBox();
            this.totalconnecttime_label = new System.Windows.Forms.Label();
            this.lang_textBox = new System.Windows.Forms.TextBox();
            this.blocked_checkBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.account_save_button = new System.Windows.Forms.Button();
            this.lastcharuid = new System.Windows.Forms.Label();
            this.lastcharuid_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalconnecttime_textBox = new System.Windows.Forms.TextBox();
            this.lastip_textBox = new System.Windows.Forms.TextBox();
            this.firstip_textBox = new System.Windows.Forms.TextBox();
            this.expansion_label = new System.Windows.Forms.Label();
            this.expansion_comboBox = new System.Windows.Forms.ComboBox();
            this.lastip = new System.Windows.Forms.Label();
            this.firstip = new System.Windows.Forms.Label();
            this.lastconnectdate_textBox = new System.Windows.Forms.TextBox();
            this.firstconnectdate_textBox = new System.Windows.Forms.TextBox();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.pin_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.account_textBox = new System.Windows.Forms.TextBox();
            this.blocked_label = new System.Windows.Forms.Label();
            this.plevel_comboBox = new System.Windows.Forms.ComboBox();
            this.plevel_label = new System.Windows.Forms.Label();
            this.lastconnectdate = new System.Windows.Forms.Label();
            this.firstconnectdate = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.filter_blocked_checkBox = new System.Windows.Forms.CheckBox();
            this.filter_player_checkBox = new System.Windows.Forms.CheckBox();
            this.filter_staff_checkBox = new System.Windows.Forms.CheckBox();
            this.search_pc_button = new System.Windows.Forms.Button();
            this.search_pc_textBox = new System.Windows.Forms.TextBox();
            this.search_pc = new System.Windows.Forms.Label();
            this.filter_radioButton = new System.Windows.Forms.RadioButton();
            this.filter_all_radioButton = new System.Windows.Forms.RadioButton();
            this.filter = new System.Windows.Forms.Label();
            this.search_account_button = new System.Windows.Forms.Button();
            this.search_ip_textBox = new System.Windows.Forms.TextBox();
            this.search_ip = new System.Windows.Forms.Label();
            this.search_account = new System.Windows.Forms.Label();
            this.search_ip_button = new System.Windows.Forms.Button();
            this.search_account_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.total_accounts_label = new System.Windows.Forms.Label();
            this.total_blocked_accounts_label = new System.Windows.Forms.Label();
            this.total_staff_accounts_label = new System.Windows.Forms.Label();
            this.total_player_accounts_label = new System.Windows.Forms.Label();
            this.total_player_accounts = new System.Windows.Forms.Label();
            this.total_staff_accounts = new System.Windows.Forms.Label();
            this.total_blocked_accounts = new System.Windows.Forms.Label();
            this.total_accounts = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Listesi";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(12, 367);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(211, 23);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Yenile";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.charcount_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pc_textBox);
            this.groupBox2.Controls.Add(this.account_refresh_button);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.id_textBox);
            this.groupBox2.Controls.Add(this.uuid_textBox);
            this.groupBox2.Controls.Add(this.uuid);
            this.groupBox2.Controls.Add(this.lastconnecttime_label);
            this.groupBox2.Controls.Add(this.lastconnecttime);
            this.groupBox2.Controls.Add(this.lastconnecttime_textBox);
            this.groupBox2.Controls.Add(this.totalconnecttime_label);
            this.groupBox2.Controls.Add(this.lang_textBox);
            this.groupBox2.Controls.Add(this.blocked_checkBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.account_save_button);
            this.groupBox2.Controls.Add(this.lastcharuid);
            this.groupBox2.Controls.Add(this.lastcharuid_textBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.totalconnecttime_textBox);
            this.groupBox2.Controls.Add(this.lastip_textBox);
            this.groupBox2.Controls.Add(this.firstip_textBox);
            this.groupBox2.Controls.Add(this.expansion_label);
            this.groupBox2.Controls.Add(this.expansion_comboBox);
            this.groupBox2.Controls.Add(this.lastip);
            this.groupBox2.Controls.Add(this.firstip);
            this.groupBox2.Controls.Add(this.lastconnectdate_textBox);
            this.groupBox2.Controls.Add(this.firstconnectdate_textBox);
            this.groupBox2.Controls.Add(this.mail_textBox);
            this.groupBox2.Controls.Add(this.pin_textBox);
            this.groupBox2.Controls.Add(this.password_textBox);
            this.groupBox2.Controls.Add(this.account_textBox);
            this.groupBox2.Controls.Add(this.blocked_label);
            this.groupBox2.Controls.Add(this.plevel_comboBox);
            this.groupBox2.Controls.Add(this.plevel_label);
            this.groupBox2.Controls.Add(this.lastconnectdate);
            this.groupBox2.Controls.Add(this.firstconnectdate);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.pin);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.account);
            this.groupBox2.Location = new System.Drawing.Point(241, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 621);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // charcount_textBox
            // 
            this.charcount_textBox.Location = new System.Drawing.Point(342, 384);
            this.charcount_textBox.Name = "charcount_textBox";
            this.charcount_textBox.ReadOnly = true;
            this.charcount_textBox.Size = new System.Drawing.Size(48, 20);
            this.charcount_textBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Toplam Karakter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "PC";
            // 
            // pc_textBox
            // 
            this.pc_textBox.Location = new System.Drawing.Point(140, 491);
            this.pc_textBox.Name = "pc_textBox";
            this.pc_textBox.ReadOnly = true;
            this.pc_textBox.Size = new System.Drawing.Size(250, 20);
            this.pc_textBox.TabIndex = 51;
            // 
            // account_refresh_button
            // 
            this.account_refresh_button.Location = new System.Drawing.Point(10, 592);
            this.account_refresh_button.Name = "account_refresh_button";
            this.account_refresh_button.Size = new System.Drawing.Size(75, 23);
            this.account_refresh_button.TabIndex = 50;
            this.account_refresh_button.Text = "Yenile";
            this.account_refresh_button.UseVisualStyleBackColor = true;
            this.account_refresh_button.Click += new System.EventHandler(this.account_refresh_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(140, 22);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(250, 20);
            this.id_textBox.TabIndex = 48;
            // 
            // uuid_textBox
            // 
            this.uuid_textBox.Location = new System.Drawing.Point(140, 48);
            this.uuid_textBox.Name = "uuid_textBox";
            this.uuid_textBox.ReadOnly = true;
            this.uuid_textBox.Size = new System.Drawing.Size(250, 20);
            this.uuid_textBox.TabIndex = 47;
            // 
            // uuid
            // 
            this.uuid.AutoSize = true;
            this.uuid.Location = new System.Drawing.Point(13, 55);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(55, 13);
            this.uuid.TabIndex = 46;
            this.uuid.Text = "Unique ID";
            // 
            // lastconnecttime_label
            // 
            this.lastconnecttime_label.AutoSize = true;
            this.lastconnecttime_label.Location = new System.Drawing.Point(223, 327);
            this.lastconnecttime_label.Name = "lastconnecttime_label";
            this.lastconnecttime_label.Size = new System.Drawing.Size(10, 13);
            this.lastconnecttime_label.TabIndex = 43;
            this.lastconnecttime_label.Text = "-";
            // 
            // lastconnecttime
            // 
            this.lastconnecttime.AutoSize = true;
            this.lastconnecttime.Location = new System.Drawing.Point(13, 331);
            this.lastconnecttime.Name = "lastconnecttime";
            this.lastconnecttime.Size = new System.Drawing.Size(96, 13);
            this.lastconnecttime.TabIndex = 45;
            this.lastconnecttime.Text = "Son bağlantı süresi";
            // 
            // lastconnecttime_textBox
            // 
            this.lastconnecttime_textBox.Location = new System.Drawing.Point(140, 324);
            this.lastconnecttime_textBox.Name = "lastconnecttime_textBox";
            this.lastconnecttime_textBox.Size = new System.Drawing.Size(77, 20);
            this.lastconnecttime_textBox.TabIndex = 44;
            // 
            // totalconnecttime_label
            // 
            this.totalconnecttime_label.AutoSize = true;
            this.totalconnecttime_label.Location = new System.Drawing.Point(223, 302);
            this.totalconnecttime_label.Name = "totalconnecttime_label";
            this.totalconnecttime_label.Size = new System.Drawing.Size(10, 13);
            this.totalconnecttime_label.TabIndex = 2;
            this.totalconnecttime_label.Text = "-";
            // 
            // lang_textBox
            // 
            this.lang_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lang_textBox.Location = new System.Drawing.Point(140, 407);
            this.lang_textBox.Name = "lang_textBox";
            this.lang_textBox.Size = new System.Drawing.Size(250, 20);
            this.lang_textBox.TabIndex = 42;
            // 
            // blocked_checkBox
            // 
            this.blocked_checkBox.AutoSize = true;
            this.blocked_checkBox.Location = new System.Drawing.Point(140, 471);
            this.blocked_checkBox.Name = "blocked_checkBox";
            this.blocked_checkBox.Size = new System.Drawing.Size(15, 14);
            this.blocked_checkBox.TabIndex = 40;
            this.blocked_checkBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Dil";
            // 
            // account_save_button
            // 
            this.account_save_button.Location = new System.Drawing.Point(284, 592);
            this.account_save_button.Name = "account_save_button";
            this.account_save_button.Size = new System.Drawing.Size(113, 23);
            this.account_save_button.TabIndex = 34;
            this.account_save_button.Text = "Değişikliği Kaydet";
            this.account_save_button.UseVisualStyleBackColor = true;
            this.account_save_button.Click += new System.EventHandler(this.account_save_button_Click);
            // 
            // lastcharuid
            // 
            this.lastcharuid.AutoSize = true;
            this.lastcharuid.Location = new System.Drawing.Point(13, 387);
            this.lastcharuid.Name = "lastcharuid";
            this.lastcharuid.Size = new System.Drawing.Size(101, 13);
            this.lastcharuid.TabIndex = 32;
            this.lastcharuid.Text = "Son Girilen Karakter";
            // 
            // lastcharuid_textBox
            // 
            this.lastcharuid_textBox.Location = new System.Drawing.Point(140, 380);
            this.lastcharuid_textBox.Name = "lastcharuid_textBox";
            this.lastcharuid_textBox.ReadOnly = true;
            this.lastcharuid_textBox.Size = new System.Drawing.Size(93, 20);
            this.lastcharuid_textBox.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Toplam bağlantı süresi";
            // 
            // totalconnecttime_textBox
            // 
            this.totalconnecttime_textBox.Location = new System.Drawing.Point(140, 299);
            this.totalconnecttime_textBox.Name = "totalconnecttime_textBox";
            this.totalconnecttime_textBox.Size = new System.Drawing.Size(77, 20);
            this.totalconnecttime_textBox.TabIndex = 29;
            // 
            // lastip_textBox
            // 
            this.lastip_textBox.Location = new System.Drawing.Point(140, 270);
            this.lastip_textBox.Name = "lastip_textBox";
            this.lastip_textBox.Size = new System.Drawing.Size(250, 20);
            this.lastip_textBox.TabIndex = 28;
            // 
            // firstip_textBox
            // 
            this.firstip_textBox.Location = new System.Drawing.Point(140, 242);
            this.firstip_textBox.Name = "firstip_textBox";
            this.firstip_textBox.Size = new System.Drawing.Size(250, 20);
            this.firstip_textBox.TabIndex = 27;
            // 
            // expansion_label
            // 
            this.expansion_label.AutoSize = true;
            this.expansion_label.Location = new System.Drawing.Point(13, 361);
            this.expansion_label.Name = "expansion_label";
            this.expansion_label.Size = new System.Drawing.Size(56, 13);
            this.expansion_label.TabIndex = 26;
            this.expansion_label.Text = "Expansion";
            // 
            // expansion_comboBox
            // 
            this.expansion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expansion_comboBox.FormattingEnabled = true;
            this.expansion_comboBox.Items.AddRange(new object[] {
            "PRET2A",
            "T2A",
            "LBR",
            "AOS",
            "SE   ",
            "ML",
            "KR",
            "SA",
            "HS",
            "TOL"});
            this.expansion_comboBox.Location = new System.Drawing.Point(140, 353);
            this.expansion_comboBox.Name = "expansion_comboBox";
            this.expansion_comboBox.Size = new System.Drawing.Size(250, 21);
            this.expansion_comboBox.TabIndex = 25;
            // 
            // lastip
            // 
            this.lastip.AutoSize = true;
            this.lastip.Location = new System.Drawing.Point(13, 277);
            this.lastip.Name = "lastip";
            this.lastip.Size = new System.Drawing.Size(39, 13);
            this.lastip.TabIndex = 24;
            this.lastip.Text = "Son IP";
            // 
            // firstip
            // 
            this.firstip.AutoSize = true;
            this.firstip.Location = new System.Drawing.Point(13, 249);
            this.firstip.Name = "firstip";
            this.firstip.Size = new System.Drawing.Size(31, 13);
            this.firstip.TabIndex = 23;
            this.firstip.Text = "İlk IP";
            // 
            // lastconnectdate_textBox
            // 
            this.lastconnectdate_textBox.Location = new System.Drawing.Point(140, 214);
            this.lastconnectdate_textBox.Name = "lastconnectdate_textBox";
            this.lastconnectdate_textBox.Size = new System.Drawing.Size(250, 20);
            this.lastconnectdate_textBox.TabIndex = 22;
            // 
            // firstconnectdate_textBox
            // 
            this.firstconnectdate_textBox.Location = new System.Drawing.Point(140, 185);
            this.firstconnectdate_textBox.Name = "firstconnectdate_textBox";
            this.firstconnectdate_textBox.Size = new System.Drawing.Size(250, 20);
            this.firstconnectdate_textBox.TabIndex = 21;
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(140, 156);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(250, 20);
            this.mail_textBox.TabIndex = 20;
            // 
            // pin_textBox
            // 
            this.pin_textBox.Location = new System.Drawing.Point(140, 131);
            this.pin_textBox.Name = "pin_textBox";
            this.pin_textBox.ReadOnly = true;
            this.pin_textBox.Size = new System.Drawing.Size(250, 20);
            this.pin_textBox.TabIndex = 19;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(140, 104);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.ReadOnly = true;
            this.password_textBox.Size = new System.Drawing.Size(250, 20);
            this.password_textBox.TabIndex = 18;
            // 
            // account_textBox
            // 
            this.account_textBox.Location = new System.Drawing.Point(140, 74);
            this.account_textBox.Name = "account_textBox";
            this.account_textBox.ReadOnly = true;
            this.account_textBox.Size = new System.Drawing.Size(250, 20);
            this.account_textBox.TabIndex = 17;
            // 
            // blocked_label
            // 
            this.blocked_label.AutoSize = true;
            this.blocked_label.Location = new System.Drawing.Point(13, 471);
            this.blocked_label.Name = "blocked_label";
            this.blocked_label.Size = new System.Drawing.Size(34, 13);
            this.blocked_label.TabIndex = 10;
            this.blocked_label.Text = "Bloke";
            // 
            // plevel_comboBox
            // 
            this.plevel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plevel_comboBox.FormattingEnabled = true;
            this.plevel_comboBox.Items.AddRange(new object[] {
            "Player",
            "Counselor",
            "Seer",
            "GM",
            "Dev",
            "Admin",
            "Owner"});
            this.plevel_comboBox.Location = new System.Drawing.Point(140, 438);
            this.plevel_comboBox.Name = "plevel_comboBox";
            this.plevel_comboBox.Size = new System.Drawing.Size(250, 21);
            this.plevel_comboBox.TabIndex = 9;
            // 
            // plevel_label
            // 
            this.plevel_label.AutoSize = true;
            this.plevel_label.Location = new System.Drawing.Point(13, 446);
            this.plevel_label.Name = "plevel_label";
            this.plevel_label.Size = new System.Drawing.Size(36, 13);
            this.plevel_label.TabIndex = 8;
            this.plevel_label.Text = "Plevel";
            // 
            // lastconnectdate
            // 
            this.lastconnectdate.AutoSize = true;
            this.lastconnectdate.Location = new System.Drawing.Point(13, 221);
            this.lastconnectdate.Name = "lastconnectdate";
            this.lastconnectdate.Size = new System.Drawing.Size(72, 13);
            this.lastconnectdate.TabIndex = 5;
            this.lastconnectdate.Text = "Son giriş tarihi";
            // 
            // firstconnectdate
            // 
            this.firstconnectdate.AutoSize = true;
            this.firstconnectdate.Location = new System.Drawing.Point(13, 192);
            this.firstconnectdate.Name = "firstconnectdate";
            this.firstconnectdate.Size = new System.Drawing.Size(64, 13);
            this.firstconnectdate.TabIndex = 4;
            this.firstconnectdate.Text = "İlk giriş tarihi";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(13, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 13);
            this.email.TabIndex = 3;
            this.email.Text = "E-Posta";
            // 
            // pin
            // 
            this.pin.AutoSize = true;
            this.pin.Location = new System.Drawing.Point(13, 138);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(22, 13);
            this.pin.TabIndex = 2;
            this.pin.Text = "Pin";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(13, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(28, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Şifre";
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(13, 81);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(56, 13);
            this.account.TabIndex = 0;
            this.account.Text = "Hesap Adı";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 661);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filter_blocked_checkBox);
            this.groupBox4.Controls.Add(this.filter_player_checkBox);
            this.groupBox4.Controls.Add(this.filter_staff_checkBox);
            this.groupBox4.Controls.Add(this.search_pc_button);
            this.groupBox4.Controls.Add(this.search_pc_textBox);
            this.groupBox4.Controls.Add(this.search_pc);
            this.groupBox4.Controls.Add(this.filter_radioButton);
            this.groupBox4.Controls.Add(this.filter_all_radioButton);
            this.groupBox4.Controls.Add(this.filter);
            this.groupBox4.Controls.Add(this.search_account_button);
            this.groupBox4.Controls.Add(this.search_ip_textBox);
            this.groupBox4.Controls.Add(this.search_ip);
            this.groupBox4.Controls.Add(this.search_account);
            this.groupBox4.Controls.Add(this.search_ip_button);
            this.groupBox4.Controls.Add(this.search_account_textBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 210);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ara / Filtrele";
            // 
            // filter_blocked_checkBox
            // 
            this.filter_blocked_checkBox.AutoSize = true;
            this.filter_blocked_checkBox.Location = new System.Drawing.Point(155, 186);
            this.filter_blocked_checkBox.Name = "filter_blocked_checkBox";
            this.filter_blocked_checkBox.Size = new System.Drawing.Size(60, 17);
            this.filter_blocked_checkBox.TabIndex = 25;
            this.filter_blocked_checkBox.Text = "Yasaklı";
            this.filter_blocked_checkBox.UseVisualStyleBackColor = true;
            this.filter_blocked_checkBox.Visible = false;
            this.filter_blocked_checkBox.CheckedChanged += new System.EventHandler(this.filter_blocked_checkBox_CheckedChanged);
            // 
            // filter_player_checkBox
            // 
            this.filter_player_checkBox.AutoSize = true;
            this.filter_player_checkBox.Location = new System.Drawing.Point(77, 186);
            this.filter_player_checkBox.Name = "filter_player_checkBox";
            this.filter_player_checkBox.Size = new System.Drawing.Size(63, 17);
            this.filter_player_checkBox.TabIndex = 24;
            this.filter_player_checkBox.Text = "Oyuncu";
            this.filter_player_checkBox.UseVisualStyleBackColor = true;
            this.filter_player_checkBox.Visible = false;
            this.filter_player_checkBox.CheckedChanged += new System.EventHandler(this.filter_player_checkBox_CheckedChanged);
            // 
            // filter_staff_checkBox
            // 
            this.filter_staff_checkBox.AutoSize = true;
            this.filter_staff_checkBox.Location = new System.Drawing.Point(12, 186);
            this.filter_staff_checkBox.Name = "filter_staff_checkBox";
            this.filter_staff_checkBox.Size = new System.Drawing.Size(54, 17);
            this.filter_staff_checkBox.TabIndex = 23;
            this.filter_staff_checkBox.Text = "Yetkili";
            this.filter_staff_checkBox.UseVisualStyleBackColor = true;
            this.filter_staff_checkBox.Visible = false;
            this.filter_staff_checkBox.CheckedChanged += new System.EventHandler(this.filter_staff_checkBox_CheckedChanged);
            // 
            // search_pc_button
            // 
            this.search_pc_button.Location = new System.Drawing.Point(175, 118);
            this.search_pc_button.Name = "search_pc_button";
            this.search_pc_button.Size = new System.Drawing.Size(46, 23);
            this.search_pc_button.TabIndex = 22;
            this.search_pc_button.Text = "Ara";
            this.search_pc_button.UseVisualStyleBackColor = true;
            this.search_pc_button.Click += new System.EventHandler(this.search_pc_button_Click);
            // 
            // search_pc_textBox
            // 
            this.search_pc_textBox.Location = new System.Drawing.Point(12, 118);
            this.search_pc_textBox.Name = "search_pc_textBox";
            this.search_pc_textBox.Size = new System.Drawing.Size(159, 20);
            this.search_pc_textBox.TabIndex = 21;
            // 
            // search_pc
            // 
            this.search_pc.AutoSize = true;
            this.search_pc.Location = new System.Drawing.Point(9, 102);
            this.search_pc.Name = "search_pc";
            this.search_pc.Size = new System.Drawing.Size(24, 13);
            this.search_pc.TabIndex = 20;
            this.search_pc.Text = "PC;";
            // 
            // filter_radioButton
            // 
            this.filter_radioButton.AutoSize = true;
            this.filter_radioButton.Location = new System.Drawing.Point(155, 158);
            this.filter_radioButton.Name = "filter_radioButton";
            this.filter_radioButton.Size = new System.Drawing.Size(46, 17);
            this.filter_radioButton.TabIndex = 19;
            this.filter_radioButton.Text = "Özel";
            this.filter_radioButton.UseVisualStyleBackColor = true;
            this.filter_radioButton.CheckedChanged += new System.EventHandler(this.filter_radioButton_CheckedChanged);
            // 
            // filter_all_radioButton
            // 
            this.filter_all_radioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.filter_all_radioButton.AutoSize = true;
            this.filter_all_radioButton.Checked = true;
            this.filter_all_radioButton.Location = new System.Drawing.Point(10, 158);
            this.filter_all_radioButton.Name = "filter_all_radioButton";
            this.filter_all_radioButton.Size = new System.Drawing.Size(52, 17);
            this.filter_all_radioButton.TabIndex = 18;
            this.filter_all_radioButton.TabStop = true;
            this.filter_all_radioButton.Text = "Hepsi";
            this.filter_all_radioButton.UseVisualStyleBackColor = true;
            this.filter_all_radioButton.CheckedChanged += new System.EventHandler(this.filter_all_radioButton_CheckedChanged);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(9, 142);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(40, 13);
            this.filter.TabIndex = 17;
            this.filter.Text = "Filtrele;";
            // 
            // search_account_button
            // 
            this.search_account_button.Location = new System.Drawing.Point(175, 38);
            this.search_account_button.Name = "search_account_button";
            this.search_account_button.Size = new System.Drawing.Size(46, 23);
            this.search_account_button.TabIndex = 16;
            this.search_account_button.Text = "Ara";
            this.search_account_button.UseVisualStyleBackColor = true;
            this.search_account_button.Click += new System.EventHandler(this.search_account_button_Click);
            // 
            // search_ip_textBox
            // 
            this.search_ip_textBox.Location = new System.Drawing.Point(12, 79);
            this.search_ip_textBox.Name = "search_ip_textBox";
            this.search_ip_textBox.Size = new System.Drawing.Size(159, 20);
            this.search_ip_textBox.TabIndex = 15;
            // 
            // search_ip
            // 
            this.search_ip.AutoSize = true;
            this.search_ip.Location = new System.Drawing.Point(9, 63);
            this.search_ip.Name = "search_ip";
            this.search_ip.Size = new System.Drawing.Size(20, 13);
            this.search_ip.TabIndex = 14;
            this.search_ip.Text = "IP;";
            // 
            // search_account
            // 
            this.search_account.AutoSize = true;
            this.search_account.Location = new System.Drawing.Point(7, 24);
            this.search_account.Name = "search_account";
            this.search_account.Size = new System.Drawing.Size(59, 13);
            this.search_account.TabIndex = 13;
            this.search_account.Text = "Hesap Adı;";
            // 
            // search_ip_button
            // 
            this.search_ip_button.Location = new System.Drawing.Point(177, 77);
            this.search_ip_button.Name = "search_ip_button";
            this.search_ip_button.Size = new System.Drawing.Size(46, 23);
            this.search_ip_button.TabIndex = 12;
            this.search_ip_button.Text = "Ara";
            this.search_ip_button.UseVisualStyleBackColor = true;
            this.search_ip_button.Click += new System.EventHandler(this.search_ip_button_Click);
            // 
            // search_account_textBox
            // 
            this.search_account_textBox.Location = new System.Drawing.Point(10, 40);
            this.search_account_textBox.Name = "search_account_textBox";
            this.search_account_textBox.Size = new System.Drawing.Size(159, 20);
            this.search_account_textBox.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bilgiler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(6, 154);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(638, 329);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sunucu Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bir Hesapta Açılacak Maksimum Karakter Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sunucu Dili";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hesap Kayıt Türü";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sunucu Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.total_accounts_label);
            this.groupBox3.Controls.Add(this.total_blocked_accounts_label);
            this.groupBox3.Controls.Add(this.total_staff_accounts_label);
            this.groupBox3.Controls.Add(this.total_player_accounts_label);
            this.groupBox3.Controls.Add(this.total_player_accounts);
            this.groupBox3.Controls.Add(this.total_staff_accounts);
            this.groupBox3.Controls.Add(this.total_blocked_accounts);
            this.groupBox3.Controls.Add(this.total_accounts);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 142);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genel Bilgiler";
            // 
            // total_accounts_label
            // 
            this.total_accounts_label.AutoSize = true;
            this.total_accounts_label.Location = new System.Drawing.Point(154, 26);
            this.total_accounts_label.Name = "total_accounts_label";
            this.total_accounts_label.Size = new System.Drawing.Size(10, 13);
            this.total_accounts_label.TabIndex = 7;
            this.total_accounts_label.Text = "-";
            // 
            // total_blocked_accounts_label
            // 
            this.total_blocked_accounts_label.AutoSize = true;
            this.total_blocked_accounts_label.Location = new System.Drawing.Point(154, 57);
            this.total_blocked_accounts_label.Name = "total_blocked_accounts_label";
            this.total_blocked_accounts_label.Size = new System.Drawing.Size(10, 13);
            this.total_blocked_accounts_label.TabIndex = 6;
            this.total_blocked_accounts_label.Text = "-";
            // 
            // total_staff_accounts_label
            // 
            this.total_staff_accounts_label.AutoSize = true;
            this.total_staff_accounts_label.Location = new System.Drawing.Point(154, 88);
            this.total_staff_accounts_label.Name = "total_staff_accounts_label";
            this.total_staff_accounts_label.Size = new System.Drawing.Size(10, 13);
            this.total_staff_accounts_label.TabIndex = 5;
            this.total_staff_accounts_label.Text = "-";
            // 
            // total_player_accounts_label
            // 
            this.total_player_accounts_label.AutoSize = true;
            this.total_player_accounts_label.Location = new System.Drawing.Point(154, 114);
            this.total_player_accounts_label.Name = "total_player_accounts_label";
            this.total_player_accounts_label.Size = new System.Drawing.Size(10, 13);
            this.total_player_accounts_label.TabIndex = 4;
            this.total_player_accounts_label.Text = "-";
            // 
            // total_player_accounts
            // 
            this.total_player_accounts.AutoSize = true;
            this.total_player_accounts.Location = new System.Drawing.Point(15, 114);
            this.total_player_accounts.Name = "total_player_accounts";
            this.total_player_accounts.Size = new System.Drawing.Size(118, 13);
            this.total_player_accounts.TabIndex = 3;
            this.total_player_accounts.Text = "Toplam Oyuncu Hesabı";
            // 
            // total_staff_accounts
            // 
            this.total_staff_accounts.AutoSize = true;
            this.total_staff_accounts.Location = new System.Drawing.Point(15, 88);
            this.total_staff_accounts.Name = "total_staff_accounts";
            this.total_staff_accounts.Size = new System.Drawing.Size(109, 13);
            this.total_staff_accounts.TabIndex = 2;
            this.total_staff_accounts.Text = "Toplam Yetkili Hesabı";
            // 
            // total_blocked_accounts
            // 
            this.total_blocked_accounts.AutoSize = true;
            this.total_blocked_accounts.Location = new System.Drawing.Point(15, 57);
            this.total_blocked_accounts.Name = "total_blocked_accounts";
            this.total_blocked_accounts.Size = new System.Drawing.Size(113, 13);
            this.total_blocked_accounts.TabIndex = 1;
            this.total_blocked_accounts.Text = "Toplam Yasaklı Hesap";
            // 
            // total_accounts
            // 
            this.total_accounts.AutoSize = true;
            this.total_accounts.Location = new System.Drawing.Point(15, 26);
            this.total_accounts.Name = "total_accounts";
            this.total_accounts.Size = new System.Drawing.Size(106, 13);
            this.total_accounts.TabIndex = 0;
            this.total_accounts.Text = "Toplam Kayıtlı Hesap";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(650, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ayarlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 670);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label blocked_label;
        private System.Windows.Forms.ComboBox plevel_comboBox;
        private System.Windows.Forms.Label plevel_label;
        private System.Windows.Forms.Label lastconnectdate;
        private System.Windows.Forms.Label firstconnectdate;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pin;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox firstconnectdate_textBox;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox pin_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox account_textBox;
        private System.Windows.Forms.Label lastip;
        private System.Windows.Forms.Label firstip;
        private System.Windows.Forms.TextBox lastconnectdate_textBox;
        private System.Windows.Forms.ComboBox expansion_comboBox;
        private System.Windows.Forms.Label expansion_label;
        private System.Windows.Forms.TextBox totalconnecttime_textBox;
        private System.Windows.Forms.TextBox lastip_textBox;
        private System.Windows.Forms.TextBox firstip_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lastcharuid;
        private System.Windows.Forms.TextBox lastcharuid_textBox;
        private System.Windows.Forms.Button account_save_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox blocked_checkBox;
        private System.Windows.Forms.TextBox lang_textBox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Label totalconnecttime_label;
        private System.Windows.Forms.Label lastconnecttime_label;
        private System.Windows.Forms.Label lastconnecttime;
        private System.Windows.Forms.TextBox lastconnecttime_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox uuid_textBox;
        private System.Windows.Forms.Label uuid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label total_player_accounts;
        private System.Windows.Forms.Label total_staff_accounts;
        private System.Windows.Forms.Label total_blocked_accounts;
        private System.Windows.Forms.Label total_accounts;
        private System.Windows.Forms.Label total_player_accounts_label;
        private System.Windows.Forms.Label total_staff_accounts_label;
        private System.Windows.Forms.Label total_blocked_accounts_label;
        private System.Windows.Forms.Label total_accounts_label;
        private System.Windows.Forms.Button account_refresh_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pc_textBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button search_pc_button;
        private System.Windows.Forms.TextBox search_pc_textBox;
        private System.Windows.Forms.Label search_pc;
        private System.Windows.Forms.RadioButton filter_radioButton;
        private System.Windows.Forms.RadioButton filter_all_radioButton;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.Button search_account_button;
        private System.Windows.Forms.TextBox search_ip_textBox;
        private System.Windows.Forms.Label search_ip;
        private System.Windows.Forms.Label search_account;
        private System.Windows.Forms.Button search_ip_button;
        private System.Windows.Forms.TextBox search_account_textBox;
        private System.Windows.Forms.TextBox charcount_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox filter_blocked_checkBox;
        private System.Windows.Forms.CheckBox filter_player_checkBox;
        private System.Windows.Forms.CheckBox filter_staff_checkBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

