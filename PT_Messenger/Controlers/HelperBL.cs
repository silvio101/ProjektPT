using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Messenger.Controlers
{
    public class Person
    {
        public string login { get; set; }
        public string username { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
    }
    class HelperBL
    {
        public System.Drawing.Color color;
        public void changeAvatar(string filename, string path)
        {
            try
            {
                PT_Messenger.Properties.Settings.Default.avatar_path=path;
                PT_Messenger.Properties.Settings.Default.avatar = filename;
                PT_Messenger.Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }
        public System.Drawing.Color whichColor()
        {
            color = new System.Drawing.Color();
            switch (PT_Messenger.Properties.Settings.Default.skin)
            {
                case 0:
                    color=System.Drawing.SystemColors.ActiveCaption;
                    break;
                case 1: 
                    color=System.Drawing.Color.Lime;
                    break;
                case 2:
                    color=System.Drawing.Color.Gray;
                    break;
                default:
                    color=System.Drawing.SystemColors.ActiveCaption;
                    break;
            }
            return color;
        }
        public void changeServer(string newServer)
        {
            try
            {
                PT_Messenger.Properties.Settings.Default.server = newServer;
                PT_Messenger.Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void changeSkin(int newIndex)
        {
            try
            {
                PT_Messenger.Properties.Settings.Default.skin = newIndex;
                PT_Messenger.Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void restoreDefaultAvatar()
        {
            try
            {
                PT_Messenger.Properties.Settings.Default.avatar_path = "local";
                PT_Messenger.Properties.Settings.Default.avatar = "unknown_person_100";
                PT_Messenger.Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Nie można zmienić avatar'a, prawdopodobny błąd zapisu pliku konfiguracyjnego", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string getAvatarName()
        {
            return PT_Messenger.Properties.Settings.Default.avatar;
        }
    }
}
