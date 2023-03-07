using IniFile;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountMaster
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Program.SphereFilePath))
            {
                var SphereIniFile = new IniFile.IniFile(Program.SphereFilePath);
                string SphereName = SphereIniFile.Section("SPHERE").Get("ServName");
                this.Text += " (" + SphereName + ")";
            }

            getAccountList();
        }

        public void getAccount(string accountName)
        {

            var iniFile = new IniFile.IniFile(Program.AccountFilePath);
            //iniFile.Section("PASSWORD=").Get<int>("bar"); // 1

            accountName = accountName.Replace("[", "");
            accountName = accountName.Replace("]", "");

            account_textBox.Text = accountName;

            // UUID
            var _uuid = iniFile.Section(accountName).Get("TAG.KAYIT_USER_UUID");
            if (_uuid != null)
            {
                uuid_textBox.Text = _uuid.Replace("\"", string.Empty).Trim();
            }

            // ID
            var _id = iniFile.Section(accountName).Get("TAG.KAYIT_USER_ID");
            if (_id != null)
            {
                id_textBox.Text = _id.Replace("\"", string.Empty).Trim();
            }

            password_textBox.Text = iniFile.Section(accountName).Get("PASSWORD");
            mail_textBox.Text = iniFile.Section(accountName).Get("MAIL");
            pin_textBox.Text = iniFile.Section(accountName).Get("PIN");
            firstconnectdate_textBox.Text = iniFile.Section(accountName).Get("FIRSTCONNECTDATE");
            lastconnectdate_textBox.Text = iniFile.Section(accountName).Get("LASTCONNECTDATE");
            firstip_textBox.Text = iniFile.Section(accountName).Get("FIRSTIP");
            lastip_textBox.Text = iniFile.Section(accountName).Get("LASTIP");
            lang_textBox.Text = iniFile.Section(accountName).Get("LANG");
            var _pcid = iniFile.Section(accountName).Get("TAG.PCID");
            if (_pcid != null)
            {
                pc_textBox.Text = _pcid.Replace("\"", string.Empty).Trim();
            }


            // Total Connect Time
            totalconnecttime_textBox.Text = string.Empty;
            totalconnecttime_label.Text = string.Empty;
            var _totalconnecttime = iniFile.Section(accountName).Get("TOTALCONNECTTIME");
            if (_totalconnecttime != null)
            {
                var TotalConnectTime = int.Parse(_totalconnecttime, NumberStyles.AllowLeadingSign);
                TimeSpan t1 = TimeSpan.FromMinutes(TotalConnectTime);
                totalconnecttime_textBox.Text = TotalConnectTime.ToString();
                totalconnecttime_label.Text = string.Format("{0:D2}sa, {1:D2}dk ,{2:D2}sn", t1.Hours, t1.Minutes, t1.Seconds);
            }

            // Last Connect Time
            lastconnecttime_textBox.Text = string.Empty;
            lastconnecttime_label.Text = string.Empty;
            var _lastconnecttime = iniFile.Section(accountName).Get("LASTCONNECTTIME");
            if (_lastconnecttime != null)
            {
                var LastConnectTime = int.Parse(_lastconnecttime, NumberStyles.AllowLeadingSign);
                TimeSpan t2 = TimeSpan.FromMinutes(LastConnectTime);
                lastconnecttime_textBox.Text = LastConnectTime.ToString();
                lastconnecttime_label.Text = string.Format("{0:D2}sa, {1:D2}dk ,{2:D2}sn", t2.Hours, t2.Minutes, t2.Seconds);
            }

            // LastCharUid
            lastcharuid_textBox.Text = iniFile.Section(accountName).Get("LASTCHARUID");

            // Char Count
            charcount_textBox.Text = string.Empty;
            

            // Expansion
            var _resdisp = iniFile.Section(accountName).Get("RESDISP");
            if (_resdisp != null)
            {
                int ResDisp = int.Parse(_resdisp, NumberStyles.AllowLeadingSign);
                expansion_label.Text = "Expansion (" + ResDisp + ")";
                if (ResDisp > 0)
                {
                    expansion_comboBox.SelectedIndex = ResDisp;
                }
            }

            // Blocked
            var _blocked = iniFile.Section(accountName).Get("BLOCK");
            if (_blocked != null)
            {
                int Blocked = int.Parse(_blocked, NumberStyles.AllowLeadingSign);
                blocked_checkBox.Checked = Blocked == 1 ? true : false;
            }
            else
            {
                blocked_checkBox.Checked = false;
            }

            // Plevel
            plevel_comboBox.SelectedIndex = 0;
            var _plevel = iniFile.Section(accountName).Get("PLEVEL");
            if (_plevel != null)
            {
                if (_plevel == "Player")
                    plevel_comboBox.SelectedIndex = 0;
                if (_plevel == "Counselor")
                    plevel_comboBox.SelectedIndex = 1;
                if (_plevel == "Seer")
                    plevel_comboBox.SelectedIndex = 2;
                if (_plevel == "GM")
                    plevel_comboBox.SelectedIndex = 3;
                if (_plevel == "Dev")
                    plevel_comboBox.SelectedIndex = 4;
                if (_plevel == "Admin")
                    plevel_comboBox.SelectedIndex = 5;
                if (_plevel == "Owner")
                    plevel_comboBox.SelectedIndex = 6;
            }
        }


        public void ClearAccountElements()
        {
            lastcharuid_textBox.Text = lastconnecttime_textBox.Text = lastconnecttime_label.Text = string.Empty;

            totalconnecttime_textBox.Text = string.Empty;
            totalconnecttime_label.Text = string.Empty;
            account_textBox.Text = string.Empty;
            uuid_textBox.Text = string.Empty;
            id_textBox.Text = string.Empty;
            password_textBox.Text = string.Empty;
            mail_textBox.Text = string.Empty;
            pin_textBox.Text = string.Empty;
            firstconnectdate_textBox.Text = string.Empty;
            lastconnectdate_textBox.Text = string.Empty;
            firstip_textBox.Text = string.Empty;
            lastip_textBox.Text = string.Empty;
            lang_textBox.Text = string.Empty;

            expansion_comboBox.SelectedIndex = -1;

            blocked_checkBox.Checked = false;

            plevel_comboBox.SelectedIndex = -1;

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }

        }


        public void getAccountList()
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var iniFile = new IniFile.IniFile(Program.AccountFilePath);
            listBox1.Items.Clear();
            int PlayerAccountCount = 0;
            int StaffAccountCount = 0;
            int BlockedAccountCount = 0;
            int TotalAccountCount = 0;
            string Priv = string.Empty;
            int Block = 0;

            foreach (var section in iniFile.Sections)
            {
                listBox1.Items.Add(section.Name);


                // Acc Say
                var _priv = iniFile.Section(section.Name).Get("PRIV");
                if (_priv != null)
                {
                    Priv = _priv.ToString();
                    if (Priv == "00")
                    {
                        PlayerAccountCount++;
                    }
                    if (Priv == "0a" || Priv == "02a")
                    {
                        StaffAccountCount++;
                    }
                }

                var _block = iniFile.Section(section.Name).Get("BLOCK");
                if (_block != null)
                {
                    Block = int.Parse(_block);
                    if (Block == 1)
                    {
                        BlockedAccountCount++;
                    }
                }


            }

            TotalAccountCount = BlockedAccountCount + PlayerAccountCount + StaffAccountCount;

            total_accounts_label.Text = TotalAccountCount.ToString();
            total_blocked_accounts_label.Text = BlockedAccountCount.ToString();
            total_player_accounts_label.Text = PlayerAccountCount.ToString();
            total_staff_accounts_label.Text = StaffAccountCount.ToString();

            ClearAccountElements();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            if (curItem != null)
            {
                int index = listBox1.FindString(curItem);
                if (index == -1)
                {
                    MessageBox.Show("Bir hesap seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    getAccount(listBox1.SelectedItem.ToString());
                }
            }
        }


        private void refresh_button_Click(object sender, EventArgs e)
        {
            getAccountList();
        }



        private void account_save_button_Click(object sender, EventArgs e)
        {
            var iniFile = new IniFile.IniFile(Program.AccountFilePath);

            var AccountName = account_textBox.Text;
            // Lang Save
            int _expansion = expansion_comboBox.SelectedIndex;
            if (_expansion != -1)
            {
                iniFile.Section(AccountName).Set("RESDISP", _expansion.ToString());
            }
            string _plevel = plevel_comboBox.SelectedItem.ToString();
            iniFile.Section(AccountName).Set("PLEVEL", _plevel.ToString());

            iniFile.Section(AccountName).Set("LANG", lang_textBox.Text);
            iniFile.Section(AccountName).Set("MAIL", mail_textBox.Text);
            iniFile.Section(AccountName).Set("TOTALCONNECTTIME", totalconnecttime_textBox.Text);
            iniFile.Section(AccountName).Set("LASTCONNECTTIME", lastconnecttime_textBox.Text);
            iniFile.Save(Program.AccountFilePath);

            MessageBox.Show("Değişiklikler kayıt edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void account_refresh_button_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            if (curItem != null)
            {
                int index = listBox1.FindString(curItem);
                if (index == -1)
                {
                    MessageBox.Show("Bir hesap seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    getAccount(listBox1.SelectedItem.ToString());
                }
            }
        }



        private void search_ip_button_Click(object sender, EventArgs e)
        {

            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(search_ip_textBox.Text))
            {
                MessageBox.Show("IP adresi giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var iniFile = new IniFile.IniFile(Program.AccountFilePath);
            listBox1.Items.Clear();

            foreach (var section in iniFile.Sections)
            {
                var _search = iniFile.Section(section.Name).Get("LASTIP");
                if (_search != null)
                {
                    //Console.WriteLine(_search + ":" + search_ip_textBox.Text.ToString());

                    if (_search.Contains(search_ip_textBox.Text.ToString()))
                        //Console.WriteLine(_search);
                        listBox1.Items.Add(section.Name);
                }
            }

        }

        private void search_pc_button_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!");
                return;
            }
            if (string.IsNullOrEmpty(search_pc_textBox.Text))
            {
                MessageBox.Show("PC numarası giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var iniFile = new IniFile.IniFile(Program.AccountFilePath);
            listBox1.Items.Clear();

            foreach (var section in iniFile.Sections)
            {
                var _search = iniFile.Section(section.Name).Get("TAG.PCID");
                if (_search != null)
                {
                    if (_search.Contains(search_pc_textBox.Text.ToString()))
                        //Console.WriteLine(_search);
                        listBox1.Items.Add(section.Name);
                }
            }

        }


        private void search_account_button_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(search_account_textBox.Text))
            {
                MessageBox.Show("Hesap adı giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = listBox1.FindString(search_account_textBox.Text.ToString());
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("Hesap bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void filter_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_radioButton.Checked == true)
            {
                filter_staff_checkBox.Visible = true;
                filter_blocked_checkBox.Visible = true;
                filter_player_checkBox.Visible = true;
            }
            else
            {
                filter_staff_checkBox.Visible = false;
                filter_blocked_checkBox.Visible = false;
                filter_player_checkBox.Visible = false;
            }

        }

        private void filter_all_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_all_radioButton.Checked == true)
            {
                filter_staff_checkBox.Visible = false;
                filter_blocked_checkBox.Visible = false;
                filter_player_checkBox.Visible = false;
            }
            else
            {
                filter_staff_checkBox.Visible = true;
                filter_blocked_checkBox.Visible = true;
                filter_player_checkBox.Visible = true;
            }
        }

        private void filter_staff_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!");
                return;
            }
            if (filter_staff_checkBox.Checked == true)
            {
                var iniFile = new IniFile.IniFile(Program.AccountFilePath);
                listBox1.Items.Clear();

                foreach (var section in iniFile.Sections)
                {
                    var _search = iniFile.Section(section.Name).Get("PRIV");
                    if (_search != null)
                    {
                        if (_search != "00")
                            listBox1.Items.Add(section.Name);
                    }
                }
            }
            else
            {
                getAccountList();
            }
        }

        private void filter_player_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!");
                return;
            }
            if (filter_player_checkBox.Checked == true)
            {
                var iniFile = new IniFile.IniFile(Program.AccountFilePath);
                listBox1.Items.Clear();

                foreach (var section in iniFile.Sections)
                {
                    var _search = iniFile.Section(section.Name).Get("PRIV");
                    if (_search != null)
                    {
                        if (_search == "00")
                            listBox1.Items.Add(section.Name);
                    }
                }
            }
            else
            {
                getAccountList();
            }
        }

        private void filter_blocked_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!File.Exists(Program.AccountFilePath))
            {
                MessageBox.Show("Account dosyası bulunamadı!");
                return;
            }
            if (filter_blocked_checkBox.Checked == true)
            {
                var iniFile = new IniFile.IniFile(Program.AccountFilePath);
                listBox1.Items.Clear();

                foreach (var section in iniFile.Sections)
                {
                    var _search = iniFile.Section(section.Name).Get("BLOCK");
                    if (_search != null)
                    {
                        if (int.Parse(_search) == 1)
                            listBox1.Items.Add(section.Name);
                    }
                }
            }
            else
            {
                getAccountList();
            }
        }


    }
}
