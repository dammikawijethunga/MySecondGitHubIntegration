using System;
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
    public partial class PRODUCTCOMPANY : Form
    {
        PRODUCTCREATION ths;
        public PRODUCTCOMPANY(PRODUCTCREATION frm)
        {
            InitializeComponent();
            ths = frm;
            lblpath.Text = ths.lblpath.Text;
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();

    
        public void Reset()
        {
            try
            {

                con = new OleDbConnection(lblpath.Text);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(PRODUCTCOMPANYID) as PRODUCTCOMPANYID FROM ProductCompany";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("PRODUCTCOMPANYID")))
                    {

                        lblcompanyid.Text = Convert.ToString("1");
                    }
                    else
                    {
                        lblcompanyid.Text = Convert.ToString(Convert.ToInt16(rdr["PRODUCTCOMPANYID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();

                con = new OleDbConnection(lblpath.Text);
                con.Open();
                String sql = "SELECT PRODUCTCOMPANYID,PRODUCTCOMPANYNAME FROM ProductCompany";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                dgwCompany.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwCompany.Rows.Add(rdr[0], rdr[1]);
                }
                con.Close();

                txtCompanyName.Text = "";

                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                txtCompanyName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                con = new OleDbConnection(lblpath.Text);
                con.Open();
                string cb = "insert into ProductCompany(PRODUCTCOMPANYID,PRODUCTCOMPANYNAME) VALUES (" + lblcompanyid.Text + ",'" + txtCompanyName.Text + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "ProductCompany", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(lblpath.Text);
                con.Open();

                string cb = "update ProductCompany set  PRODUCTCOMPANYNAME = '" + txtCompanyName.Text + "' where  PRODUCTCOMPANYID = " + lblcompanyid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "ProductCompany", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con = new OleDbConnection(lblpath.Text);
                con.Open();
                string cb = "DELETE FROM ProductCompany WHERE PRODUCTCOMPANYID=" + lblcompanyid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "ProductCompany", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwCompany_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                lblcompanyid.Text = dgwCompany.SelectedRows[0].Cells[0].Value.ToString();
                txtCompanyName.Text = dgwCompany.SelectedRows[0].Cells[1].Value.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void PRODUCTCOMPANY_FormClosed(object sender, FormClosedEventArgs e)
        {
             Form fc = Application.OpenForms["PRODUCTCREATION"];

             if (fc != null)
             {

                 ths.productcompanyresete();
                 ths.cmbCompany.Focus();
             }
        }


    }

}
