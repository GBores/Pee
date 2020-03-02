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
using System.Data.SqlClient;

namespace PeePee1
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

        private void piss_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "weewee2084.database.windows.net";
            builder.UserID = "demodev";
            builder.Password = "Quakedoom99";
            builder.InitialCatalog = "Peepee";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

           // DateTime moment = new DateTime().Date;
            string peeTime = (string.Format("{0:HH:mm:ss tt}", DateTime.Now));


            /*
             * Create TABLE Urinary_Track (
    PeePeeID int,
	PeeTime varchar(50),
	 PRIMARY KEY (PeePeeID)

); 
             */






            string sql = "INSERT INTO Urinary_Track (PeeTime) Values('" + peeTime + "'); ";//select * from Urinary_Track; ";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                    }
                }
            }

        }

        private void Show_piss_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "weewee2084.database.windows.net";
                builder.UserID = "demodev";
                builder.Password = "Quakedoom99";
                builder.InitialCatalog = "Peepee";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);

                // DateTime moment = new DateTime().Date;
                string peeTime = (string.Format("{0:HH:mm:ss tt}", DateTime.Now));


                /*
                 * Create TABLE Urinary_Track (
        PeePeeID int,
        PeeTime varchar(50),
         PRIMARY KEY (PeePeeID)

    ); 
                 */



                string lastpee="";


                string sql = "select * from Urinary_Track; ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             lastpee =reader.GetString(1);
                        }
                    }
                }
                pee_time.Content = lastpee;

            }

            catch
            {
                pee_time.Content = "YOU HAVE NOT WENT PEE YET!!!!!";
            }

        }

        private void fortget_piss_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "weewee2084.database.windows.net";
            builder.UserID = "demodev";
            builder.Password = "Quakedoom99";
            builder.InitialCatalog = "Peepee";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            // DateTime moment = new DateTime().Date;
            string peeTime = (string.Format("{0:HH:mm:ss tt}", DateTime.Now));


            /*
             * Create TABLE Urinary_Track (
    PeePeeID int,
	PeeTime varchar(50),
	 PRIMARY KEY (PeePeeID)

); 
             */






            string sql = "DELETE FROM Urinary_Track; ";//select * from Urinary_Track; ";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       // Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                    }
                }
            }

        }

        private void over_write_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "weewee2084.database.windows.net";
            builder.UserID = "demodev";
            builder.Password = "Quakedoom99";
            builder.InitialCatalog = "Peepee";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            // DateTime moment = new DateTime().Date;
            string peeTime = (string.Format("{0:HH:mm:ss tt}", DateTime.Now));


            /*
             * Create TABLE Urinary_Track (
    PeePeeID int,
	PeeTime varchar(50),
	 PRIMARY KEY (PeePeeID)

); 
             */






            string sql = "Update Urinary_Track set PeeTime ='" + peeTime + "'; ";//select * from Urinary_Track; ";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                    }
                }
            }

        }
    }
}
