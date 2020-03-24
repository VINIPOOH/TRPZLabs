package db;

import java.util.List;

public interface IRepository <EntityType>
    {
         List<EntityType> findAll();
    }
