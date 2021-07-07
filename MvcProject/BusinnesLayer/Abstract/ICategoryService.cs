using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        Category GetByID(int id);
        void CategoryUpdate(Category category);
     
    }
}
