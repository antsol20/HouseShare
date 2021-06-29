using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public partial class openHouse : Form
    {
        private readonly long houseID;
        private readonly bool paymentConf;

        long[] HMIDs;
        long[] billTypeIDs;
        double[] hmBals;


        public openHouse(long _houseID, bool _paymentConf)
        {
            InitializeComponent();
            houseID = _houseID;
            paymentConf = _paymentConf;
            populate();
        }

        private void populate()
        {
     
            HMIDs = null;
            hmBals = null;

            houseMatesLB.Items.Clear();
            matesBalLB.Items.Clear();
            hmBalLB.Items.Clear();
            houseMatesCB.Items.Clear();
            billTypeCB.Items.Clear();

            payIn1TB.Text = "";
            payIn2TB.Text = "";
            payInDT.Value = DateTime.Today;

            payOut1TB.Text = "";
            payOut2TB.Text = "";
            payOutNotes.Text = "Notes";
            payOutDT.Value = DateTime.Today;

            DataSet ds;
            SQLiteDataAdapter da;

            try
            {

                ////////////

                da = new SQLiteDataAdapter(queries.getHouseDetailsQ, connection.conn);
                ds = new DataSet();

                da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
                da.Fill(ds);
                this.Text = "HouseShare - " + ds.Tables[0].Rows[0][0].ToString();


                HMIDs = new long[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    HMIDs[i] = (long)(ds.Tables[0].Rows[i][1]);
                }

                //////////


                da = new SQLiteDataAdapter(queries.getTotalInQ, connection.conn);
                ds = new DataSet();

                da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
                da.Fill(ds);

                double totalIn = (double)ds.Tables[0].Rows[0][0];
                
                /////////

                da = new SQLiteDataAdapter(queries.getTotalOutQ, connection.conn);
                ds = new DataSet();

                da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
                da.Fill(ds);

                double totalOut = (double)ds.Tables[0].Rows[0][0];
               
                //////////////////

                double totalBal = totalOut - totalIn;
                totalBalOSLbl.Text = Math.Round(totalBal, 2).ToString("N2");
                /////////////////

                da = new SQLiteDataAdapter(queries.getHouseBalsQ, connection.conn);
                ds = new DataSet();

                da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
                da.Fill(ds);

                hmBals = new double[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    houseMatesLB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                    houseMatesCB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                    hmBals[i] = (double)ds.Tables[0].Rows[i][2];
                    matesBalLB.Items.Add(String.Format("{0:0.00}", ds.Tables[0].Rows[i][2]));
                  
                }
                /////////////////////

                double owedPP = totalOut / HMIDs.Length;

                for (int i = 0; i < hmBals.Length; i++)
                {
                    double x = owedPP - hmBals[i];
                    hmBalLB.Items.Add(x.ToString("N2"));
                }

                //////////////

                da = new SQLiteDataAdapter(queries.getBillTypesQ, connection.conn);
                ds = new DataSet();
                da.Fill(ds);

                billTypeIDs = new long[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    billTypeCB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                    billTypeIDs[i] = (long)ds.Tables[0].Rows[i][0];

                }

                //////////////////


            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }

        }

        private void enterPayInButt_Click(object sender, EventArgs e)
        {
            if (houseMatesCB.SelectedItem == null || payIn1TB.Text == "" || payInDT.Value == null)
            {
                return;
            }
            if (payIn2TB.Text == "")
            {
                payIn2TB.Text = "00";
            }

            double payInAmount = Convert.ToDouble(payIn1TB.Text + "." + payIn2TB.Text);

            if (paymentConf == true)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Enter Payment In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    enterPayIn(HMIDs[houseMatesCB.SelectedIndex], payInAmount, payInDT.Value);
                }
            }
            else
            {
                enterPayIn(HMIDs[houseMatesCB.SelectedIndex], payInAmount, payInDT.Value);
                
            }
        }

        private void enterPayIn(long HMID, double payInAmount, DateTime payInDT)
        {
            try
            {
                connection.conn.Open();
                SQLiteCommand comm = new SQLiteCommand(queries.enterPayInQ, connection.conn);
                comm.Parameters.AddWithValue("@HMID", HMID);
                comm.Parameters.AddWithValue("@payInAmount", payInAmount);
                comm.Parameters.AddWithValue("@dt", payInDT);

                comm.ExecuteNonQuery();
                connection.conn.Close();
                populate();

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void enterPayOutButt_Click(object sender, EventArgs e)
        {
            if (billTypeCB.SelectedItem == null || payOut1TB.Text == "" || payOutDT.Value == null)
            {

                return;

            }
            if (payOut2TB.Text == "")
            {
                payOut2TB.Text = "00";
            }

            double payOutAmount = Convert.ToDouble(payOut1TB.Text + "." + payOut2TB.Text);

            if (paymentConf == true)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Enter Payment Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    enterPayOut(houseID, billTypeIDs[billTypeCB.SelectedIndex], payOutAmount, payOutNotes.Text, payOutDT.Value);
                }
            }
            else
            {
                enterPayOut(houseID, billTypeIDs[billTypeCB.SelectedIndex], payOutAmount, payOutNotes.Text, payOutDT.Value);
            }
        }
        private void enterPayOut(long HID, long billType, double payOutAmount, string notes, DateTime payInDT)
        {

            try
            {
                connection.conn.Open();

                SQLiteCommand comm = new SQLiteCommand(queries.enterPayOutQ, connection.conn);
                comm.Parameters.AddWithValue("@HID", HID);
                comm.Parameters.AddWithValue("@billType", billType);
                comm.Parameters.AddWithValue("@payOutAmount", payOutAmount);
                comm.Parameters.AddWithValue("@notes", notes);
                comm.Parameters.AddWithValue("@dt", payInDT);

                comm.ExecuteNonQuery();
                connection.conn.Close();

                populate();

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }
            finally
            {
                connection.conn.Close();

            }
        }


        private void payOutNotes_MouseClick(object sender, MouseEventArgs e)
        {
           payOutNotes.SelectAll();
        }

        private void viewPaymentsButt_Click(object sender, EventArgs e)
        {
            Form paymentDataFrm = new paymentData(houseID);

            DialogResult delResult = paymentDataFrm.ShowDialog();

            if (delResult == DialogResult.Yes)
            {
                populate();
            }
        }
      
    }
}
