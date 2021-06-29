using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntonysApps.HouseShare
{
    public partial class renameDialog : Form
    {
       private readonly long idPassed;
       private readonly string nameSelected;
       private readonly setUp.renameType renType;

        private enum renameReturn : byte
        {
            Success,
            NullValue,
            ConnError
        }

        public renameDialog(long _idPassed, string _nameSelected, setUp.renameType _renType)
        {
            InitializeComponent();

            idPassed = _idPassed;
            nameSelected = _nameSelected;
            renType = _renType;

            nameTB.Text = nameSelected;
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != nameSelected)
            {

                switch (renameIt(nameTB.Text, renType))
                {
                    case renameReturn.Success:
                        MessageBox.Show(null, "Successful","Rename", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                        this.Close();

                        break;

                    case renameReturn.NullValue:
                        MessageBox.Show(null,"Must have some value","Rename",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;

                    case renameReturn.ConnError:
                        MessageBox.Show(null,"Failed to make change to database","Rename",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;

                    default:
                        break;
                }
            }
        }

        private renameReturn renameIt(string nameToRenameTo, setUp.renameType renType)
        {

            if (nameToRenameTo == "")
            {
                return renameReturn.NullValue;
            }

            try
            {
                connection.conn.Open();

                SQLiteCommand comm;

                switch (renType)
                {
                    case setUp.renameType.House:

                        comm = new SQLiteCommand(queries.renameHouseQ, connection.conn);
                        comm.Parameters.AddWithValue("@newHouseName", nameToRenameTo);
                        comm.Parameters.AddWithValue("@idPassed", idPassed);

                        comm.ExecuteNonQuery();
                        connection.conn.Close();

                        break;

                    case setUp.renameType.Bill:

                        comm = new SQLiteCommand(queries.renameBillTypeQ, connection.conn);
                        comm.Parameters.AddWithValue("@newBillTypeName", nameToRenameTo);
                        comm.Parameters.AddWithValue("@idPassed", idPassed);

                        comm.ExecuteNonQuery();
                        connection.conn.Close();

                        break;

                    case setUp.renameType.Housemate:

                        comm = new SQLiteCommand(queries.renameHouseMateQ, connection.conn);
                        comm.Parameters.AddWithValue("@newHousemateName", nameToRenameTo);
                        comm.Parameters.AddWithValue("@idPassed", idPassed);

                        comm.ExecuteNonQuery();
                        connection.conn.Close();

                        break;

                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                errors.databaseCorrupt(ex);
                return renameReturn.ConnError;
            }
            finally
            {
                connection.conn.Close();   
            }
            return renameReturn.Success;
        }

    }
}
