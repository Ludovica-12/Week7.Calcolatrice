using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice.WinForms
{
    public partial class CalculatorForm : Form
    {
        private double valueA;
        private double valueB;
        private string operation;

        private MainBL calculator = new MainBL();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn0.Text;
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnpunto.Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //txtValue.Text = "";
            txtValue.Clear();
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtValue.Clear();
        }

        private void btnsomma_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnsomma.Tag.ToString());
            //SetOperation(txtValue.Text, "somma");
        }

        private void btnmen_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnmen.Tag.ToString());
            //SetOperation(txtValue.Text, "sottrai");
        }

        private void btnmolt_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btnmolt.Tag.ToString());
            //SetOperation(txtValue.Text, "moltiplica");
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, btndiv.Tag.ToString());
            //SetOperation(txtValue.Text, "dividi");
        }

        private void btnuguale_Click(object sender, EventArgs e)
        {
            valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);

            switch (operation)
            {
                case "somma":
                    double risultato = calculator.SommaNumeri(valueA, valueB);
                    txtValue.Text = risultato.ToString();
                    break;
                case "sottrai":
                    txtValue.Text = calculator.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    txtValue.Text = calculator.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var result = calculator.DividiNumeri(valueA, valueB);
                    txtValue.Text = (result == null) ? "Error" : result.ToString();
                    break;
                default:
                    txtValue.Text = "Error";
                    break;
            }
        }
    }
}
