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
          PCGMap[i,j] = '.';
          Console.Write(PCGMap[i,j]);
        }
        Console.WriteLine();
      }

      var rand = new Random();
      Console.Write(rand.Next(1,15));

      BasicMap map1 = new BasicMap(10,12,3);
      //map1.GenerateMap();
      

     //Console.WriteLine(map1.PCGMap[1,1]); 
      // for(int i = 0;i< map1.MapHeight;i++)
      // {
        
      //     for(int j = 0; j< map1.MapWidth; j++)
      //     {
      //       Console.Write("hi ");
      //       //Console.Write("{0}",map1.PCGMap[i,j]);
      //     }
      //     Console.WriteLine();
      // }

    }
  }
}