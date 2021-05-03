using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarot.Model.EF;

namespace Tarot.Model.Service
{
    public class ProductService
    {
        TarotDbContext db = null;
        public ProductService()
        {
            db = new TarotDbContext();
        }
        public List<ProductType> ListAllType()
        {
            return db.ProductTypes.Where(x => x.Status == true).ToList();
        }
        public List<ProductCategory> ListAllCategory()
        {
            return db.ProductCategories.Where(x => x.Status == true).ToList();
        }
        public List<Publisher> ListAllPublisher()
        {
            return db.Publishers.Where(x => x.Status == true).ToList();
        }
        public int Insert(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public Product ViewDetail(int id)
        {
            return db.Products.Find(id);
        }
        public bool Update(Product entity)
        {
            try
            {
                var product = db.Products.Find(entity.ID);
                product.Price = entity.Price;
                product.CreatedBy = entity.CreatedBy;
                product.CreatedDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<Product> DanhSachSPPaging(int page,int pageSize)
        {
            return db.Products.OrderByDescending(x=>x.CreatedDate).ToPagedList(page,pageSize);
        }
    }
}
