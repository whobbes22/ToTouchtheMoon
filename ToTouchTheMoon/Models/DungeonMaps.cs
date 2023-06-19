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
      //PCGMap = new char[mapHeight,mapWidth];
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

      for(int i = 0; i < MapHeight -1; i++)
      {
        for(int j = 0; j < MapWidth -1; j++)
        {
          PCGMap[i,j] = '#';
        }
      }
    }

    public void MakeRandomRoom()
    {
      // Code to make a random room
      var rand = new Random();
      // x1 y1 = top left corner of the room, x2 includes the length of the room to be top right corner, y2 is similar
      int x1 = rand.Next(1,70);
      int x2 = rand.Next(2,6) + x1;
      int y1 = rand.Next(1,8);
      int y2 = rand.Next(2,6) + y1;
      double xCenter = Math.Round((x1 + x2) / 2.0);
      double yCenter = Math.Round((y1 + y2) / 2.0);

      //double[] coordArray = {x1,x2,y1,y2,xCenter,yCenter};
      //coordinatesList.Add(coordArray);
      for(int i = y1; i< y2;i++)
      {
        for(int j = x1; j < x2;j++)
        {
          PCGMap[i,j] = '.';
        }
      }

    }

    public void DisplayMap()
    {
      for(int i = 0; i < PCGMap.GetLength(0); i++)
      {
        for(int j = 0; j < PCGMap.GetLength(1); j++)
        {
          Console.Write(PCGMap[i,j]);
        }
        Console.WriteLine();
      }
    }

  }
}