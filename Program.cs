using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main()
        {
            // Plan some buildings

            Building FiveOneTwo = new Building("512 8th Avenue") {
                Width = 300,
                Depth = 200,
                Stories = 15
            };

            Building ThreeThreeEight = new Building("338 Battle Road") {
                Width = 100,
                Depth = 100,
                Stories = 4
            };

            Building TwoSeventeen = new Building("217 Maple Drive") {
                Width = 1000,
                Depth = 100,
                Stories = 6
            };

            Building FourTwoFour = new Building("424 6th Street") {
                Width = 300,
                Depth = 200,
                Stories = 12
            };

            // Construct the buildings

            FiveOneTwo.Construct();
            ThreeThreeEight.Construct();
            TwoSeventeen.Construct();
            FourTwoFour.Construct();

            // Purchase the buildings

            FiveOneTwo.Purchase("Owen Green");
            ThreeThreeEight.Purchase("Sally Brown");
            TwoSeventeen.Purchase("Holly Black");
            FourTwoFour.Purchase("Sam White");

            // Print the building information (place buildings in a list to make it easier)

            List<Building> myBuildings = new List<Building>() {
                FiveOneTwo,
                ThreeThreeEight,
                TwoSeventeen,
                FourTwoFour
            };

    //         foreach (Building building in myBuildings)
    //         {
    //             Console.WriteLine($@"
    // {building.GetAddress()}
    // ------------------
    // Designed by {building.GetDesigner()}
    // Constructed on {building.GetDate()}
    // Owned by {building.GetOwner()}
    // {building.Volume} cubic meters of space
    //             ");
    //         }

            // Create a city
            City kirnville = new City("Kirnville", 1987);

            // Add buildings to city

            kirnville.AddBuilding(FiveOneTwo);
            kirnville.AddBuilding(ThreeThreeEight);
            kirnville.AddBuilding(TwoSeventeen);
            kirnville.AddBuilding(FourTwoFour);

            kirnville.NewMayor("Me");

            foreach (Building building in kirnville.CityBuildings) {
                Console.WriteLine($@"
    {building.GetAddress()}
    ------------------
    Designed by {building.GetDesigner()}
    Constructed on {building.GetDate()}
    Owned by {building.GetOwner()}
    {building.Volume} cubic meters of space
                ");
            }
        }
    }
}
