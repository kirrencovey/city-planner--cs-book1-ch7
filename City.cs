using System;
using System.Collections.Generic;

namespace Planner
{
    public class City {
        private string _name;
        private int _yearEst;
        private string _mayor;
        public List<Building> CityBuildings { get; set; } = new List<Building>();
        public City (string name, int yearEst) {
            _name = name;
            _yearEst = yearEst;
        }
        public void NewMayor(string mayor) {
            _mayor = mayor;
        }
        public void AddBuilding(Building building) {
            CityBuildings.Add(building);
        }
        // public string GetName() {
        //     return _name;
        // }
        // public int GetYearEst() {
        //     return _yearEst;
        // }
        // public string GetMayor() {
        //     return _mayor;
        // }
        // Replace get methods with a ToString method:
        public override string ToString() {
            return $@"
    ***********************
    City of {_name}
    ***********************
    Established in {_yearEst}
    Current Mayor: {_mayor}
    ";
        }
    }
}