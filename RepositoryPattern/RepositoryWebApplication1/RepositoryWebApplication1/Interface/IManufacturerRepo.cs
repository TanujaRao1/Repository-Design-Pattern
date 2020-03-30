using RepositoryWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryWebApplication1.Interface
{
    public interface IManufacturerRepo
    {
        List<Manufacturer> GetAll();

        Manufacturer GetById(int manufId);
        void InsertData(Manufacturer manuf);
        void UpdateData(Manufacturer manuf);

        void DeleteData(Manufacturer manuf);
        void Save();

    }
}
