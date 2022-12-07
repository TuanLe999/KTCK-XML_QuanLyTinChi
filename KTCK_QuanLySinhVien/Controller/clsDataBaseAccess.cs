using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace KTCK_QuanLySinhVien
{
    public class DataBaseAccess
    {
        // Represents an open connection to a SQL database
        protected SqlConnection SqlCon;
        // Represents a SQL statement or stored
        // procedure to execute against a SQL database
        protected SqlCommand SqlCom;
        // Provides a way of reading a forward-only
        // stream of rows from a SQL database
        protected SqlDataReader Sqldreader;
        // Represents a set of data commands and a database
        // connection that are used to fill the 
        protected SqlDataAdapter SqlDa;
        // Automatically generates single-table commands that are
        // used to reconcile changes made to a 
        protected SqlCommandBuilder SqlComb;

        private string ConnectionString = @"Data Source=LAPTOP-EAG0B02R\SQL1;Initial Catalog=QuanLySinhVien_TLTTQ;Integrated Security=True";

        // Purpose: Class constructor.
        public DataBaseAccess()
        {
            // Initialize the class' members.
            SqlCon = new SqlConnection();
            // Set connection string of the SqlConnection object
            SqlCon.ConnectionString = ConnectionString;
        }



        // Purpose: Opens a database connection
        // if SQL connection open successful then return true
        // else occur exception return false
        public bool OpenConnection()
        {
            try // open connection
            {
                if (SqlCon.State != ConnectionState.Open)
                {
                    SqlCon.ConnectionString = ConnectionString;
                    SqlCon.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not connect to database, please choose a database!", "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        // Purpose: Close a database connection. 
        // if SQL connection close successful then return true else
        // occur exception return false
        protected bool CloseConnection()
        {
            try // Close connection
            {
                if (SqlCon.State != ConnectionState.Closed)
                {
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Close Database");
                return false;
            }
        }
        // Purpose: ExecuteNoneQuery command
        // if SQL statement execute successful then return true else
        // occur exception retun false

        public void CreateXmlFile(string bang)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string sql = "Select* from " + bang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable("'" + bang + "'");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\" + bang + ".xml", XmlWriteMode.WriteSchema);

            
        }


        public bool ExecuteNoneQuery(string v_sSqlString, bool ShowErrorMessage = false)
        {
            if (OpenConnection())
            {
                try
                {
                    // sets the SqlConnection used by this SqlCom of the SqlCommand
                    SqlCom = new SqlCommand(v_sSqlString, SqlCon);
                    // Executes a SQL statement against the connection and returns
                    // the number of rows affected.
                    SqlCom.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ShowErrorMessage)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Execute!");
                    }

                    return false;
                }
                finally
                {
                    // Close database connection.
                    CloseConnection();
                    SqlCom.Dispose();
                }
            }
            return true;
        }


        // Purpose: Provides a way of reading a forward-only stream of rows from a SQL database
        // if SQL statement execute successful then return SqlDataReader else
        // occur exception return nothing
        public SqlDataReader GetDataReader(string v_sSqlString)
        {
            try
            {
                if (OpenConnection())
                {
                    // sets the SqlConnection used by this SqlCom of the SqlCommand
                    SqlCom = new SqlCommand(v_sSqlString, SqlCon);
                    // Sends the CommandText to the Connection and builds a SqlDataReader.
                    Sqldreader = SqlCom.ExecuteReader();
                }
                return Sqldreader;
            }
            catch (SqlException ex)
            {

                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Get DataReader");
                return null;
            }
            finally
            {
                // Close database connection.
                CloseConnection();
                SqlCom.Dispose();
            }
        }
        // Purpose: return the first column of the first row in the result set,
        // or a nothing reference if the result set is empty
        public object GetScalar(string v_sSqlString)
        {
            object Result = null;
            try
            {
                if (OpenConnection())
                {
                    // sets the SqlConnection used by this SqlCom of the SqlCommand
                    SqlCom = new SqlCommand(v_sSqlString, SqlCon);
                    // Executes the query, and returns the first column of the first row in the
                    // result set returned by the query. Extra columns or rows are ignored.
                    Result = SqlCom.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Scalar");
            }
            finally
            {
                // Close database connection.
                CloseConnection();
                SqlCom.Dispose();
            }
            return Result;
        }
        // Purpose: Return one table of in-memory data.
        public DataTable GetDataTable(string v_sSqlString)
        {
            string sTableName = string.Empty;
            try
            {
                sTableName = v_sSqlString.Substring(14);
                sTableName = sTableName.Substring(0, sTableName.IndexOf(" ") + 1);
            }
            catch (Exception ex)
            {
            }

            var dtable = new DataTable(sTableName);
            SqlDa = new SqlDataAdapter(v_sSqlString, SqlCon);
            if (OpenConnection())
            {
                try
                {
                    // Configures the schema to match that in the data source based on 
                    // the specified System.Data.SchemaType
                    // SqlDa.FillSchema(dtable, SchemaType.Source)
                    SqlDa.Fill(dtable);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Datatable");
                }
                finally
                {
                    // Close database connection.
                    CloseConnection();
                    SqlDa.Dispose();
                }
            }
            return dtable;
        }
        public DataTable GetDataTable(string TableName, string Condition)
        {

            var dtable = new DataTable(TableName);
            SqlDa = new SqlDataAdapter("Select * from " + TableName + " Where " + Condition, SqlCon);
            if (OpenConnection())
            {
                try
                {
                    SqlDa.Fill(dtable);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Get DataTable");
                }
                finally
                {
                    // Close database connection.
                    CloseConnection();
                    SqlDa.Dispose();
                }
            }
            return dtable;
        }

        // Calls the respective INSERT, UPDATE, or DELETE statements for each inserted,
        // updated, or deleted row in the specified DataTable. if execute success
        // return true else return false
        public bool UpdateDataTable(string v_sSqlString, DataTable v_dtable, bool ShowErrorMessage = false)
        {
            SqlDa = new SqlDataAdapter();
            SqlDa.SelectCommand = new SqlCommand(v_sSqlString, SqlCon);
            // Without the SQLCommandBuilder this line would fail.
            SqlComb = new SqlCommandBuilder(SqlDa);
            try
            {
                if (OpenConnection())
                {
                    SqlDa.Update(v_dtable);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (ShowErrorMessage)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning");
                }
                return false;
            }
            finally
            {
                // Close database connection.
                CloseConnection();
                SqlDa.Dispose();
                SqlComb.Dispose();
            }
        }

        // Purpose: Implements the IDispose' method Dispose.
        protected void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }

    }
}