using System;
using System.Collections.Generic;

[Serializable]
 public class Objects
 {
     public string name;
     public string house;
     public string ancestry; //ascendencia
     public string patronus;

    public override string ToString()
    {
        return "Name: " + name + "\nHouse: "+ house + "\nAncestry: " + ancestry + "\nPatronus: " + patronus;
    }
}
 
 [Serializable]
 public class RootObject
 {
     public Objects[] characters;

 }
