using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public partial class paymentData : Form
    {

        private readonly long houseID;
        DataSet ds;
        SQLiteDataAdapter da;
        private bool showingTransIn = true;

        public paymentData(long _houseID)
        {
            InitializeComponent();
            houseID = _houseID;
            try
            {
                loadPaymentsIn();
            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }

        }

        private void loadPaymentsIn()
        {

            da = new SQLiteDataAdapter(queries.getPaymentsInQ, connection.conn);
            ds = new DataSet();

            da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            showingTransIn = true;


        }

        private void loadPaymentsOut()
        {

            da = new SQLiteDataAdapter(queries.getPaymentsOutQ, connection.conn);
            ds = new DataSet();

            da.SelectCommand.Parameters.AddWithValue("@houseID", houseID);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            showingTransIn = false;


        }
        private void switchPaymentsTS_Click(object sender, EventArgs e)
        {
            swtichPaymentsTS.Enabled = false;

            if (swtichPaymentsTS.Text == "Switch to Payments Out")
            {
                try
                {
                    loadPaymentsOut();
                    swtichPaymentsTS.Text = "Switch to Payments In";
                }
                catch (Exception ex)
                {
                   errors.databaseCorrupt(ex);
                }


            }

            else
            {
                try
                {
                    loadPaymentsIn();
                    swtichPaymentsTS.Text = "Switch to Payments Out";
                }
                catch (Exception ex)
                {
                    errors.databaseCorrupt(ex);
                }
            }

            swtichPaymentsTS.Enabled = true;
        }

        private void deleteSelectedRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long transID = (long)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

            DialogResult result = MessageBox.Show("Are you sure you wish to delete record\nTransaction ID:" + transID + " ?", "Delete Selected Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                deleteRecord(transID);
            }
        }

        private void deleteRecord(long transID)
        {
            try
            {
                connection.conn.Open();
                SQLiteCommand comm;

                if (showingTransIn == true)
                {
                    comm = new SQLiteCommand(queries.deleteRecordInQ, connection.conn);
                }
                else
                {
                    comm = new SQLiteCommand(queries.deleteRecordOutQ, connection.conn);
                }

                comm.Parameters.AddWithValue("@transID", transID);
                comm.ExecuteNonQuery();
                connection.conn.Close();
                this.DialogResult = DialogResult.Yes;
                this.Close();

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }
        }
        private void deleteRecordOut(long transID)
        {
            try
            {
                connection.conn.Open();
                SQLiteCommand comm = new SQLiteCommand(queries.deleteRecordOutQ, connection.conn);
                comm.Parameters.AddWithValue("@transID", transID);
                comm.ExecuteNonQuery();
                connection.conn.Close();
                this.DialogResult = DialogResult.Yes;
                this.Close();

            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
            }
        }

    }
}
