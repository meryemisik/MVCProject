﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
   public interface IAboutService
    {
        List<About> GetList();
        void AboutAdd(About about);
        void AboutDelete(About about);
        About GetByID(int id);
        void AboutUpdate(About about);
    }
}
