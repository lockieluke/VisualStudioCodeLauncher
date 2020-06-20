using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace Visual_Studio_Code_Launcher
{
    public partial class ConsoleMode : MaterialForm
    {
        public ConsoleMode()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey200, Primary.Grey100, Primary.Grey900, Accent.Amber700, TextShade.BLACK);

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    CreateNoWindow = false,
                    WindowStyle = ProcessWindowStyle.Normal
                }
            };
            process.Start();
        }
    }
}
