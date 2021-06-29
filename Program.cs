using System;
using System.Windows.Forms;


namespace AntonysApps.HouseShare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            alreadyRunningCheck();

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainFrm());

            }
            else
            {
                if (args[0].ToString().ToLower() == "-rebuild")
                {
                    DialogResult result = MessageBox.Show("Rebuilding database will delete all stored data. Are you sure you wish to proceed?", "HouseShare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        reBuildData.rebuildDataStore(reBuildData.reportBackStyle.Noisy);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Invalid Argument", "HouseShare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
        static void alreadyRunningCheck()
        {
            System.Diagnostics.Process c = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName(c.ProcessName);

            if (p.GetUpperBound(0) <= 0)
            {
                return;
            }

            else
            {
                string alreadyRunningMsg = "A copy of HouseShare is already running";
                string alreadyRunningTitle = "HouseShare";
                MessageBox.Show(alreadyRunningMsg, alreadyRunningTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(-1);
            }
        }
    }

}

