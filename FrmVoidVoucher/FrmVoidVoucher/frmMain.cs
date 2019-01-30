using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using k.libary;
using System.Data.SqlClient;

namespace FrmVoidVoucher
{
    public partial class frmMain : frmSub
    {
        string brand;
        string stcode;
        string strconnBB;
        string strconnBC;
        string strconnBM;
        string strconn;
        bool online;
        private ListViewItem lastItemChecked;

        public frmMain()
        {
            InitializeComponent();
         
            stcode="2558";
            strconnBB = "Data Source=5COSMEDA.HOMEUNIX.COM,1433;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
            strconnBC = "Data Source=5COSMEDA.HOMEUNIX.COM,1833;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
            strconnBM = "Data Source=5COSMEDA.HOMEUNIX.COM,1733;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
        }

        public frmMain(bool _online,string _strconnBB, string _strconnBC, string _strconnBM, string _stcode)
        {
            InitializeComponent();

            stcode = _stcode;
            strconnBB = _strconnBB;
            strconnBC = _strconnBC;
            strconnBM = _strconnBM;
        }

        private void getwh()
        {
            string sql;
            if (brand.ToLower()=="bb")
            {
                 sql = "select whcode,abbname,COMPANYNAME from mas_wh where addr_row2 = 0 and (whcode like '1%' or whcode like '3%') order by abbname ";
            }
            else if (brand.ToLower() == "bc")
            {
                sql = "select whcode,abbname,COMPANYNAME from mas_wh where addr_row2 = 0 and whcode<> '9001' and (whcode like '5%' or whcode like '9%') order by abbname ";
            }
            else
            {
                sql = "select whcode,abbname,COMPANYNAME from mas_wh where addr_row2 = 0 and (whcode like '70%' ) order by abbname ";
            }
                

            DataSet ds = new DataSet();

            ds = cData.getDataSetWithSqlCommand(strconn, sql, 100000, true);

            lsvWh.Items.Clear();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                ListViewItem lst = new ListViewItem();
                lst = lsvWh.Items.Add("");
                lst.SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["abbname"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["COMPANYNAME"].ToString());
            }

            lsvBill.Items.Clear();
        }

