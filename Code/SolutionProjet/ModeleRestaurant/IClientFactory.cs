﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    interface IClientFactory
    {
        Client GetClient();
    }
}
