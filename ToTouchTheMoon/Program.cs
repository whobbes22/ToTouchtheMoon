using System;
using System.Collections.Generic;

using DungeonMaps.Models;

namespace TheGame
{
  class program
  {
    static void Main()
    {
      BasicMap map1 = new BasicMap(10,5,3);

      for(int i = 0;i< map1.MapHeight;i++)
      {
        
          for(int j = 0; j< map1.MapWidth; j++)
          {
            Console.Write(map1.GeneratedMap[i,j]);
          }
        
      }

    }
  }
}