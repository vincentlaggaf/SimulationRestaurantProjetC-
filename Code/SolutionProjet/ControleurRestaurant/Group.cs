using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeleRestaurant;



namespace ControleurRestaurant
{

    public class Group
    {
        Random rdn = new Random();

        IPlatFactory vegeDish = new VegetarianFactory();
        IPlatFactory regularDish = new RegularFactory();

        IClientFactory clientFactory = new ClientFactory();

        public Group(){
            sizeGroupRandom();
            setClientList();
            setDishList();
        }

        private int sizeGroup;

        public int MySizeGroup
        {
            get { return sizeGroup; }
            set { sizeGroup = value; }
        }

        private List<IClient> clientList = new List<IClient>();
        private List<AbstractDish> dishList = new List<AbstractDish>();

       

        public void sizeGroupRandom(){

            MySizeGroup = rdn.Next(1, 3);
        }
        public void setClientList()
        {
            for (int i = 0; i < MySizeGroup; i++)
            {
                addClientToList();
            }
        }

        public void addClientToList()
        {
            clientList.Add(clientFactory.GetClient(orderRandom()));
        }

        public int orderRandom(){
            int order = rdn.Next(1, 2);
            return order;
        }


        public void setDishList(){

            for (int i = 0; i < clientList.Count; i++){
                if (clientList.ElementAt(i).getCommand() == 1){
                    dishList.Add(vegeDish.getDish());
                }
                else if (clientList.ElementAt(i).getCommand() == 2)
                {
                    dishList.Add(regularDish.getDish());
                }
                else{
                    Console.WriteLine("error dish list");
                }
            }
        }
    }
}