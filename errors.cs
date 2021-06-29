using System;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public class errors
    {
        public static void databaseCorrupt(Exception ex)
        {
            MessageBox.Show("Error message:\n" + ex.ToString() + "\n\nError connecting to/in database. Database is missing/corrupt. If unable to resolve try running\n\tHouseshare.exe -rebuild", "HouseShare", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

}