        private void getbill(string _cliconn,string _abbno,string _workdate)
        {
            string sql;
           
                sql = "select *,convert(varchar(10),ptdate,103) ptdate1 from pos_pt_pr a left join mas_wh b on a.wh_id = b.id where abbno = '"+_abbno+"' and ptdate = '"+_workdate+ "' and (prcode like 'md%' or prcode like 'cc%') ";

            DataSet ds = new DataSet();

            ds = cData.getDataSetWithSqlCommand(_cliconn, sql, 100000, true);

            lsvBill.Items.Clear();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                ListViewItem lst = new ListViewItem();
                lst = lsvBill.Items.Add((i+1).ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["ptdate1"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["tmcode"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["abbno"].ToString());
                lst.SubItems.Add(ds.Tables[0].Rows[i]["cvc_no"].ToString());
            }
        }

        private bool delbill(string _cliconn, string _abbno, string _workdate,string _cvcno)
        {
            bool bl=false;
            string sql;
            SqlConnection conn = new SqlConnection(_cliconn);

            try
            {
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }

                sql = "delete from pos_pt_pr where abbno = '" + _abbno + "' and ptdate = '" + _workdate + "' and cvc_no = '" + _cvcno + "' ";

                SqlCommand comm = new SqlCommand();
                comm.CommandText = sql;
                comm.Connection = conn;
                comm.CommandTimeout = 100000;

                comm.ExecuteNonQuery();

                bl = true;

            }
            catch(Exception ex)
            {
                bl = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return bl;

            
        }

        private string getWhConn(string _dns)
        {
            string whconn = "";

            whconn = "Data Source="+_dns+";Initial Catalog=CMD-FX;User ID=sa;Password=0000";

            return whconn;
        }

        private bool save_log(string _servconn, string _whcode,  string _abbno, string _cvcno, string _stcode,string _remark)
        {
            bool bl = false;
            string sql;
            SqlConnection conn = new SqlConnection(_servconn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                sql = "insert [dbbeautycommsupport]..log_voucher(stcode,workdate,remark,whcode,abbno,cvc_no) values('"+_stcode+"',getdate(),'"+_remark+ "','" + _whcode + "','" + _abbno + "','" + _cvcno + "')";

                SqlCommand comm = new SqlCommand();
                comm.CommandText = sql;
                comm.Connection = conn;
                comm.CommandTimeout = 100000;

                comm.ExecuteNonQuery();

                bl = true;
            }
            catch(Exception ex)
            {

                bl = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return bl;
        }

        private void lsvWh_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lastItemChecked != null && lastItemChecked.Checked && lastItemChecked != lsvWh.Items[e.Index])
            {
                lastItemChecked.Checked = false;
            }
            lastItemChecked = lsvWh.Items[e.Index];
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
             
                //getwh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool bl = false;
            if(txtBill.Text=="")
            {
                MessageBox.Show("กรุณาใส่เลขที่บิล");
            }
            else
            {
                for (int i = 0; i <= lsvWh.Items.Count - 1; i++)
                {
                    
                    if (lsvWh.Items[i].Checked)
                    {
                        bl = true;
                        string cliconn = getWhConn(lsvWh.Items[i].SubItems[3].Text);

                        string sql = @"select ROW_NUMBER() over(order by abbno) as rw,whcode,abbno,convert(varchar(10),ptdate,103) as ptdate,tmcode,cvc_no from pos_pt_pr a
                                    left join mas_wh b on a.wh_id = b.id
                                     where cvc_no is not null and PTDATE = '" + dtpBill.getDateOnlyForSql() + "' and abbno = '" + txtBill.Text + "'";
                        DataSet ds = new DataSet();

                        ds = cData.getDataSetWithSqlCommand(cliconn, sql, 10000, true);

                        lsvBill.Items.Clear();

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("ไม่พบรายการคูปอง/เว้าเชอร์");
                        }
                        else
                        {
                            

                            for (int j = 0; j <= ds.Tables[0].Rows.Count - 1; j++)
                            {
                                ListViewItem lst = new ListViewItem();
                                lst = lsvBill.Items.Add(ds.Tables[0].Rows[j]["rw"].ToString());
                                lst.SubItems.Add(ds.Tables[0].Rows[j]["whcode"].ToString());
                                lst.SubItems.Add(ds.Tables[0].Rows[j]["ptdate"].ToString());
                                lst.SubItems.Add(ds.Tables[0].Rows[j]["tmcode"].ToString());
                                lst.SubItems.Add(ds.Tables[0].Rows[j]["abbno"].ToString());
                                lst.SubItems.Add(ds.Tables[0].Rows[j]["cvc_no"].ToString());
                                lst.SubItems.Add(lsvWh.Items[i].SubItems[3].Text);
                            }

                            MessageBox.Show("ดึงข้อมูลสำเร็จ");

                        }


                        i = lsvWh.Items.Count;
                    }
                }
                if (!bl)
                {
                    MessageBox.Show("ไม่ได้เลือกสาขา");
                }
            }
           
        }

        private void ยกเลกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cliconn = getWhConn(lsvBill.SelectedItems[0].SubItems[6].Text);
            string abbno = lsvBill.SelectedItems[0].SubItems[4].Text;
            string workdate = dtpBill.getDateOnlyForSql();
            string cvcno = lsvBill.SelectedItems[0].SubItems[5].Text;
            string whcode = lsvBill.SelectedItems[0].SubItems[1].Text;
            if (txtRemark.Text != "")
            {
                if (delbill(cliconn, abbno, workdate, cvcno))
                {

                    if (save_log(strconn, whcode, abbno, cvcno, stcode, txtRemark.Text))
                    {

                        lsvBill.SelectedItems[0].Remove();

                        MessageBox.Show("ยกเลิกสำเร็จ");
                    }

                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่หมายเหตุ");
            }
        }

        private void lsvBill_Click(object sender, EventArgs e)
        {
           
        }

        private void lsvBill_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lsvBill.FocusedItem.Bounds.Contains(e.Location))
                {
                    cms.Show(Cursor.Position);
                }
            }
        }

        private void txtBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                txtRemark.Focus();

            }
                    
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);

            }
           
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brand = "BB";
            groupBox1.Enabled = true;
            strconn = strconnBB;
            txtBill.Text = "";
            txtRemark.Text = "";
            dtpBill.Value = DateTime.Now;
            getwh();
        }

        private void bCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brand = "BC";
            groupBox1.Enabled = true;
            strconn = strconnBC;
            txtBill.Text = "";
            txtRemark.Text = "";
            dtpBill.Value = DateTime.Now;
            getwh();
        }

        private void bMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brand = "BM";
            groupBox1.Enabled = true;
            strconn = strconnBM;
            txtBill.Text = "";
            txtRemark.Text = "";
            dtpBill.Value = DateTime.Now;
            getwh();
        }
    }
}
