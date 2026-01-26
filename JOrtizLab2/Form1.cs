/*
    Jorge Ortiz
    CPT-206-A01H
    Lab 2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOrtizLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void BtnMaxPop_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.MaxPop(cityDBDataSet.City);
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.MinPop(cityDBDataSet.City);
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.AscendingPop(cityDBDataSet.City);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.DescendingPop(cityDBDataSet.City);

        }

        private void btnCitySort_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.CityOrder(cityDBDataSet.City);

        }

        private void btnTotalPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population: "+ this.cityTableAdapter.SumPop());
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population: "+ this.cityTableAdapter.AvgPop());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
