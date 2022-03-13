using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2ActivityPart1
{

    public partial class Form1 : Form
    {
        public const double BASE_CHARGE = 350.00;

        private double numDays, medCharges, surgCharges, labCharges, rehabCharges;

        public Form1()
        {
            InitializeComponent();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numDaysTextBox.Text = "";
            medicationTextBox.Text = "";
            surgicalTextBox.Text = "";
            labFeesTextBox.Text = "";
            rehabTextBox.Text = "";
            stayChargeTextBox.Text = "";
            miscChargeTextBox.Text = "";
            totalTextBox.Text = "";
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            numDays = Double.Parse(numDaysTextBox.Text);
            medCharges = Double.Parse(medicationTextBox.Text);
            surgCharges = Double.Parse(surgicalTextBox.Text);
            labCharges = Double.Parse(labFeesTextBox.Text);
            rehabCharges = Double.Parse(rehabTextBox.Text);

            stayChargeTextBox.Text = CalcStayCharges(numDays).ToString("n2");
            miscChargeTextBox.Text = CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges).ToString("n2");
            totalTextBox.Text = TotalCharges(medCharges, surgCharges, labCharges, rehabCharges, numDays).ToString("n2");

        }

        private double CalcStayCharges(double numDays)
        {
            return numDays * BASE_CHARGE;
        }

        private double CalcMiscCharges(double medCharges, double surgCharges, double labCharges, double rehabCharges)
        {
            return medCharges + surgCharges + labCharges + rehabCharges;
        }
        
        private double TotalCharges(double medCharges, double surgCharges, double labCharges, double rehabCharges, double numDays)
        {
            return CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges) + CalcStayCharges(numDays);
        }
    }
}
