using MarleneActividad;
using System;

public static class Tools
{
    public static List<Product> listaCantidadRandom(int numOfElements){
        List<Product> objectList = new List<Product>();
        for (int i = 0; i <= numOfElements; i++)
        {
            objectList.Add(new Product());
        }
        return objectList;
    }
}
