﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_HW3
{
    public partial class Form1 : Form
    {
        static int fsCount;
        static int ssCount;
        SqlConnection connection;
        DataTable table;
        DataSet set;
        string cs = ConfigurationManager.ConnectionStrings["Liberary"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            txbx_FirstStream.Text = "WAITFOR DELAY '00:00:02'; SELECT* FROM Books; ";
            txbx_SecondStream.Text = "WAITFOR DELAY '00:00:03'; SELECT* FROM Authors; ";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            const string AsyncEnabled = "Asynchronous processing = true";
            if (!cs.Contains(AsyncEnabled))
            {
                String.Format("{0};{1}", cs, AsyncEnabled);
            }
            using(connection = new SqlConnection(cs))
            {
                
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = txbx_FirstStream.Text;
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;

                    connection.Open();
                    IAsyncResult ia = command.BeginExecuteReader();
                    WaitHandle handle = ia.AsyncWaitHandle;

                    if (handle.WaitOne(10000))
                    {
                        GetData(command, ia);
                    }
                    else
                    {
                        MessageBox.Show("Timeout exedeed");
                    }
                    command.CommandText = txbx_SecondStream.Text;
                    IAsyncResult ia2 = command.BeginExecuteReader();
                    WaitHandle handle2 = ia.AsyncWaitHandle;

                    if (handle2.WaitOne(10000))
                    {
                        GetData2(command, ia2);
                    }
                    else
                    {
                        MessageBox.Show("Timeout exedeed");
                    }
                    txbx_Result.Text = $"{fsCount} symbols in the all Book's titeles\n{ssCount} symbols in the all Author's firstnames and lastnames";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        void GetData(SqlCommand cmd, IAsyncResult ia)
        {
            SqlDataReader reader = null;
            try
            {
                string letters = "";
                reader = cmd.EndExecuteReader(ia);
                table = new DataTable();
                bool isHeader = true;
                do
                {
                    while (reader.Read())
                    {
                        if (isHeader)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.GetName(i));
                            }
                            isHeader = false;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                            if(row[i] == row["Title"])
                            {
                                letters += row[i];
                            }
                            
                        }
                        table.Rows.Add(row);
                        dataGridView1.DataSource = table;
                      
                    }
                }
                while (reader.NextResult());

                letters = letters.Replace(" ","");
                fsCount = letters.Length;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (!reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        void GetData2(SqlCommand cmd, IAsyncResult ia)
        {
            SqlDataReader reader = null;
            try
            {
                string letters = "";
                reader = cmd.EndExecuteReader(ia);
                table = new DataTable();
                bool isHeader = true;
                do
                {
                    while (reader.Read())
                    {
                        if (isHeader)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.GetName(i));
                            }
                            isHeader = false;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                            if(row[i] == row["Firstname"] || row[i] == row["Lastname"])
                            {
                                letters += row[i];
                            }

                        }
                      
                        table.Rows.Add(row);
                        dataGridView2.DataSource = table;
                       
                        
                    }
                }
                while (reader.NextResult());

                letters = letters.Replace(" ", "");
                ssCount = letters.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (!reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }
    }
}
