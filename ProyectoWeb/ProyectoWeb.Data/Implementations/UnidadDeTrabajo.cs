using ProyectoWeb.Data.Interface;
using ProyectoWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IAdvertisementDAL AdvertisementDAL { get; set; }
        private MediaDashboardContext _mediadashboardContext;



        public UnidadDeTrabajo(MediaDashboardContext mediadashboardContext, IAdvertisementDAL advertisementDAL)
        {
            _mediadashboardContext = mediadashboardContext;
            AdvertisementDAL = advertisementDAL;
        }


        public bool Complete()
        {
            try
            {
                _mediadashboardContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            _mediadashboardContext.Dispose();
        }

    }
}