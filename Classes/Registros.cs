using Microsoft.Win32;
using System.Windows.Forms;

namespace LAUNCHERMUWINDOWSFORMS.Classes
{
    static class Registros
    {
        static readonly RegistryKey SoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);

        public static void IniciarRegistro()
        {
            RegistryKey InitRegistro = Registry.CurrentUser.OpenSubKey(@"Software\Webzen\Mu\Config");
            if (InitRegistro == null)
            {
                RegistryKey RegistroMu = Registry.CurrentUser.CreateSubKey(@"Software\Webzen\Mu\Config", RegistryKeyPermissionCheck.ReadWriteSubTree);

                RegistroMu.SetValue("Resolution", 2);
                    RegistroMu.SetValue("SoundOnOff", 1);
                    RegistroMu.SetValue("MusicOnOff", 1);
                    RegistroMu.SetValue("WindowMode", 0);
                    RegistroMu.SetValue("ID", "Seu Log in");
                
            }         
        }
        public static void SetValor(TextBox login, ComboBox comboBox,CheckBox chMusic,CheckBox windowmode)
        {
            using (RegistryKey Webzen = SoftwareKey.OpenSubKey("Webzen"), Mu = Webzen.OpenSubKey("Mu"), Config = Mu.OpenSubKey("Config",RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                Config.SetValue("ID", login.Text);

                switch(comboBox.SelectedItem.ToString().Trim())
                {
                    case "640x480":
                        Config.SetValue("Resolution", 0);
                        break;
                    case "800x600":
                        Config.SetValue("Resolution", 1);
                        break;
                    case "1024x768":
                        Config.SetValue("Resolution", 2);
                        break;
                    case "1280x1024":
                        Config.SetValue("Resolution", 3);
                        break;
                }
                if(chMusic.Checked == true)
                {
                    Config.SetValue("MusicOnOff", 1);
                    Config.SetValue("SoundOnOff", 1);
                }
                else
                {
                    Config.SetValue("MusicOnOff", 0);
                    Config.SetValue("SoundOnOff", 0);
                }

                if (windowmode.Checked == true)
                {
                    Config.SetValue("WindowMode", 1);
                }
                else
                {
                    Config.SetValue("WindowMode", 0);
                }
            }
        }
        public static void GetValor(TextBox login, ComboBox comboBox,CheckBox chMusic,CheckBox windowmode)
        {
            using (RegistryKey Webzen = SoftwareKey.OpenSubKey("Webzen"), Mu = Webzen.OpenSubKey("Mu"), Config = Mu.OpenSubKey("Config"))
            {
                login.Text = Config.GetValue("ID").ToString();
                
                switch(Config.GetValue("Resolution").ToString())
                {
                    case "0":
                        comboBox.Text = "640x480";
                        break;

                    case "1":
                        comboBox.Text = "800x600";
                        break;
                    case "2":
                        comboBox.Text = "1024x768";
                        break;
                    case "3":
                        comboBox.Text = "1280x1024";
                        break;


                }

               switch(Config.GetValue("SoundOnOff").ToString())
                {
                    case "0":
                        chMusic.Checked = false;
                        break;
                    case "1":
                        chMusic.Checked = true;
                        break;
                }

                switch (Config.GetValue("MusicOnOff").ToString())
                {
                    case "0":
                        chMusic.Checked = false;
                        break;
                    case "1":
                        chMusic.Checked = true;
                        break;
                }

                switch(Config.GetValue("WindowMode").ToString())
                {
                    case "0":
                        windowmode.Checked = false;
                        break;
                    case "1":
                        windowmode.Checked = true;
                        break;

                }
            }

        }
    }
}
