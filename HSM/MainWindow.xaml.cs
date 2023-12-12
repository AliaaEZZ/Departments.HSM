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
using System.Xml.Linq;

namespace HSM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
        int DbContext=new int();
        public MainWindow()
        {
            InitializeComponent();
        }
        public Model1 db = new Model1();
        private void Gynecology_Click(object sender, RoutedEventArgs e)
        {
            

        }
        private void Hematology_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Oncology_Click(Object sender, RoutedEventArgs e)
        {

        }
        private void Neurology_Click(Object sender, RoutedEventArgs e)
        {

        }
        private void Ophthalmology_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Orthopedic_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Urology_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Dental_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Nutrition_and_Dietetics_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Respiratory_Therapy_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Emergency_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not valid,sorry!");
        }
        private void Cardiology_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ENT_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Gastroenterology_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Pediatrics_Click(object sender, RoutedEventArgs e)
        {

        }


    }
    
}
