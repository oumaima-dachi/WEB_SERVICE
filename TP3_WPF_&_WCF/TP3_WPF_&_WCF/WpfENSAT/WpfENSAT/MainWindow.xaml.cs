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

namespace WpfENSAT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReferenceEnseignement.ServiceEnseignementClient sec = new ServiceReferenceEnseignement.ServiceEnseignementClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btChercher_Click(object sender, RoutedEventArgs e) 
        { 
            if ((await sec.GetByCNEAsync(txtCNE.Text)).Count() == 0) 
            { 
                dataGridENSAT.ItemsSource = await sec.GetByCNEAsync(txtCNE.Text); 
                lbMessage.Content = "No body"; 
            } 
            else 
            { 
                dataGridENSAT.ItemsSource = await sec.GetByCNEAsync(txtCNE.Text); 
                lbMessage.Content = "You are lucky "; 
            } 
        }
    }
}
