using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            //veri kaldırma metodu
            c.SaveChanges();
            //değişiklikleri kaydet
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            //veri ekleme metodu. parametre alacak.
            c.SaveChanges();
                //değişikliklerin kaydedilmesi için kullanılır
        }

        public List<Category> List()
        {
            return _object.ToList();
            //verileri listeleme metodu
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
            //burada sadece değşiklikler kaydedilecek
        }
    }
}
