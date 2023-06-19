using System;
using System.Collections.Generic;

using DungeonMaps.Models;

namespace ToTouchTheMoon
{
  class program
  {
    static void Main()
    {

      char[,] PCGMap = new char[15,80];
      for(int i = 0; i < PCGMap.GetLength(0); i++)
      {
        for(int j = 0; j < PCGMap.GetLength(1); j++)
        {
          PCGMap[i,j] = '#';
        }
        Console.WriteLine();
      }

      //DisplayMap(PCGMap);

    List<double[]> coordinatesList = new List<double[]>();
     
      // Code to make a random room
      var rand = new Random();
      // x1 y1 = top left corner of the room, x2 includes the length of the room to be top right corner, y2 is similar
      int x1 = rand.Next(1,70);
      int x2 = rand.Next(2,6) + x1;
      int y1 = rand.Next(1,8);
      int y2 = rand.Next(2,6) + y1;
      double xCenter = Math.Round((x1 + x2) / 2.0);
      double yCenter = Math.Round((y1 + y2) / 2.0);

      double[] coordArray = {x1,x2,y1,y2,xCenter,yCenter};
      coordinatesList.Add(coordArray);
      for(int i = y1; i< y2;i++)
      {
        for(int j = x1; j < x2;j++)
        {
          PCGMap[i,j] = '.';
        }
      }

   //DisplayMap(PCGMap);

      BasicMap testMap = new BasicMap(15,80,3);
      testMap.GenerateMap();
      testMap.MakeRandomRoom();
      testMap.MakeRandomRoom();
      testMap.MakeRandomRoom();
      testMap.MakeRandomRoom();
      testMap.MakeRandomRoom();
      //Console.WriteLine( testMap.TestIntersection(1,2,3,4));
      //Console.WriteLine(testMap.TestIntersection(1,10,3,10));
      testMap.DisplayMap();

    //   map1.GenerateMap();
      

    //  Console.WriteLine(map1.PCGMap[1,1]); 
    //   for(int i = 0;i< map1.MapHeight;i++)
    //   {
        
    //       for(int j = 0; j< map1.MapWidth; j++)
    //       {
    //         Console.Write("hi ");
    //         //Console.Write("{0}",map1.PCGMap[i,j]);
    //       }
    //       Console.WriteLine();
    //   }

    }

    static void DisplayMap(char[,] MapToDisplay)
    {
      for(int i = 0; i < MapToDisplay.GetLength(0); i++)
      {
        for(int j = 0; j < MapToDisplay.GetLength(1); j++)
        {
          Console.Write(MapToDisplay[i,j]);
        }
        Console.WriteLine();
      }
    }


  }
}