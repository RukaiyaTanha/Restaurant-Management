using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainID = 0;
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }

        private void txtRecieved_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double reciept = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text,out amt);
            double.TryParse(txtRecieved.Text,out reciept);

            change = Math.Abs(amt - reciept); // convert to pos or neg to always pos.
            txtChange.Text = change.ToString();

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = @"Update tblMain set total = @total, recieved = @rec, change = @change,status = 'Paid' where MainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtRecieved.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQl(qry,ht) >0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Saved Successfully");
                this.Close();
            }
        }
    }
}
