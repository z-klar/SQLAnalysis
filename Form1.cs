using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*-----------------------------------------------------------------------------
 * Added new comment
 * ---------------------------------------------------------------------------*/

namespace SQLAnalysis
{
    public partial class Form1 : Form
    {
        private SqlProcessing SP;

        public Form1()
        {
            InitializeComponent();

            
        }

        /// <summary>
        /// Utility processing SQL Errors and returning number of errors in the SQL command
        /// </summary>
        private int ProcessSqlErrors(int verbose)
        {
            ArrayList err;

            err = SP.GetErrors();
            if(err.Count == 0)
            {
                return (0);
            }
            else
            {
                foreach(string s in err)
                {
                    lbLog.Items.Add(s);
                }
                if(verbose != 0) MessageBox.Show("Very uggly errors occured - see the Logger Window !");
                return (err.Count);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateSql_Click(object sender, EventArgs e)
        {
            string server, db, user, pwd;

            server = txDatabaseServer.Text;
            db = "master";
            user = txUserName.Text;
            pwd = txPassword.Text;

            SP = new SqlProcessing(server, db, user, pwd);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshDb_Click(object sender, EventArgs e)
        {
            string sCmd;
            DataTable dt;

            try
            {
                sCmd = "SELECT name FROM master.dbo.sysdatabases";
                dt = SP.ReadData(sCmd, 1);
                if (ProcessSqlErrors(1) == 0)
                {
                    lbDatabases.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        lbDatabases.Items.Add(Convert.ToString(row.ItemArray[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshTables_Click(object sender, EventArgs e)
        {
            string sDataBase, sCmd;
            DataTable dt;

            if (lbDatabases.SelectedIndex == -1)
            {
                MessageBox.Show("No Database selected !!");
                return;
            }
            else
            {
                try
                {
                    sDataBase = lbDatabases.SelectedItem.ToString();
                    sCmd = string.Format("SELECT TABLE_NAME FROM {0}.INFORMATION_SCHEMA.TABLES ", sDataBase);
                    sCmd += "WHERE TABLE_TYPE = 'BASE TABLE'";
                    dt = SP.ReadData(sCmd, 1);
                    if (ProcessSqlErrors(1) == 0)
                    {
                        lbTables.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            lbTables.Items.Add(Convert.ToString(row.ItemArray[0]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshColumns_Click(object sender, EventArgs e)
        {
            string sDataBase, sTable, sCmd;
            DataTable dt;

            if (lbDatabases.SelectedIndex == -1)
            {
                MessageBox.Show("Absolutely NO Database selected !!");
                return;
            }
            else
            {
                sDataBase = lbDatabases.SelectedItem.ToString();
            }
            if (lbTables.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                sTable = lbTables.SelectedItem.ToString();
            }

            try
            {
                sCmd = string.Format("USE {0} SELECT COLUMN_NAME as COL, DATA_TYPE as Type, CHARACTER_MAXIMUM_LENGTH as Len FROM INFORMATION_SCHEMA.COLUMNS ", sDataBase);
                sCmd += string.Format("WHERE TABLE_NAME = '{0}' AND TABLE_SCHEMA='dbo'", sTable);
                dt = SP.ReadData(sCmd, 1);
                if (ProcessSqlErrors(1) == 0)
                {
                    dgvColumns.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.CSV)|*.CSV|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txCsvFile1.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadCsv_Click(object sender, EventArgs e)
        {
            char rec_delimiter;
            string sPom;
            String[] Phrases;
            int i, noRec, iErr = 0;
            DataColumn col;
            DataRow row;

            if (rbComma.Checked) rec_delimiter = ',';
            else rec_delimiter = ';';

            StreamReader sw = null;
            if (txCsvFile1.Text.Length < 10)
            {
                MessageBox.Show("No file name provided !");
                return;
            }
            FileStream fs = File.Open(txCsvFile1.Text, FileMode.Open, FileAccess.Read);
            sw = new StreamReader(fs, System.Text.Encoding.ASCII);

            if((sPom = sw.ReadLine()) == null)
            {
                MessageBox.Show("Error reading 1st line of the file !!");
                sw.Close();
                fs.Close();
                return;
            }
            Phrases = sPom.Split(rec_delimiter);
            noRec = Phrases.Length;
            sw.Close();
            fs.Close();

            DataTable dt = new DataTable();
            for(i=0; i<noRec; i++)
            {
                col = new DataColumn();
                col.ColumnName = string.Format("Col{0:D2}", i);
                col.DataType = typeof(string);
                dt.Columns.Add(col);
            }

            fs = File.Open(txCsvFile1.Text, FileMode.Open, FileAccess.Read);
            sw = new StreamReader(fs, System.Text.Encoding.ASCII);
            while ((sPom = sw.ReadLine()) != null)
            {
                // process the line
                Phrases = sPom.Split(rec_delimiter);
                //statusStrip1.Items[0].Text = string.Format("No of recs: {0}   ", dtAnaData.Rows.Count);
                Application.DoEvents();
                try
                {
                    if (Phrases.Length >= noRec)
                    {
                        row = dt.NewRow();
                        for(i=0; i<noRec; i++)
                        {
                            row[i] = Phrases[i];
                        }
                        dt.Rows.Add(row);
                    }
                    else
                    {
                        lbLog.Items.Add(string.Format("Wrong input: {0}", sPom));
                        iErr = 1;
                    }
                }
                catch (Exception ex)
                {
                    lbLog.Items.Add("Line: " + sPom);
                    lbLog.Items.Add(ex.Message);
                    iErr = 1;
                }
            }
            sw.Close();
            fs.Close();
            if (iErr != 0) MessageBox.Show("Errors occured - see the Error log !");

            dgvExt1.DataSource = dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillInit_Click(object sender, EventArgs e)
        {
            string sCmd;
            DataTable dt;

            try
            {
                sCmd = "SELECT name FROM master.dbo.sysdatabases";
                dt = SP.ReadData(sCmd, 1);
                if (ProcessSqlErrors(1) == 0)
                {
                    cbFillDatabases.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        cbFillDatabases.Items.Add(Convert.ToString(row.ItemArray[0]));
                    }
                    if (cbFillDatabases.Items.Count > 0) cbFillDatabases.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// User changed selected DB in the FILL window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFillDatabaseSelIndexChanged(object sender, EventArgs e)
        {
            string sDataBase, sCmd;
            DataTable dt;

                try
                {
                    sDataBase = cbFillDatabases.SelectedItem.ToString();
                    sCmd = string.Format("SELECT TABLE_NAME FROM {0}.INFORMATION_SCHEMA.TABLES ", sDataBase);
                    sCmd += "WHERE TABLE_TYPE = 'BASE TABLE'";
                    dt = SP.ReadData(sCmd, 1);
                    if (ProcessSqlErrors(1) == 0)
                    {
                        cbFillTables.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            cbFillTables.Items.Add(Convert.ToString(row.ItemArray[0]));
                        }
                        if (cbFillTables.Items.Count > 0) cbFillTables.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFillTableSelIndexChanged(object sender, EventArgs e)
        {
            string sDataBase, sTable, sCmd;
            DataTable dt;

            sDataBase = cbFillDatabases.SelectedItem.ToString();
            sTable = cbFillTables.SelectedItem.ToString();

            try
            {
                sCmd = string.Format("USE {0} SELECT COLUMN_NAME as COL, DATA_TYPE as Type, CHARACTER_MAXIMUM_LENGTH as Len FROM INFORMATION_SCHEMA.COLUMNS ", sDataBase);
                sCmd += string.Format("WHERE TABLE_NAME = '{0}' AND TABLE_SCHEMA='dbo'", sTable);
                dt = SP.ReadData(sCmd, 1);
                if (ProcessSqlErrors(1) == 0)
                {
                    cbFillColumn.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        cbFillColumn.Items.Add(Convert.ToString(row.ItemArray[0]));
                    }
                    if (cbFillColumn.Items.Count > 0) cbFillColumn.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillExec_Click(object sender, EventArgs e)
        {
            ExecuteFillCmd1();
        }

        private void btnTestCommand_Click(object sender, EventArgs e)
        {
            GenerateFillCommand1();
        }
    }
}
