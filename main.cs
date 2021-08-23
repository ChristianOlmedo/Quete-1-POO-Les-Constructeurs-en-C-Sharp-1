using System;
using Constructors;

class MainClass {
  public static void Main (string[] args) {
    Building house = new Building(4, 12);
    int size = house.GetSize();
    int floor = house.GetFloorCount();
    int maxSize = house.GetFloorMaxSize();
    
    Console.WriteLine("Your building size is " + size + "m, it countains " + floor + " floors and the maximum size of a floor is " + maxSize + " m.");
  }
}