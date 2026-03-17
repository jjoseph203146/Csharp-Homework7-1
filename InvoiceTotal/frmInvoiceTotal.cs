namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubtotal.Text == "")


                {
                    DialogResult dialogResult = MessageBox.Show("Please enter a Subtotal.", "Error");
                    return;
                }
                else
                { }
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);

                if (subtotal <= 0 || subtotal > 10_000)
                {
                    {
                        DialogResult dialogResult = MessageBox.Show("Please enter a valid Subtotal.", "Error");
                    }
                }

                else
                {
                    decimal discountPct = .25m;
                    decimal discountAmt = Math.Round(subtotal * discountPct, 2);
                    decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

                    txtDiscountPct.Text = discountPct.ToString("p1");
                    txtDiscountAmt.Text = discountAmt.ToString("c");
                    txtTotal.Text = invoiceTotal.ToString("c");
                }
                }
            
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Please enter a valid Subtotal.", "Error");
            }
            

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}