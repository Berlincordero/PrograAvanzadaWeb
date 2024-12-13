using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data.Interface
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        //se llena uno por Dal de Iperson para abajo ahi se ponen //
        IAdvertisementDAL AdvertisementDALImpl  { get; }
        
        bool Complete();
    }

   
}

