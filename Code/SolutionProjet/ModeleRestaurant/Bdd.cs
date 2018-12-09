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
            //Liason entre la recette et l'ingrédient qui la constitue
        }

        public void SupressIngredient(int idIngredient)
        {
            //idIngredient = 1;

            try
            {
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
        public int CheckTable(int place)
        {
            int seatsAvailable = 0;
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
                    seatsAvailable = dt.Rows.Count;
                }
                this.connection.Close();
                //return seatsAvailable;
            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }
            return (int) seatsAvailable;
        }

        public int AssignTable()
        {
            //Je pourrais très bien faire cela dans la methode CheckTable avec une boucle if mais d'après SOLID une méthode = une responsabilité :^(
            
            int idTable = 0;
            try
            {
                this.connection.Open();
                MySqlCommand cmdAssignTable = this.connection.CreateCommand();

                cmdAssignTable.CommandText = "SELECT ID_Table FROM tables WHERE occuper = 0 LIMIT 1";
                cmdAssignTable.ExecuteNonQuery();
                idTable = (int) cmdAssignTable.ExecuteScalar();
                //Console.WriteLine(idTable);

                this.connection.Close();
                
            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }
            return (int)idTable;
        }

        public void TableUnavailable(int idTable)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmdChangeStateTable = this.connection.CreateCommand();

                cmdChangeStateTable.CommandText = "UPDATE tables SET occuper= 1 WHERE ID_Table = @idTable";
                cmdChangeStateTable.Parameters.AddWithValue("@idTable", idTable);
                cmdChangeStateTable.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }
        }
    }

}

