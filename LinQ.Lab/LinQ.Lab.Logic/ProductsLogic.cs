using LinQ.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }
        //2. Query para devolver todos los productos sin stock

        public List<Products> GetProductsStock()
        {
            //var products = _context.Products.Where(p => p.UnitsInStock == 0).ToList(); //option1
            return (from p in _context.Products select p).ToList(); //option 2
            
        }
        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
        public List<Products> GetProductsStockOverThree()
        {
            return _context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3)
                                            .OrderBy(p => p.UnitPrice)
                                            .ToList();
        }

        //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID producto sea igual a 789
        public Products GetFirstElementOrNull()
        {
            var firstOrNull = _context.Products.FirstOrDefault(p => p.ProductID == 789);
            return firstOrNull;            
        }

        //9. Query para devolver lista de productos ordenados por nombre

    }
}
