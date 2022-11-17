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
        List<string> insiemeDeiLibri = new List<string>();
        int numeroDeiLibri = 0;
        private void bottone1_Click(object sender, RoutedEventArgs e)
        {
            // commento fatto da github
            Libro libro = new Libro();

            Bilbioteca bilbioteca = new Bilbioteca();

            

            string LIBRO;
            string tempoDiLettura;
            
           
            //prova2 = prova.Split(" ");      // funziona
            

            LIBRO = libro.toString(TextBoxAutore.Text, TextBoxTitolo.Text, TextBoxAnno.Text, TextBoxEditore.Text, TextBoxNPag.Text);  //entra nella classe libro

            insiemeDeiLibri.Add(LIBRO);
            int numPag = Convert.ToInt32(TextBoxNPag.Text);

            tempoDiLettura = libro.readTime(numPag);   // entra nella calsse libro 

            txtBoxTempoLettura.Content = tempoDiLettura;



            numeroDeiLibri++;
            TextBoxNDeiLibri.Content = numeroDeiLibri;



            string nome = "giovanni";
            string indirizzo = "via garibaldi";
            string orariApertura = "7:00";
            string orariChiusura = "18:00";

            bilbioteca.datiUtente(nome, indirizzo, orariApertura, orariChiusura);





        }

        private void bottone2_Click(object sender, RoutedEventArgs e)
        {


            // bottone cerca titolo

            

            for ( int i = 0; i< numeroDeiLibri; i++)
            {

                string[] oggettiLista = insiemeDeiLibri[i].Split(" ");

                string a = Convert.ToString(TextBoxCercaTitolo.Text);

                if(a == oggettiLista[1])
                {

                    titoloLibriTrovati.Content = a;

                }


            }





        }

        private void bottone3_Click(object sender, RoutedEventArgs e)
        {

            // bototone cerca autore




            for (int i = 0; i < numeroDeiLibri; i++)
            {

                string[] oggettiLista = insiemeDeiLibri[i].Split(" ");

                string a = Convert.ToString(TextBoxCercaTitolo.Text);

                if (a == oggettiLista[0])
                {

                    autoriTrovati.Content = a;

                }


            }













        }
    }
}
