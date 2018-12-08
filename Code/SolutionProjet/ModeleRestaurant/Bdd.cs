using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ConsoleApp3
{

    public class Bdd
    {

        private MySqlConnection connection;

        public Bdd()
        {
            this.InitConnexion();
        }

        private void InitConnexion()
        {
            try
            {
                string connectionString = "SERVER=127.0.0.1;DATABASE=bdd_projet_restaurant;UID=root;PASSWORD=";
                this.connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
            }

        }

        //Methode à implémenter dans Commande.cs
        //Récupération de la dishlist afin d'obtenir les id des plats
        //Faire une requête afin de get l'ingrédient qui compose la recette
        //public void IngredientFromPlat(int idPlat)
        //{
        //    foreach (var id in nomList)
        //    {

        //    }
        //}

        public void IngredientFromRecette()
        {

        }

        public void SupressIngredient(int idIngredient)
        {
            //idIngredient = 1;

            try
            {
                //open sql connecion
                this.connection.Open();
                MySqlCommand cmdDecrease = this.connection.CreateCommand();

                cmdDecrease.CommandText = "UPDATE ingredients SET Quantite = Quantite - 1 WHERE ID_ingredient =" + idIngredient;
                cmdDecrease.ExecuteNonQuery();

                this.connection.Close();
            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }

        }

        //interagie avec la class Maitre d'hotel
        public void CheckTable(int place)
        {
            try
            {
                //open sql connecion
                this.connection.Open();
                MySqlCommand cmdCheckSeats = this.connection.CreateCommand();

                cmdCheckSeats.CommandText = "SELECT ID_Table FROM tables WHERE Places =@seats AND occuper = 0";
                cmdCheckSeats.Parameters.AddWithValue("@seats", place);
                cmdCheckSeats.ExecuteNonQuery();
                MySqlDataReader reader = cmdCheckSeats.ExecuteReader();
                using (DataTable dt = new DataTable())
                {
                    dt.Load(reader);
                    int numbersOfSeats = dt.Rows.Count;
                    Console.WriteLine(numbersOfSeats);
                }

                this.connection.Close();
                //return numbersOfSeats;
            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }

        }

        public void AssignTable()
        {
            //TODO : Requete assignant la premiere table libre au groupe arrivant : soit return l'ID de la table
            //Je pourrais très bien faire cela dans la methode CheckTable avec une boucle if mais d'après SOLID une méthode = une responsabilité :^(
        }
    }

}

