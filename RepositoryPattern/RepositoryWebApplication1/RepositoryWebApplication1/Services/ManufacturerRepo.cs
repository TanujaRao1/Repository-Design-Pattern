using RepositoryWebApplication1.Data;
using RepositoryWebApplication1.Interface;
using RepositoryWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryWebApplication1.Services
{
    public class ManufacturerRepo : IManufacturerRepo
    {
        private ManufacturerContext _context;
        public ManufacturerRepo(ManufacturerContext context)
        {
            _context = context;
        }
        public void DeleteData(Manufacturer manuf)
        {
            _context.Manufacturer.Remove(manuf);
        }

        public List<Manufacturer> GetAll()
        {
            return _context.Manufacturer.ToList();
        }

        public Manufacturer GetById(int manufId)
        {

            return _context.Manufacturer.Where(x => x.ManufacturerId == manufId).FirstOrDefault();
        }

        public void InsertData(Manufacturer manuf)
        {
            _context.Manufacturer.Add(manuf);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateData(Manufacturer manuf)
        {
            _context.Manufacturer.Update(manuf);
        }
    }
}
