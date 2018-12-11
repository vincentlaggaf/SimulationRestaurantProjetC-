using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ModeleRestaurant
{

    public class Bdd
    {
        private static Bdd instanceBdd = null;
        private MySqlConnection connection;

        private Bdd()
        {
            this.InitConnexion();
        }

        public static Bdd GetBddConnexion()
        {
            if (instanceBdd == null)
            {
                instanceBdd = new Bdd();
            }
            return instanceBdd;
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

                //Problème : n'arrive pas à return un string comportant tous les champs de la requête
        public Dictionary<string,object> GetDish(int idDish)
        {
            //int[] ID_Plat = new int[1];
            //string[] Type = new string[1];
            //string[] Nom = new string[1];
            //int[] Prix = new int[1];
            //double[] Preparation = new double[1];
            //double[] Cuisson = new double[1];
            //int[] NbrePersonne = new int[1];
            Dictionary<string, Object> dishAttribute = new Dictionary<string, object>();

            try
            {
                this.connection.Open();
                MySqlCommand cmdGetDish = this.connection.CreateCommand();

                cmdGetDish.CommandText = "SELECT ID_Plat, Type, Nom, Prix, Preparation, Cuisson, NbrePersonne FROM plat WHERE ID_plat = @idDish";
                cmdGetDish.Parameters.AddWithValue("@idDish", idDish);
                cmdGetDish.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdGetDish);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dishAttribute.Add("Id", row.Field<int>(0));
                    dishAttribute.Add("Type", row.Field<string>(1));
                    dishAttribute.Add("Nom", row.Field<string>(2));
                    dishAttribute.Add("Prix", row.Field<int>(3));
                    dishAttribute.Add("Preparation", row.Field<int>(4));
                    dishAttribute.Add("Cuisson", row.Field<int>(5));
                    dishAttribute.Add("NbrePersonne", row.Field<int>(6));
                
                  
                }

                //foreach (DataRow row in dt.Rows)
                //{
                //    ID_Plat[0] = row.Field<int>(0);
                //    Type[0] = row.Field<string>(1);
                //    Nom[0] = row.Field<string>(2);
                //    Prix[0] = row.Field<int>(3);
                //    Preparation[0] = row.Field<double>(4);
                //    Cuisson[0] = row.Field<double>(5);
                //    NbrePersonne[0] = row.Field<int>(6);

                //}


                // Console.WriteLine(Type[0]);

                this.connection.Close();

            }
            catch (MySqlException e)
            {
                Console.Write(e);
            }
            return dishAttribute;
        }

        public int GetPrix(int idDish)
        {
            int prix = 0;
            try {
                this.connection.Open();
                MySqlCommand cmdGetPrix = this.connection.CreateCommand();
                cmdGetPrix.CommandText = "SELECT Prix FROM plat Where ID_Plat = @idDish";
                cmdGetPrix.Parameters.AddWithValue("@idDish", idDish);
                cmdGetPrix.ExecuteNonQuery();
                prix = Convert.ToInt32(cmdGetPrix.ExecuteScalar());

                this.connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            return (int)prix;
        }

        public void InitializeUstensil(int quantity)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmdInitialize = this.connection.CreateCommand();
                cmdInitialize.CommandText = "UPDATE materielcommun SET Quantite = @quantity";
                cmdInitialize.Parameters.AddWithValue("@quantity", quantity);
                cmdInitialize.ExecuteNonQuery();

                this.connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteTable()
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmdInitialize1 = this.connection.CreateCommand();
                cmdInitialize1.CommandText = "DELETE FROM tables";
                cmdInitialize1.ExecuteNonQuery();

                this.connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void InitializeTable(int quantity)
        {
            DeleteTable();
            int newQuantity = quantity - 1;
            string query = "INSERT INTO tables (ID_Table, Places, occuper) VALUES (1, 4, 0);";
            string query2 = "INSERT INTO tables (Places, occuper) VALUES (4, 0);";

            for (int i = 0; i < newQuantity; i++)
            {
                query = query + query2;
            }
            Console.WriteLine(query);
            try
            {
                this.connection.Open();
                MySqlCommand cmdInitialize = this.connection.CreateCommand();
                cmdInitialize.CommandText = query;
                cmdInitialize.Parameters.AddWithValue("@quantity", quantity);
                cmdInitialize.ExecuteNonQuery();

                this.connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

}

