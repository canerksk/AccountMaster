using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountMaster
{
    internal static class Program
    {
        public static string AccountFolderPath = Path.Combine(Application.StartupPath, "accounts");
        public static string AccountFilePath = Path.Combine(Application.StartupPath, "accounts", "sphereaccu.scp");
        public static string SphereFilePath = Path.Combine(Application.StartupPath, "sphere.ini");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(AccountFolderPath))
            {
                MessageBox.Show("Accounts klasörü bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!File.Exists(AccountFilePath))
            {
                MessageBox.Show("Accounts dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Application.Run(new Form1());
        }
    }
}
