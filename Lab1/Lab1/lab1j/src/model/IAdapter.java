package model;
    public interface IAdapter <TypeAdaptee>
    {
        TypeAdaptee GetAdaptee();
        void SetAdaptee(TypeAdaptee adaptee);
    }
