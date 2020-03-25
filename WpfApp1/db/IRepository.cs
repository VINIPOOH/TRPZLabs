using System.Collections.Generic;
using Lab1.dto;

namespace Lab1.db
{
    public interface IRepository <EntityType>
    {
         List<EntityType>  findAll();
    }
}