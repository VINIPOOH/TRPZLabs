package model;
    class EntytyConverter
    {
        public static List<TypeAdapter> SetAdapteesInAdapters
            <TypeAdaptee, TypeAdapter>(List<TypeAdaptee> adaptees)
        where TypeAdapter:IAdapter<TypeAdaptee>, new()
        {
            List<TypeAdapter> toReturn = new List<TypeAdapter>();
            foreach (TypeAdaptee s in adaptees)
            {
                TypeAdapter adapter=new TypeAdapter();
                adapter.SetAdaptee(s);
                toReturn.Add(adapter);
            }
            return toReturn;
        }
        public static List<TypeAdaptee> GetAdapteesFromAdapters
            <TypeAdaptee, TypeAdapter>(List<TypeAdapter> adapters)
        where TypeAdapter:IAdapter<TypeAdaptee>
        {
            List<TypeAdaptee> toReturn = new List<TypeAdaptee>();
            foreach (IAdapter<TypeAdaptee> s in adapters)
            {
                toReturn.Add(s.GetAdaptee());
            }
            return toReturn;
        }
    }

