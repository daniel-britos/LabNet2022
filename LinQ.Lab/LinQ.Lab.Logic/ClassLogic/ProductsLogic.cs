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
            var products = _context.Products.Where(p => p.UnitsInStock == 0).ToList();
            return products;
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
        public List<Products> GetListProductByName()
        {
            var query = from p in _context.Products
                        orderby p.ProductName
                        select p;
            return query.ToList();
        }
        //10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
        public List<Products> GetSortByUnitInStock()
        {
            var query = _context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
            return query;
        }
        //11. Query para devolver las distintas categorías asociadas a los productos
        public List<string> GetCategoriesProducts()
        {
            var query = from c in _context.Categories
                        join p in _context.Products
                        on c.CategoryID equals p.CategoryID
                        select new
                        {
                            c.CategoryName,
                            p.ProductName
                        };
            List<string> list = new List<string>();
            foreach (var item in query)
            {
                list.Add($"Category Name: {item.CategoryName} | Product Name: {item.ProductName}");
            }
            return list;
        }
        //12. Query para devolver el primer elemento de una lista de productos
        public Products GetFirstElementProduct()
        {
            var query = _context.Products.FirstOrDefault();
            return query;
        }
    }
}
