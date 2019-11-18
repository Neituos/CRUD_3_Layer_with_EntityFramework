using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PartModel;
using System.Threading.Tasks;

namespace DataLayer
{

    public interface IContactRepositorycs
    {
        List<Contact> getAll();
        Contact GetById(int id);
        Contact Insert(Contact obj);
        void Update(Contact obj);
        void Delete(Contact obj);

    }
}
