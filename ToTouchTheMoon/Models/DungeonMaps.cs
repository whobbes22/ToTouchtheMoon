using System;
using System.Collections.Generic;

namespace DungeonMaps.Models
{
  public class BasicMap
  {
    public int MapHeight {get;set;}
    public int MapWidth {get;set;}
    public int AmountOfRooms {get;set;}

    public char[,] PCGMap {get;set;}

    public int[] Test {get;set;}

    public BasicMap(int mapHeight, int mapWidth, int amountOfRooms)
    {
      MapHeight = mapHeight;
      MapWidth = mapWidth;
      AmountOfRooms = amountOfRooms;
    }

    // should look like a group of arrays inside another array
    public void GenerateMap()
    {
      
      //make a list add each thing into it, put them into the array
      
      // [row , column]
      PCGMap = new char [MapHeight,MapWidth];

      for(int i = 0; i < MapWidth -1; i++)
      {
        for(int j = 0; j < MapHeight -1; j++)
        {
          PCGMap[i,j] = '#';
        }
      }
    }
  }
}