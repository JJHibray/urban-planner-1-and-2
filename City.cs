using System;
using System.Collections.Generic;

namespace planner{
    class City{

        public City(string cityName) {
            _CityName = cityName;
        }

        public string _CityName { get; set;}
        public string _CityMayor { get; set; }
        public int _YearEstablished { get; set; }


        public List<Building> Properties = new List<Building>();

        public void addProperty(Building Property){
                Properties.Add(Property);
        }

    }
}