using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PartModel;

namespace PartBusinessLayer
{
    public static class ContactServices
    {
        static IContactRepositorycs repository;

        static ContactServices()
        {
            repository = new ContactRepository();
        }

        public static List<Contact> GetAll()
        {
            return repository.getAll();
        }

        public static Contact GetById(int id)
        {
            return repository.GetById(id);
        }

        public static Contact Insert(Contact obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(Contact obj)
        {
            repository.Update(obj);
        }

        public static void Delete(Contact obj)
        {
            repository.Delete(obj);
        }
    }
}
