using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Code_Launcher
{
    internal class TitleManager
    {
        internal static void ChangeTitle(MaterialForm materialForm, string title)
        {
            materialForm.Text = "VSCode Launcher - " + title;
        }
    }
}
