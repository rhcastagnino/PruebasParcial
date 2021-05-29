using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Services;
using Test.Entities.Models;

namespace Test.Business
{
    public class ProductoBiz
    {
        public void Agregar(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Create(model);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Producto> Listar()
        {
            var db = new BaseDataService<Producto>();
            var lista = db.Get();
            return lista;
        }

        public Producto Get(int id)
        {
            var db = new BaseDataService<Producto>();
            return db.GetById(id);
        }

        public void Eliminar(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Delete(model);
        }

        public void Update(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Update(model);
        }
    }
}