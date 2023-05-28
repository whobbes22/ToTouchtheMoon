using System;
using System.Collections.Generic;

namespace DungeonMaps.Models
{
  public class BasicMap
  {
    public int MapHeight {get;set;}
    public int MapWidth {get;set;}
    public int AmountOfRooms {get;set;}

    public char[,] GeneratedMap {get;set;}

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
      
      //char[][] map = new char[MapHeight][];
      GeneratedMap = new char [MapHeight,MapWidth];

      for(int i = 0; i < MapWidth; i++)
      {
        for(int j = 0; j < MapHeight; j++)
        {
          GeneratedMap[i,j] = '#';
        }
      }
    }
  }
}