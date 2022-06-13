﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        //üzerinde çalışacağım sınıfı çağırmam lazım
        GenericRepository<Category> repo =new GenericRepository<Category>();

        //herbir işlem için metod tanımlıyoruz.
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            //şarta bağlı ekleme yapacağız
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }

        }
    }
}