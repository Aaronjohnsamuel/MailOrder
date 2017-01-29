using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailOrder
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double _hoursWorked = double.Parse(txtHoursWorked.Text);

            double _percentageOfHoursWorked = _hoursWorked / 160;

            double _monthlySales = double.Parse(txtTotalSales.Text);

            double _totalBonusAmount = _monthlySales * 0.02;

            double _salesBonus = _totalBonusAmount * _percentageOfHoursWorked;

            txtSalesBonus.Text = Convert.ToString(_salesBonus);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblEmployeeId.Text = "Employé ID";
            lblEmployeeName.Text = "Nom de l'employé";
            lblHoursWorked.Text = "Heures travaillées";
            lblTotalSales.Text = "Ventes totales";
            lblSalesBonus.Text = "Bonus de vente";
            btnCalculate.Text = "Calculer";
            btnPrint.Text = "Impression";
            btnClear.Text = "Clair";
            groupBox1.Text = "Langue";
        }

        private void rdoEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblEmployeeId.Text = "Employee ID";
            lblEmployeeName.Text = "Employee Name";
            lblHoursWorked.Text = "Hours Worked";
            lblTotalSales.Text = "Total Sales";
            lblSalesBonus.Text = "Sales Bonus";
            btnCalculate.Text = "Calculate";
            btnPrint.Text = "Print";
            btnClear.Text = "Clear";
            groupBox1.Text = "Language";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Clear();
            txtEmployeeID.Clear();
            txtHoursWorked.Clear();
            txtSalesBonus.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form has been sent to the Printer", "Print",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

        }
    }
}
