using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;

namespace JeanieMoney.Actions
{
    interface IAction<T>
    {
        bool create(T t);
        T retrieve(T t);
        List<T> retrieveList(T t);
        bool update(T t);
        bool delete(T t);
    }
}
