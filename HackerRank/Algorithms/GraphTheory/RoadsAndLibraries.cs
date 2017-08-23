// hackerrank.com/challenges/torque-and-development

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int numberOfCities = Convert.ToInt32(tokens_n[0]);
            int numberOfRoads = Convert.ToInt32(tokens_n[1]);
            long costOfLibrary = Convert.ToInt64(tokens_n[2]);
            long costOfRoad = Convert.ToInt64(tokens_n[3]);
            if(costOfLibrary < costOfRoad || numberOfRoads == 0) {
                Console.WriteLine(costOfLibrary*numberOfCities);
                for(int a1 = 0; a1 < numberOfRoads; a1++){
                    Console.ReadLine();
                }
            }
            else{
                var cities = new City[numberOfCities];
                for(int i = 0; i < numberOfCities; i++) {
                    cities[i] = new City();
                }

                for(int a1 = 0; a1 < numberOfRoads; a1++){
                    string[] tokens_city_1 = Console.ReadLine().Split(' ');
                    int city_1 = Convert.ToInt32(tokens_city_1[0]) - 1;
                    int city_2 = Convert.ToInt32(tokens_city_1[1]) - 1;

                    cities[city_1].ConnectedCities.Add(cities[city_2]);
                    cities[city_2].ConnectedCities.Add(cities[city_1]);

                }

                var regions = new List<long>();
                for(int i = 0; i < numberOfCities; i++) {
                    if(!cities[i].HasTravesed) {
                        regions.Add(cities[i].traverseCity(cities[i]));
                    }
                }

                var connectedCities = new List<int>();
                var total = (long)regions.Count * costOfLibrary;
                foreach(var region in regions) {
                    total += ((long)region - 1L) * costOfRoad;
                }


                Console.WriteLine(total);
            }

        }
    }



}

class City
{
    public List<City> ConnectedCities;
    public bool HasTravesed;

    public City()
    {
        ConnectedCities = new List<City>();
        HasTravesed = false;
    }

    public long traverseCity(City city){
        if(city.HasTravesed){
            return 0;
        }

        city.HasTravesed = true;
        var connectedCount = 1L;
        foreach(var connectedCity in city.ConnectedCities){
            connectedCount += connectedCity.traverseCity(connectedCity);
        }

        return connectedCount;
    }
}
