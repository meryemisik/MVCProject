﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
   public interface IContentService
    {
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
        void ContentAdd(Content content);
        void ContentDelete(Content content);
        Content GetByID(int id);
        void ContentUpdate(Content content);
    }
}