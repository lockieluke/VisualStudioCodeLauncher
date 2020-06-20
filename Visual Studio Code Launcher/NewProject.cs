using LibGit2Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Visual_Studio_Code_Launcher
{
    public partial class NewProject : MaterialForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        #region Project GitHub Links
        private List<string> projectTemplateUrls = new List<string>()
        {
            "https://github.com/electron/electron-quick-start.git", //Electron JS
            "https://github.com/spacecowboy/java-empty-project.git", //Java Empty Project
            "https://github.com/lockieluke/EmptySwiftProjectForVSCodeLauncher.git", //Swift Empty Project
            "https://github.com/dospat07/empty-vue-project.git", //Vue Project
            null, //DotNet Console
            "https://github.com/lockieluke/EmptyWebPageProjectForVSCodeLauncher.git", //Webpage Project
            null, //Javascript Empty Project
            null, //C# Empty Project
            "https://github.com/davidt22/symfony-empty-project", //Symfony Empty Project
            null, //Python Project
            null //PHP Empty Project
        };
        #endregion

        #region Project Link Exceptions
        private List<int> projectLinksExceptions = new List<int>()
        {
            4, //DotNet Console
            6, //Javascript Empty Project
            7, //C# Empty Project
            9, //Python Project
            10, //PHP Empty Project
        };
        #endregion

        string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public NewProject()
        {
            InitializeComponent();
            newProjectBtn.Enabled = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey200, Primary.Grey100, Primary.Grey900, Accent.Amber700, TextShade.BLACK);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            TitleManager.ChangeTitle(this, "New Project");
            scrollBar.Visible = false;
            scrollBar.Scroll += (sender, e) => { projPanel.VerticalScroll.Value = scrollBar.Value; };
        }

        private void projects_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (projects.SelectedItems != null && projects.SelectedItems.Count == 1)
            {
                newProjectBtn.Enabled = true;
            } else
            {
                newProjectBtn.Enabled = false;
            }
            for (int i = 0; i < projects.SelectedItems.Count; i++)
            {
                Console.WriteLine("Selected Index: " + projects.SelectedItems[0].Index + " Selected Name: " + projects.SelectedItems[0].Text);
            }
        }

        private void projects_Leave(object sender, System.EventArgs e)
        {
            
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            string vscodeLocation = File.ReadAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path"));

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select your project directory";
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            
            //New Project
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                TitleManager.ChangeTitle(this, "Opening Project in VSCode");
                int selectedIndex = projects.SelectedItems[0].Index;
                if (projectLinksExceptions.Contains(selectedIndex))
                {
                    if (!Directory.Exists(folderBrowserDialog.SelectedPath))
                        Directory.CreateDirectory(folderBrowserDialog.SelectedPath);

                    switch (selectedIndex)
                    {
                        case 4:
                            //DotNet Console
                            System.Diagnostics.Process cmdCreate = new System.Diagnostics.Process();
                            cmdCreate.StartInfo.FileName = "cmd.exe";
                            cmdCreate.StartInfo.RedirectStandardInput = true;
                            cmdCreate.StartInfo.RedirectStandardOutput = true;
                            cmdCreate.StartInfo.CreateNoWindow = true;
                            cmdCreate.StartInfo.UseShellExecute = false;
                            cmdCreate.Start();

                            cmdCreate.StandardInput.WriteLine("dotnet new console -o " + '\u0022' + folderBrowserDialog.SelectedPath + '\u0022');
                            cmdCreate.StandardInput.Flush();
                            cmdCreate.StandardInput.Close();
                            cmdCreate.WaitForExit();
                            Console.WriteLine(cmdCreate.StandardOutput.ReadToEnd());
                            break;

                        case 6:
                            //Javascript Empty Project
                            File.Create(Path.Combine(folderBrowserDialog.SelectedPath, "app.js"));
                            break;

                        case 7:
                            //C# Empty Project
                            File.Create(Path.Combine(folderBrowserDialog.SelectedPath, "app.cs"));
                            break;
                        case 9:
                            //PHP Empty Project
                            File.Create(Path.Combine(folderBrowserDialog.SelectedPath, "app.py"));
                            break;

                        case 10:
                            File.Create(Path.Combine(folderBrowserDialog.SelectedPath, "main.php"));
                            break;
                    }
                    openProjectInVSCode(folderBrowserDialog.SelectedPath);
                    var vscodeProcessLocal = System.Diagnostics.Process.GetProcessesByName("Code");
                    while (vscodeProcessLocal.Length == 0)
                    {

                    }
                    this.Focus();
                    Application.Exit();
                    Environment.Exit(0);
                } else
                {
                    try
                    {
                        Repository.Clone(projectTemplateUrls[selectedIndex], folderBrowserDialog.SelectedPath);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        Application.Restart();
                        Environment.Exit(0);
                        throw;
                    }
                    openProjectInVSCode(folderBrowserDialog.SelectedPath);
                }
                var vscodeProcess = System.Diagnostics.Process.GetProcessesByName("Code");
                while (vscodeProcess.Length == 0)
                {

                }
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void NewProject_Shown(object sender, EventArgs e)
        {
            if (File.ReadAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path")) == null || !Directory.Exists(File.ReadAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path"))))
            {
                setVSCodeLocation();
            }
            this.ContextMenuStrip = rightClickMenu;
        }

        private void vscodeLocationBtn_Click(object sender, EventArgs e)
        {
            setVSCodeLocation();
        }

        private void setVSCodeLocation()
        {
            FolderBrowserDialog vscodeLocation = new FolderBrowserDialog();
            vscodeLocation.Description = "Select Visual Studio Code installed location";
            DialogResult vscodedialogresult = vscodeLocation.ShowDialog();
            if (vscodedialogresult == DialogResult.OK && !string.IsNullOrWhiteSpace(vscodeLocation.SelectedPath))
            {
                Properties.Settings.Default["VSCodeLocation"] = vscodeLocation.SelectedPath;
                Properties.Settings.Default.Save();
                if (!Directory.Exists(Path.Combine(AppDataPath, "VSCode Launcher")))
                    Directory.CreateDirectory(Path.Combine(AppDataPath, "VSCode Launcher"));

                File.WriteAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path"), vscodeLocation.SelectedPath);
            } else
            {
                if (File.ReadAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path")) == null || !Directory.Exists(File.ReadAllText(Path.Combine(AppDataPath, "VSCode Launcher", "vspath.path"))))
                {
                    MessageBox.Show("The projects you created here may be opened with Visual Studio Code because you didn't select the installation path.");
                } else
                {
                    MessageBox.Show("VSCode Launcher will keep using the old installation path until you change it.");
                }
            }
        }

        private void consoleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consoleModeInstance = new ConsoleMode();
            consoleModeInstance.ShowDialog();
        }

        private void NewProject_Enter(object sender, EventArgs e)
        {
            if (this.Text.Contains("Opening Project in VSCode"))
            {
                TitleManager.ChangeTitle(this, "New Project");
            }
        }

        private void openProjectInVSCode(string path)
        {
            System.Diagnostics.Process.Start(@"vscode://file/" + path.Replace(@"\", "/"));
            Console.WriteLine(@"vscode://file/" + path.Replace(@"\", "/"));
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                openProjectInVSCode(folderBrowserDialog.SelectedPath);
                var vscodeProcess = System.Diagnostics.Process.GetProcessesByName("Code");
                while (vscodeProcess.Length == 0)
                {

                }
                Application.Exit();
                Environment.Exit(0);
            }
        }
    }
}