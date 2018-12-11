using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{

    public class Group
    {
        Random rdn = new Random();

        IPlatFactory vegeDish = new VegetarianFactory();
        IPlatFactory regularDish = new RegularFactory();

        IClientFactory clientFactory = new ClientFactory();

        int prixTotal = 0;
        public int MyPrixTotal
        {
            get { return prixTotal; }
            set { prixTotal = value; }
        }

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

        public void addClientToList(){
            clientList.Add(clientFactory.GetClient(orderRandom()));
        }

        public int orderRandom(){
            int order = rdn.Next(1,3);
            return order;
        }


        public void setDishList(){
            for (int i = 0; i < clientList.Count; i++){
                if (clientList.ElementAt(i).getCommand() == 1){
                    AbstractDish newVege = vegeDish.getDish();
                    dishList.Add(newVege);
                   
                    prixTotal += newVege.Price;
                }
                 else if (clientList.ElementAt(i).getCommand() == 2)
                {
                    AbstractDish newRegu = regularDish.getDish();
                    dishList.Add(newRegu);
                  
                    prixTotal += newRegu.Price;
                }
                else{
                    Console.WriteLine("error dish list");
                }
            }
        }

        public List<AbstractDish> getDishList(){
            return dishList;
        }
    }
}