using Microsoft.EntityFrameworkCore;
using ProyectoWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoWeb.Data.Implementations
{
    public class DALGenericoImpl<TEntity> : Interface.IDALGenerico<TEntity> where TEntity : class
    {
        private MediaDashboardContext _mediadashboardContext;

        public DALGenericoImpl(MediaDashboardContext mediadashboardContext)
        {

            _mediadashboardContext = mediadashboardContext;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _mediadashboardContext.Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public TEntity Get(int id)
        {

            return _mediadashboardContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _mediadashboardContext.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _mediadashboardContext.Set<TEntity>().Attach(entity);
                _mediadashboardContext.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _mediadashboardContext.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
