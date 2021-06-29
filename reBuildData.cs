using System;
using System.Windows.Forms;
using System.IO;

namespace AntonysApps.HouseShare
{
    public static class reBuildData
    {
        public enum reportBackStyle : byte
        {
            Noisy,
            Silent
        }

        public static void rebuildDataStore(reportBackStyle reportBack)
        {
            try
            {

                FileStream fs = new FileStream("datastore.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(HouseShare.Properties.Resources.blankstore);
                bw.Close();

                if (reportBack == reportBackStyle.Silent)
                {
                 return;   
                }

                else
                {
                    MessageBox.Show(null, "Database successfully rebuilt", "HouseShare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            catch
            {
                MessageBox.Show(null, "Error rebuilding database", "HouseShare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
