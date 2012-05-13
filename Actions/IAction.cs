using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;

namespace JeanieMoney.Actions
{
    public interface IAction
    {
        Boolean create(Entity entity);
        Entity retrieve(Entity entity);
        List<T> retrieveList<T>(Entity entity) where T : Entity, new();
        Boolean update(Entity entity);
        Boolean delete(Entity entity);
    }
}
