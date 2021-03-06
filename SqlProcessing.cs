﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAnalysis
{
    class SqlProcessing
    {
        /// <summary>
        /// Tool class for dividing long strings
        /// </summary>
        class ZKStringUtils
        {
            public ZKStringUtils()
            {

            }

            /// <summary>
            /// Method is supposed to divide the provided string into substrings of the
            /// length nearest greater than the param minLength. If the input string
            /// sInp is shorter than minLength, the returned ArrayList contains just
            /// this string. Otherwise the returned ArrayList contains more strings
            /// </summary>
            /// <param name="sInp"></param>
            /// <param name="minLength"></param>
            /// <returns></returns>
            public ArrayList DivideString(String sInp, int minLength)
            {
                String sPom;
                ArrayList al = new ArrayList();

                if (sInp.Length <= minLength)
                {
                    al.Add(sInp);
                    return (al);
                }
                else
                {
                    sPom = "";
                    String[] Phrases = sInp.Split(' ');
                    foreach (String sent in Phrases)
                    {
                        sPom += sent;
                        sPom += " ";
                        if (sPom.Length > minLength)
                        {
                            al.Add(sPom);
                            sPom = "";
                        }
                    }
                    if (sPom.Length > 0) al.Add(sPom);
                    return (al);
                }
            }
        }


        //------------------------------------------------------------------------------------------------
        // Main SQL class
        //------------------------------------------------------------------------------------------------
        private ArrayList ErrorMessages, InfoMessages;

        private string connectionString;
        private SqlConnection con, conpom;
        private String server, db, user, pwd;
        private static String ErrorMessage;
        private CultureInfo cultureCZ = CultureInfo.CreateSpecificCulture("cs-CZ");
        private CultureInfo cultureEN = CultureInfo.CreateSpecificCulture("en-US");


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_server"></param>
        /// <param name="_db"></param>
        /// <param name="_user"></param>
        /// <param name="_pwd"></param>
        public SqlProcessing(String _server, String _db, String _user, String _pwd)
        {
            server = _server;
            db = _db;
            user = _user;
            pwd = _pwd;
            ErrorMessages = new ArrayList();
            InfoMessages = new ArrayList();

            connectionString = "server=" + server +
            ";database=" + db + ";uid=" + user + ";pwd=" + pwd;
            InfoMessages.Add("C01: " + connectionString);

            // Instantiate the connection, passing the
            // connection string into the constructor
            con = new SqlConnection(connectionString);
            con.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

            connectionString = "server=" + server +
            ";database=master" + ";uid=" + user + ";pwd=" + pwd;
            InfoMessages.Add("C02: " + connectionString);

            conpom = new SqlConnection(connectionString);
            conpom.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

            InfoMessages.Add("Constructor Ready !");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected static void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            /*
            foreach (SqlError err in args.Errors)
            {
                ErrorMessage = String.Format("{0}", err.Message);
            }
             */
            ErrorMessage = args.Message;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public DataTable ReadData(String Command, int Verbose)
        {
            DataTable newTable = new DataTable();
            DataColumn col;
            DataRow row;
            int i;
            SqlCommand cmd;
            SqlDataReader reader = null;

            ErrorMessages.Clear();
            InfoMessages.Clear();

            InfoMessages.Add(String.Format("Query: [{0}]", Command));

            try
            {
                // Open the connection
                con.Open();
            }
            catch (Exception ex)
            {
                ErrorMessages.Add(Command);
                ProcessException(ex);
                return (newTable);
            }

            try
            {
                // Create and execute the query
                cmd = new SqlCommand(Command, con);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                ErrorMessages.Add(Command);
                ProcessException(ex);
                con.Close();
                return (newTable);
            }

            for (i = 0; i < reader.FieldCount; i++)
            {

                col = new DataColumn();
                col.ColumnName = reader.GetName(i);
                col.DataType = reader.GetFieldType(i);

                newTable.Columns.Add(col);
            }

            while (reader.Read())
            {
                row = newTable.NewRow();
                for (i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }
                newTable.Rows.Add(row);
            }
            con.Close();
            return (newTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCmd"></param>
        public int ExecNonQuery(String sCmd)
        {
            int iErr = -20;

            ErrorMessages.Clear();
            InfoMessages.Clear();

            try
            {
                SqlCommand cmd = new SqlCommand(sCmd, con);
                con.Open();
                iErr = cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                ErrorMessages.Add(sCmd);
                ProcessException(ex);
                iErr = -19;
            }

            finally
            {
                con.Close();
            }
            return (iErr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCmd"></param>
        public String ExecNonQueryWithInfo(String sCmd)
        {
            ErrorMessages.Clear();
            InfoMessages.Clear();

            try
            {
                SqlCommand cmd = new SqlCommand(sCmd, con);
                con.Open();
                //con.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                cmd.ExecuteNonQuery();
                con.Close();
                return (ErrorMessage);
            }

            catch (SqlException ex)
            {
                ErrorMessages.Add(sCmd);
                ProcessException(ex);
                con.Close();
                return ("");
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ExecNonQueryNoException()
        {
            ErrorMessages.Clear();
            InfoMessages.Clear();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * from FONDY", con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                return (0);
            }

            catch (SqlException ex)
            {
                ProcessException(ex);
                con.Close();
                return (1);
            }
        }

        public String RestoreDB(String sSource)
        {
            string sCmd;

            ErrorMessages.Clear();
            InfoMessages.Clear();

            sCmd = string.Format("restore database EMON from disk='{0}' with REPLACE", sSource);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("alter database EMON set offline with rollback immediate", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sCmd, con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("alter database EMON set online with rollback immediate", con);
                cmd.ExecuteNonQuery();
                con.Close();

                connectionString = "server=" + server +
                ";database=" + db + ";uid=" + user + ";pwd=" + pwd;
                con = new SqlConnection(connectionString);
                con.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

                return (ErrorMessage);
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Exception during SQL RestoreDB occured,\nsee the logger window!");
                ProcessException(ex);
                con.Close();
                return ("");
            }

        }

        /// <summary>
        /// Log exception related messages: the Message field does not contain newlines
        /// therefore we use shredding it into pieces of given maximum length (80)
        /// ald log line by line. The StackTrace field contains the newlines, so it
        /// it is enough to use the Split method of the String class
        /// </summary>
        /// <param name="ex"></param>
        private void ProcessException(Exception ex)
        {
            //ErrorMessages.Clear();
            //InfoMessages.Clear();

            ZKStringUtils SU = new ZKStringUtils();
            ArrayList al = SU.DivideString(ex.Message, 80);

            foreach (Object o in al)
                ErrorMessages.Add(String.Format("   EXCEPTION: [{0}]", (String)o));

            String[] Phrases = ex.StackTrace.Split('\n');
            foreach (String sent in Phrases)
                ErrorMessages.Add(String.Format("   Stack:   [{0}]", sent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList GetErrors()
        {
            return (ErrorMessages);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList GetInfos()
        {
            return (InfoMessages);
        }
    }
}
