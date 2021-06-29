using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public partial class setUp : Form
    {
        DataSet ds;
        SQLiteDataAdapter da;

        public enum renameType : byte
        {
            House,
            Bill,
            Housemate
        }

        long[] HMIDs;
        long[] HIDs;
        long[] billTypeIDs;

        string[] HMNames;
        string[] HNames;
        string[] billTypeNames;

        bool firstTimeSettings = true;

        public setUp()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            HMIDs = null;

            houseMatesLB.Items.Clear();
            housesLB.Items.Clear();
            housesCB.Items.Clear();
            housesCB2.Items.Clear();
            paymentConfChB.Enabled = false;
            billTypesLB.Items.Clear();

            addHouseTB.Text = "";
            addHouseMateTB.Text = "";
            addBillTypeTB.Text = "";

            try
            {

                ////////////

                da = new SQLiteDataAdapter(queries.getHousesQ, connection.conn);
                ds = new DataSet();

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    HIDs = new long[ds.Tables[0].Rows.Count];
                    HNames = new string[ds.Tables[0].Rows.Count];

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        housesLB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                        housesCB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                        housesCB2.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                        HIDs[i] = (long)ds.Tables[0].Rows[i][0];
                        HNames[i] = ds.Tables[0].Rows[i][1].ToString();

                    }
                }

                ////////////

                da = new SQLiteDataAdapter(queries.getBillTypesQ, connection.conn);
                ds = new DataSet();

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    billTypeIDs = new long[ds.Tables[0].Rows.Count];
                    billTypeNames = new string[ds.Tables[0].Rows.Count];

                    string test = ds.Tables[0].Rows[0][0].GetType().ToString();

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        billTypesLB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                        billTypeIDs[i] = (Int64)ds.Tables[0].Rows[i][0];
                        billTypeNames[i] = ds.Tables[0].Rows[i][1].ToString();
                    }
                }


                ///////////

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);

            }

        }

        private void housesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            houseMatesLB.Items.Clear();
            HMIDs = null;

            da = new SQLiteDataAdapter(queries.getHouseMatesQ, connection.conn);
            ds = new DataSet();

            long houseID = HIDs[housesCB.SelectedIndex];

            da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                HMIDs = new long[ds.Tables[0].Rows.Count];
                HMNames = new string[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    houseMatesLB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                    HMIDs[i] = (long)ds.Tables[0].Rows[i][0];
                    HMNames[i] = ds.Tables[0].Rows[i][1].ToString();

                }
            }
        }

        private void renameHouseButt_Click(object sender, EventArgs e)
        {
            if (housesLB.SelectedIndex != -1)
            {
                long idSelected = HIDs[housesLB.SelectedIndex];
                string nameSelected = HNames[housesLB.SelectedIndex];

                renameDialog renameDialogFrm = new renameDialog(idSelected, nameSelected, renameType.House);
                DialogResult result = renameDialogFrm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    populate();
                }
            }

        }

        private void renameBillTypeButt_Click(object sender, EventArgs e)
        {
            if (billTypesLB.SelectedIndex != -1)
            {
                long idSelected = billTypeIDs[billTypesLB.SelectedIndex];
                string nameSelected = billTypeNames[billTypesLB.SelectedIndex];

                renameDialog renameDialogFrm = new renameDialog(idSelected, nameSelected, renameType.Bill);
                DialogResult result = renameDialogFrm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    populate();
                }
            }
        }

        private void renameHMButt_Click(object sender, EventArgs e)
        {
            if (houseMatesLB.SelectedIndex != -1)
            {
                long idSelected = HMIDs[houseMatesLB.SelectedIndex];
                string nameSelected = HMNames[houseMatesLB.SelectedIndex];

                renameDialog renameDialogFrm = new renameDialog(idSelected, nameSelected, renameType.Housemate);
                DialogResult result = renameDialogFrm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    populate();
                }
            }
        }

        private void addHouseButt_Click(object sender, EventArgs e)
        {
            if (addHouseTB.Text == "")
            {
                return;
            }

            if (housesLB.Items.Contains(addHouseTB.Text) == true)
            {
                MessageBox.Show(null, "House name must be unique", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addHouse(addHouseTB.Text) == true)
            {
                MessageBox.Show(null, "Successful", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                return;
            }
            else
            {
                MessageBox.Show(null, "Unsuccessful. Could not add house to database", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool addHouse(string houseToAdd)
        {
            SQLiteCommand comm;
            SQLiteDataAdapter da;
            DataSet ds;

            try
            {
                connection.conn.Open();

                comm = new SQLiteCommand(queries.addNewHouse1Q, connection.conn);
                comm.Parameters.AddWithValue("@houseNameToAdd", houseToAdd);
                comm.ExecuteNonQuery();


                da = new SQLiteDataAdapter(queries.getNewHIDQ, connection.conn);
                ds = new DataSet();


                da.SelectCommand.Parameters.AddWithValue("@houseNameToAdd", houseToAdd);
                da.Fill(ds);

                long newHID = (long)ds.Tables[0].Rows[0][0];

                comm = new SQLiteCommand(queries.addNewHouseMate1Q, connection.conn);
                comm.Parameters.AddWithValue("@newHID", newHID);
                comm.Parameters.AddWithValue("@Fname", "Housemate 1");
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.addNewHouse2Q, connection.conn);
                comm.Parameters.AddWithValue("@newHID", newHID);
                comm.ExecuteNonQuery();

                da = new SQLiteDataAdapter(queries.getNewHMIDQ, connection.conn);
                ds = new DataSet();


                da.SelectCommand.Parameters.AddWithValue("@newHID", newHID);
                da.SelectCommand.Parameters.AddWithValue("@Fname", "Housemate 1");
                da.Fill(ds);

                long newHMID = (long)ds.Tables[0].Rows[0][0];

                comm = new SQLiteCommand(queries.addNewHouseMate2Q, connection.conn);
                comm.Parameters.AddWithValue("@newHMID", newHMID);
                comm.ExecuteNonQuery();


                connection.conn.Close();

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;
            }
            finally
            {
                connection.conn.Close();

            }

            return true;

        }


        private bool addBillType(string newBillType)
        {
            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.addBillTypeQ, connection.conn);
                comm.Parameters.AddWithValue("@description", newBillType);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void addBillTypeButt_Click(object sender, EventArgs e)
        {
            if (addBillTypeTB.Text == "")
            {
                return;
            }

            if (billTypesLB.Items.Contains(addBillTypeTB.Text) == true)
            {
                MessageBox.Show(null, "Bill type description must be unique", "Add Bill Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addBillType(addBillTypeTB.Text) == true)
            {
                MessageBox.Show(null, "Successful", "Add Bill Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                return;
            }
            else
            {
                MessageBox.Show(null, "Unsuccessful. Could not add bill type to database", "Add Bill Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addHouseMateButt_Click(object sender, EventArgs e)
        {
            if (housesCB.SelectedIndex == -1)
            {
                return;
            }

            if (addHouseMateTB.Text == "")
            {
                return;
            }

            if (houseMatesLB.Items.Contains(addHouseMateTB.Text) == true)
            {
                MessageBox.Show(null, "House Mate name must be unique", "Add House Mate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addHouseMate(addHouseMateTB.Text) == true)
            {
                MessageBox.Show(null, "Successful", "Add House Mate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                return;
            }
            else
            {
                MessageBox.Show(null, "Unsuccessful. Could not add house mate database", "Add House Mate", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private bool addHouseMate(string newHouseMate)
        {
            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.addNewHouseMate1Q, connection.conn);
                comm.Parameters.AddWithValue("@newHID", HIDs[housesCB.SelectedIndex]);
                comm.Parameters.AddWithValue("@Fname", newHouseMate);
                comm.ExecuteNonQuery();


                da = new SQLiteDataAdapter(queries.getNewHMIDQ, connection.conn);
                ds = new DataSet();


                da.SelectCommand.Parameters.AddWithValue("@newHID", HIDs[housesCB.SelectedIndex]);
                da.SelectCommand.Parameters.AddWithValue("@Fname", newHouseMate);
                da.Fill(ds);

                long newHMID = (long)ds.Tables[0].Rows[0][0];

                comm = new SQLiteCommand(queries.addNewHouseMate2Q, connection.conn);
                comm.Parameters.AddWithValue("@newHMID", newHMID);
                comm.ExecuteNonQuery();


                connection.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void deleteBillType_Click(object sender, EventArgs e)
        {

            if (billTypesLB.SelectedIndex == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure? All transactions relating to this bill type will also be deleted.", "Delete Bill Type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (deleteFromBillTypes(billTypeIDs[billTypesLB.SelectedIndex]) == true)
                {
                    MessageBox.Show(null, "Successful", "Delete Bill Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate();
                    return;
                }
                else
                {
                    MessageBox.Show(null, "Unsuccessful. Could not delete from database", "Delete Bill Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool deleteFromBillTypes(long idPassed)
        {

            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.deleteBillType1Q, connection.conn);
                comm.Parameters.AddWithValue("@billTypeID", idPassed);
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.deleteBillType2Q, connection.conn);
                comm.Parameters.AddWithValue("@billTypeID", idPassed);
                comm.ExecuteNonQuery();


                connection.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void deleteHouseButt_Click(object sender, EventArgs e)
        {
            if (housesLB.SelectedIndex == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure? All housemates and transactions relating to this house will also be deleted.", "Delete House", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (deleteHouse(HIDs[housesLB.SelectedIndex]) == true)
                {
                    MessageBox.Show(null, "Successful", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate();
                    return;
                }
                else
                {
                    MessageBox.Show(null, "Unsuccessful. Could not delete from database", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private bool deleteHouse(long idPassed)
        {

            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.deleteHouse1Q, connection.conn);
                comm.Parameters.AddWithValue("@HID", idPassed);
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.deleteHouse2Q, connection.conn);
                comm.Parameters.AddWithValue("@HID", idPassed);
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.deleteHouse3Q, connection.conn);
                comm.Parameters.AddWithValue("@HID", idPassed);
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.deleteHouse4Q, connection.conn);
                comm.Parameters.AddWithValue("@HID", idPassed);
                comm.ExecuteNonQuery();


                connection.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void deleteHouseMateButt_Click(object sender, EventArgs e)
        {
            if (houseMatesLB.SelectedIndex == -1)
            {
                return;
            }
            if (houseMatesLB.Items.Count == 1)
            {
                MessageBox.Show("A house must have a minimum of 1 House Mate", "Delete House Mate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure? All transactions relating to this housemate will also be deleted.", "Delete House", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (deleteHouseMate(HMIDs[houseMatesLB.SelectedIndex]) == true)
                {
                    MessageBox.Show(null, "Successful", "Delete House Mate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate();
                    return;
                }
                else
                {
                    MessageBox.Show(null, "Unsuccessful. Could not delete from database", "Delete House Mate", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool deleteHouseMate(long idPassed)
        {

            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.deleteHouseMate1Q, connection.conn);
                comm.Parameters.AddWithValue("@HMID", idPassed);
                comm.ExecuteNonQuery();

                comm = new SQLiteCommand(queries.deleteHouseMate2Q, connection.conn);
                comm.Parameters.AddWithValue("@HMID", idPassed);
                comm.ExecuteNonQuery();


                connection.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }

        private void housesCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                da = new SQLiteDataAdapter(queries.getHouseSettingsQ, connection.conn);
                ds = new DataSet();

                long houseID = HIDs[housesCB2.SelectedIndex];

                da.SelectCommand.Parameters.AddWithValue("@HID", houseID);
                da.Fill(ds);

                firstTimeSettings = true;

                if ((bool)ds.Tables[0].Rows[0][0] == true)
                {
                    paymentConfChB.Checked = true;
                }
                else
                {
                    paymentConfChB.Checked = false;
                }

                firstTimeSettings = false;
                paymentConfChB.Enabled = true;
            }

            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);

            }

        }

        private void paymentConfChB_CheckedChanged(object sender, EventArgs e)
        {
            if (housesCB2.SelectedIndex != -1 && firstTimeSettings == false)
            {
                long idSelected = HIDs[housesCB2.SelectedIndex];
                bool checkSelected = paymentConfChB.Checked;

                if (updateHouseSettings(idSelected, checkSelected)== true)
                {
                    MessageBox.Show(null, "Successful", "Settings Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate();
                }
                else
                {
                    MessageBox.Show(null, "Unsuccessful. Could not change setting.", "Settings Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    populate();
                }
                
            }
        }

        private bool updateHouseSettings(long idPassed, bool paymentConfSetting)
        {

            SQLiteCommand comm;

            try
            {
                connection.conn.Open();
                comm = new SQLiteCommand(queries.updateHouseSettingsQ, connection.conn);
                comm.Parameters.AddWithValue("@PaymentConf", paymentConfSetting);
                comm.Parameters.AddWithValue("@HID", idPassed);
                comm.ExecuteNonQuery();

                connection.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return false;

            }
            finally
            {
                connection.conn.Close();

            }
        }


    }
}
