using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //buradaki T tür.bir entity karşılır. bu entity sen sqlden hangisini gönderiyorusan
    {
        List<T> List();
        void Insert(T p);

        T get(Expression<Func<T, bool>> filter);//sadece bir değeri bulmak için filtre

        void Delete(T p);
        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
