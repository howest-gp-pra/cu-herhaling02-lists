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

namespace Pra.HerhalingLists.WPF
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

        private void BtnList1_Click(object sender, RoutedEventArgs e)
        {
            // we maken een List waarin we een aantal integers gaan bijhouden
            // in tegenstelling tot arrays hoeven we niet vooraf op te geven 
            // met hoeveel elementen we gaan werken;
            List<int> getallen = new List<int>();

            // een element toevoegen aan de list doe je met de ADD methode
            getallen.Add(5);
            getallen.Add(6);
            getallen.Add(12);
            getallen.Add(25);
            getallen.Add(28);

            // en we beelden alle elementen af in de listbox (die we eerst leeg maken)
            lstDisplay.ItemsSource = null;  // deze instructie is noodzakelijk voor BtnList6
            lstDisplay.Items.Clear();
            // manier 1 : we vragen op hoeveel elementen in de list steken
            int aantalElementen = getallen.Count;
            for (int r = 0; r < aantalElementen; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }

        }

        private void BtnList2_Click(object sender, RoutedEventArgs e)
        {
            // zelfde code als bij BtnList1, maar nu lezen we de list uit met 
            // een foreach lus.  Dit heeft de voorkeur op een gewone for

            List<int> getallen = new List<int>();
            getallen.Add(5);
            getallen.Add(6);
            getallen.Add(12);
            getallen.Add(25);
            getallen.Add(28);

            lstDisplay.ItemsSource = null;  // deze instructie is noodzakelijk voor BtnList6
            lstDisplay.Items.Clear();
            // manier 2 , de foreach lus
            // we overlopen alle waarden in de list GETALLEN en plaatsen die één voor één
            // in de variabele GETAL.  De inhoud van deze variabele (getal) voegen we dan 
            // telkens toe aan de listbox
            foreach (int getal in getallen)
            {
                lstDisplay.Items.Add(getal);
            }

        }

        Random rnd;  // globale random generator
        private void BtnList3_Click(object sender, RoutedEventArgs e)
        {
            rnd = new Random();
            List<int> getallen = new List<int>();

            int aantalEelementen = rnd.Next(1, 1001);
            for (int r = 0; r <= aantalEelementen; r++)
            {
                getallen.Add(rnd.Next(1, 501));
            }
            lstDisplay.ItemsSource = null;  // deze instructie is noodzakelijk voor BtnList6
            lstDisplay.Items.Clear();
            foreach (int getal in getallen)
            {
                lstDisplay.Items.Add(getal);
            }
        }

        private void BtnList4_Click(object sender, RoutedEventArgs e)
        {
            rnd = new Random();
            List<int> getallen = new List<int>();

            int aantalEelementen = rnd.Next(1, 1001);
            for (int r = 0; r <= aantalEelementen; r++)
            {
                getallen.Add(rnd.Next(1, 501));
            }
            getallen.Sort();

            lstDisplay.ItemsSource = null;  // deze instructie is noodzakelijk voor BtnList6
            lstDisplay.Items.Clear();
            foreach (int getal in getallen)
            {
                lstDisplay.Items.Add(getal);
            }
        }

        //BEKIJK ONDERSTAANDE CODE EVENTUEEL LATER OPNIEUW NADAT WE KLASSEN HEBBEN HERHAALD
        class Persoon
        {
            // properties Naam, Voornaam en Gemeente
            public string Naam { get; set; }
            public string Voornaam { get; set; }
            public string Gemeente { get; set; }

            // 2 Constructors
            public Persoon()
            { }
            public Persoon(string naam, string voornaam, string gemeente)
            {
                Naam = naam;
                Voornaam = voornaam;
                Gemeente = gemeente;
            }

            // Override (overschijven) van de ToString() methode
            public override string ToString()
            {
                return Voornaam + " " + Naam + " uit " + Gemeente;
            }
        }

        private void BtnList5_Click(object sender, RoutedEventArgs e)
        {
            // de echte kracht van lists zit hem in het feit dat je aan een list om het even wat kunt
            // toevoegen, dus ook de instantie van een klasse (= een object)
            // we demonstreren dit hier aan de hand van de klasse Persoon die hierboven werd 
            // aangemaakt (uiteraard doe je dit bij voorkeur m.b.v. een class library; zie later)

            // we maken een list aan waarin we objecten van het type Persoon zullen kunnen in bewaren
            List<Persoon> personen = new List<Persoon>();

            //we maken een aantal objecten van het type Persoon aan en voegen ze telkens toe aan onze list
            Persoon persoon;
            // we maken piet piraat aan en voegen deze toe aan de list
            persoon = new Persoon();
            persoon.Naam = "Piraat";
            persoon.Voornaam = "Piet";
            persoon.Gemeente = "Oostende";
            personen.Add(persoon);

            // we maken guy taar aan en voegen deze toe aan de list
            persoon = new Persoon();
            persoon.Naam = "Taar";
            persoon.Voornaam = "Guy";
            persoon.Gemeente = "Leuven";
            personen.Add(persoon);

            // we maken tom maat aan en voegen deze toe aan de list
            persoon = new Persoon();
            persoon.Naam = "Maat";
            persoon.Voornaam = "Tom";
            persoon.Gemeente = "Brugge";
            personen.Add(persoon);

            lstDisplay.ItemsSource = null;  // deze instructie is noodzakelijk voor BtnList6
            lstDisplay.Items.Clear();
            foreach (Persoon p in personen)
            {
                lstDisplay.Items.Add(p);
            }


        }

        private void BtnList6_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnList5 maar nu veel korter genoteerd
            List<Persoon> personen = new List<Persoon>();
            personen.Add(new Persoon("Piraat", "Piet", "Oostende"));
            personen.Add(new Persoon("Taar", "Guy", "Leuven"));
            personen.Add(new Persoon("Maat", "Tom", "Brugge"));

            // we koppelen onze list aan onze listbox
            lstDisplay.ItemsSource = null;
            lstDisplay.Items.Clear();
            lstDisplay.ItemsSource = personen;


        }

        private void BtnList7_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnList6 maar nog anders geformuleerd
            List<Persoon> personen = new List<Persoon>
                { new Persoon { Naam = "Piraat", Voornaam= "Piet", Gemeente= "Oostende" },
                  new Persoon { Naam= "Taar", Voornaam = "Guy", Gemeente =  "Leuven" } ,
                  new Persoon { Naam= "Maat", Voornaam = "Tom", Gemeente =  "Brugge" } ,
            };
            lstDisplay.ItemsSource = null;
            lstDisplay.Items.Clear();
            lstDisplay.ItemsSource = personen;

        }

        private void BtnList8_Click(object sender, RoutedEventArgs e)
        {
            // geen zorg als je hier niets van snapt.  We komen hier later nog op terug
            // maar dictionaries zijn nu eenmaal speciale lists 

            Dictionary<string, string> Autos = new Dictionary<string, string>();
            Autos.Add("1-AYK-123", "Ford Focus");
            Autos.Add("1-ESS-345", "Nissan X-trail");
            Autos.Add("1-GHY-567", "Opel Insigna");
            Autos.Add("1-LHE-142", "Opel Antara");

            lstDisplay.ItemsSource = null;
            lstDisplay.Items.Clear();
            foreach (var auto in Autos)
            {
                lstDisplay.Items.Add($"{auto.Value} met nr-plaat {auto.Key}");
            }


        }
    }
}
