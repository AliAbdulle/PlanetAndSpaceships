using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
                "Mercury", "Mars"
                };
            planetList.Add("Juniter");
            planetList.Add("Saturm");
            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            List<string>lastTwoPlets = new List<string>(){
                "Uranus", "Neptune"
            };
            //Use Add() again to add Pluto to the end of the list.
            lastTwoPlets.Add("Pluto");
            //Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlets);
            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string>rockyPlanets = planetList.GetRange(0,4);
            foreach(string rocky in rockyPlanets){
                Console.WriteLine(rocky);
            }
            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");


            foreach (string plant in planetList)
            {
                Console.WriteLine(plant);
            };


        }


    }
}
