using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    class Connection
    {
        OleDbConnection connect;
        OleDbCommand command;

        private void ConnectionTo()
        {
            connect = new OleDbConnection(@"C:\Users\student\Desktop\Mihail_Simeonov_20621382\WindowsFormsApplication3\WindowsFormsApplication3\Database1.mdf");
            command = connect.CreateCommand();
        }

        public Connection()
        {
            ConnectionTo();
        }

        public void Input(Chain chain)
        {
            try
            {
                command.CommandText = "Input into Chain Of stores([Number], [Name], [Owner.Names], [Address], [Manufacturer], [AmountInvested], Shareholding, RegisteredNumber, [DateOfRegistration]) values ('" +
                    chain.number + "','" + chain.name + "','" + chain.owner_names + "','" + chain.address + "','" + chain.manufacturer + "','" + chain.amountinvested + "'," +
                    chain.shareholding + "," + chain.register_number + ",'" + chain.DateOfRegistration + "')";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }


        public void Update(Chain chain)
        {
            try
            {
                command.CommandText = "Update Chain Of stores SET Invested Amount = " + chain.amountinvested + " WHERE ID = " + chain.name + ";";
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }


        public void Delete(Chain chain)
        {
            try
            {
                command.CommandText = "Delete from Chain Of Stores WHERE ID = " + chain.name + ";";
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

     

    }
    }
}
