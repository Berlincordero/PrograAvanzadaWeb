using ProyectoWeb.Data;
using ProyectoWeb.Data.Interface;
using ProyectoWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Service.Implementation
{
    public class AdvertisementServiceImpl : IAdvertisementService
    {

        IUnidadDeTrabajo _Unidad;

        public AdvertisementServiceImpl(IUnidadDeTrabajo unidadDeTrabajo)
        {
            this._Unidad = unidadDeTrabajo;
        }


        AdvertisementDTO Mapper(Advertisement advertisement)
        {
            return new AdvertisementDTO
            {
                PersonId = person.PersonId,
                LastName = person.LastName,
                FirstName = person.FirstName,
                HireDate = person.HireDate,
                EnrollmentDate = person.EnrollmentDate,
                Discriminator = person.Discriminator
            };
        }

        Person Mapper(AdvertisementDTO person)
        {
            return new Person
            {
                PersonId = person.PersonId,
                LastName = person.LastName,
                FirstName = person.FirstName,
                HireDate = person.HireDate,
                EnrollmentDate = person.EnrollmentDate,
                Discriminator = person.Discriminator
            };
        }

        public AdvertisementDTO Add(AdvertisementDTO person)
        {
            try
            {
                _Unidad.AdvertisementDAL.Add(Mapper(person));

                _Unidad.Complete();
                return person;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(int id)
        {

            Person person = new Person { PersonId = id };
            _Unidad.PersonDAL.Remove(person);
            _Unidad.Complete();
        }

        public AdvertisementDTO GetById(int id)
        {
            var person = _Unidad.PersonDAL.Get(id);
            return Mapper(person);
        }

        public List<AdvertisementDTO> GetPersons()
        {


            try
            {
                var persons = _Unidad.PersonDAL.GetAll();
                List<AdvertisementDTO> personList = new List<PersonDTO>();

                foreach (var person in persons)
                {
                    personList.Add(Mapper(person));
                }

                return personList;
            }
            catch (Exception e)
            {

                throw;
            }
        }


        public PersonDTO Update(PersonDTO person)
        {
            try
            {
                _Unidad.PersonDAL.Update(Mapper(person));

                _Unidad.Complete();
                return person;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}
