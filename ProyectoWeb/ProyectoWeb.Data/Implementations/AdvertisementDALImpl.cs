using ProyectoWeb.Data.Interface;
using ProyectoWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data.Implementations
{
    public class AdvertisementDALImpl : DALGenericoImpl<Advertisement>, IAdvertisementDAL
    {
       MediaDashboardContext context;

        public AdvertisementDALImpl(MediaDashboardContext context) : base(context)
        {
            this.context = context;
        }
    }
   
}
