using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public partial class mainFrm : Form
    {
        long[] HIDs;
        bool[] paymentConfs;

        string versionNumber = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString()
            + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();

      
        public mainFrm()
        {
            InitializeComponent();
            aboutLbl.Text = "v" + versionNumber;
            if (System.IO.File.Exists(@"datastore.dat") == false)
            {
                reBuildData.rebuildDataStore(reBuildData.reportBackStyle.Silent);
            }

            getHousesList();
        }

        private void getHousesList()
        {
            housesCB.Items.Clear();
            HIDs = null;

            SQLiteDataAdapter da = new SQLiteDataAdapter(queries.getHousesQ, connection.conn);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    HIDs = new long[ds.Tables[0].Rows.Count];
                    paymentConfs = new bool[ds.Tables[0].Rows.Count];

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        housesCB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                        HIDs[i] = (long)ds.Tables[0].Rows[i][0];
                        paymentConfs[i] = (bool)ds.Tables[0].Rows[i][2];
                    }
                }

                housesCB.Items.Add("Enter Setup");
                housesCB.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }

        }
        private void openHouseButt_Click(object sender, EventArgs e)
        {
            if (housesCB.SelectedItem.ToString() == "Enter Setup")
            {
                setUp setUpFrm = new setUp();
                setUpFrm.ShowDialog();
                getHousesList();
            }
            else
            {
                openHouse OpenHouseFrm = new openHouse(HIDs[housesCB.SelectedIndex],paymentConfs[housesCB.SelectedIndex]);
                OpenHouseFrm.ShowDialog();
            }
        }

        private void websiteLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(websiteLinkLbl.Text);
        }

    }




}
