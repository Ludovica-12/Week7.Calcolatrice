using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double valueA;
        private double valueB;
        private string operation;

        MainBL calculator = new MainBL();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Bottoni
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn7.Content.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn8.Content.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn9.Content.ToString();
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn4.Content.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn5.Content.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn6.Content.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn1.Content.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn2.Content.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn3.Content.ToString();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btn0.Content.ToString();
        }

        private void btnpunto_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += btnpunto.Content.ToString();
        }
        #endregion

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Clear();
        }


        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtValue.Clear();
        }

        #region Operazioni
        private void btnsomma_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "somma");
        }

        private void btnmen_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "sottrai");
        }

        private void btnmolt_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "moltiplica");
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtValue.Text, "dividi");
        }

        private void btnuguale_Click(object sender, RoutedEventArgs e)
        {
            valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);

            switch (operation)
            {
                case "somma":
                    txtValue.Text = calculator.SommaNumeri(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    txtValue.Text = calculator.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    txtValue.Text = calculator.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato = calculator.DividiNumeri(valueA, valueB);
                    txtValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
            }

        }
        #endregion

        private void menuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
