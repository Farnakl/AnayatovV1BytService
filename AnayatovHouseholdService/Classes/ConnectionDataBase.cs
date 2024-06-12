using AnayatovHouseholdService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnayatovHouseholdService.Classes
{
    internal class ConnectionDataBase
    {
        public static HouseholdServiceEntities connection = new HouseholdServiceEntities();
    }
}
