using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_Messenger.contolers
{
    class HelperBL
    {
        public System.Drawing.Color color;
        public void changeAvatar()
        {
            
            

        }
        public System.Drawing.Color whichColor()
        {
            color = new System.Drawing.Color();
            switch (Properties.Settings.Default.skin)
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
    }
}
