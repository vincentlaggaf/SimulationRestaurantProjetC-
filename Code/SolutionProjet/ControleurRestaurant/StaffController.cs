using System;
using System.Collections.Generic;

namespace ControleurRestaurant
{
    public class StaffController
    {



        private static StaffController instanceStaffController = null;

        private List<IStaff> listStaff = new List<IStaff>();

        public List<IStaff> MylistStaff
        {
            get { return listStaff; }
            set { listStaff = value; }
        }

        public static StaffController GetStaffController()
        {
            if (instanceStaffController == null)
            {
                instanceStaffController = new StaffController();
            }
            return instanceStaffController;
        }


        public void addServer(int nbServer){

            int i = 0;
                while (i < nbServer) {
                Serveur serveur = new Serveur()
                {
                    MyId = i + 1
                };
                listStaff.Add(serveur);
                    i++;
                }
        }

        //amélioration : passer le maitre d'hotel en singleton
        public void addMaitreHotel(int nbMaitreHotel)
        {
            if (nbMaitreHotel != 1){
                nbMaitreHotel = 1;
            }

            MaitreHotel maitreHotel = new MaitreHotel();
            listStaff.Add(maitreHotel);

            maitreHotel.chooseTable(3);

        }

        public void addChefRang(int nbChefRang)
        {

            if (nbChefRang != 2)
            {
                nbChefRang = 2;
            }

            int i = 0;
            while (i < nbChefRang)
            {
                ChefRang chefRang = new ChefRang()
                {
                    MyId = i + 1
                };
                listStaff.Add(chefRang);
                i++;
            }
        }

        private StaffController()
        {
        }
    }
}
