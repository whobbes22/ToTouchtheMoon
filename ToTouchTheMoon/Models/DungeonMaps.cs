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
    List<double[]> CoordinatesList = new List<double[]>();

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


      // x1= 1;
      // x2 = 50;
      // y1= 1;
      // y2 = 10;

      double xCenter = Math.Round((x1 + x2) / 2.0);
      double yCenter = Math.Round((y1 + y2) / 2.0);

      double[] coordArray = {x1,x2,y1,y2,xCenter,yCenter};

      TestIntersection(x1,x2,y1,y2);

      CoordinatesList.Add(coordArray);
      for(int i = y1; i< y2;i++)
      {
        for(int j = x1; j < x2;j++)
        {
          PCGMap[i,j] = '.';
        }
      }


   
    }

    public bool TestIntersection(double x1, double x2, double y1, double y2)
    {
      Console.WriteLine($"Room coords to be tested: {x1}, {x2}, {y1}, {y2}");
      foreach(double[] element in CoordinatesList)
      {
        Console.WriteLine($"{element[0]}, {element[1]}, {element[2]}, {element[3]}");
        // sort of works
        // if (!(x1 > element[1] || x2 > element[0] || y1 > element[3] || y2 > element[2]))
        // {
        //     Console.WriteLine($"Intersection {x1} > {element[1]} || {x2} > {element[0]} || {y1} > {element[3]} || {y2} > {element[2]}");
        //     return true;
        // }

        if(!(x2 <= element[0] ||  x1 >= element[1] || y2 <= element[2] || y1 >= element[3] ))
        {
          Console.WriteLine($"Intersection {x2} <= {element[0]} || {x1} >= {element[1]} || {y2} >= {element[2]} || {y1} >= {element[3]}");
          return true;
        }
      }
      Console.WriteLine("No overlap");
      return false;
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