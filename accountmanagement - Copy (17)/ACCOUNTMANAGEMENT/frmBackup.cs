using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"E:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"E:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                } if (checkBox2.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"F:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"F:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                } if (checkBox3.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"G:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"G:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                } if (checkBox4.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"H:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"H:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                } if (checkBox5.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"I:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"I:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                } if (checkBox6.Checked == true)
                {
                    System.IO.Directory.CreateDirectory(@"J:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text);
                    System.IO.File.Copy(lblpath.Text, @"J:\\ACCOUNTMANAGEMENT\\BACKUPDATA" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" +
                            DateTime.Today.Year.ToString() + "\\" + lblcompanyname.Text + "\\accountmanagement.accdb");
                }
                MessageBox.Show(" BACKUP COMPLETED SUCCESFULY");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
