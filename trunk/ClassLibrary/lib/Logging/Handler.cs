using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public abstract class Handler
    {
        protected Level level;
        protected List<Category> categoryList;

        public abstract void write(string message, Level level, Category category);
    }
}
