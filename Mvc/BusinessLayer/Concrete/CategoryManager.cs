using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorydal = categoryDal;
        }


        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);//ekleme işlemini yap
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
           _categorydal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.get(x => x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }
        ////üzerinde çalışacağım sınıfı çağırmam lazım
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        ////herbir işlem için metod tanımlıyoruz.
        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    //şarta bağlı ekleme yapacağız
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

    }
}
