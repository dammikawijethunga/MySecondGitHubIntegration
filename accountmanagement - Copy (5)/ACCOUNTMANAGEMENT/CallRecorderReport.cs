﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ACCOUNTMANAGEMENT
{
    public partial class CallRecorderReport : Form
    {
        public CallRecorderReport()
        {
            InitializeComponent();
        }

        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
        private void CallRecorderReport_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(lblpath.Text);
            con.Open();
            String sql1 = "SELECT CALLID,ACCOUNTNAME,ADDRESS,PHONE,ITEMNAME,PROBLEM,EMPLOYEENAME,VISITDATE,VISITTIME,CALLSTATUS,PROBLEMFOUND FROM CallRecorder";
            cmd = new OleDbCommand(sql1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dgvinstallment.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8],rdr[9], rdr[10]);
            }
            con.Close();
        }
    }
}
