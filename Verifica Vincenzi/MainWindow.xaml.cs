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

namespace Verifica_Vincenzi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bottone1_Click(object sender, RoutedEventArgs e)
        {

            Libro libro = new Libro();

            List<string> list = new List<string>();

            string LIBRO;
            string tempoDiLettura;
            //string prova = "ciao ciao";
            //string[] prova2 = new string[3];
            //prova2 = prova.Split(" ");      // funziona
            //list.Add("ciao");           // funziona
            //int i = 0;

            LIBRO = libro.toString(TextBoxAutore.Text, TextBoxTitolo.Text, TextBoxAnno.Text, TextBoxEditore.Text, TextBoxNPag.Text);

            list.Add(LIBRO);
            int numPag = Convert.ToInt32(TextBoxNPag.Text);

            tempoDiLettura = libro.readTime(numPag);

            txtBoxTempoLettura.Content = tempoDiLettura;


        }
    }
}
