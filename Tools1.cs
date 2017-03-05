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

namespace SQLAnalysis
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// 
        /// </summary>
        private void GenerateFillCommand1()
        {
            string db, table, column, sCmd;
            int nDataType, min, max, step, i;
            SqlProcessing SP;

            db = cbFillDatabases.SelectedItem.ToString();
            table = cbFillTables.SelectedItem.ToString();
            column = cbFillColumn.SelectedItem.ToString();
            nDataType = cbFillDataTypes.SelectedIndex;
            if(nDataType == -1)
            {
                MessageBox.Show("No Data Type selected !");
                return;
            }

            min = Convert.ToInt32(txFillMin.Text);
            max = Convert.ToInt32(txFillMax.Text);
            step = Convert.ToInt32(txFillStep.Text);

            SP = new SqlProcessing(txDatabaseServer.Text, db, txUserName.Text, txPassword.Text);

            if(nDataType == 0)  // NUMBER
            {
                sCmd = string.Format("INSERT into {0} ({1}) values ({2})", table, column, min);
                txFillCmd.Text = sCmd;
            }
            else if(nDataType == 1)     // string
            {
                MessageBox.Show("STRING not supported !");
            }
            else    // Date/Time
            {
                MessageBox.Show("DATE / TIME not supported !");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void ExecuteFillCmd1()
        {
            string db, table, column, sCmd;
            int nDataType, min, max, step, i, iRes = 0;
            SqlProcessing SP;

            db = cbFillDatabases.SelectedItem.ToString();
            table = cbFillTables.SelectedItem.ToString();
            column = cbFillColumn.SelectedItem.ToString();
            nDataType = cbFillDataTypes.SelectedIndex;
            if (nDataType == -1)
            {
                MessageBox.Show("No Data Type selected !");
                return;
            }

            min = Convert.ToInt32(txFillMin.Text);
            max = Convert.ToInt32(txFillMax.Text);
            step = Convert.ToInt32(txFillStep.Text);

            SP = new SqlProcessing(txDatabaseServer.Text, db, txUserName.Text, txPassword.Text);

            if (nDataType == 0)  // NUMBER
            {
                for (i = min; i < max; i += step)
                {
                    sCmd = string.Format("INSERT into {0} ({1}) values ({2})", table, column, i);
                    SP.ExecNonQuery(sCmd);
                    if(ProcessSqlErrors(0) > 0) iRes = 1;
                }
                if(iRes != 0)
                {
                    MessageBox.Show("Errors during processing - see the Logger Window !");
                }
            }
            else if (nDataType == 1)     // string
            {
                MessageBox.Show("STRING not supported !");
            }
            else    // Date/Time
            {
                MessageBox.Show("DATE / TIME not supported !");
            }


        }
    }
}
