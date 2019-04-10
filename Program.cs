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

            // Create a city
            City kirnville = new City("Kirnville", 1987);

            // Add buildings to city

            kirnville.AddBuilding(FiveOneTwo);
            kirnville.AddBuilding(ThreeThreeEight);
            kirnville.AddBuilding(TwoSeventeen);
            kirnville.AddBuilding(FourTwoFour);

            kirnville.NewMayor("Leslie Knope");

            Console.WriteLine($@"
{kirnville}

    Buildings:");
            foreach (Building building in kirnville.CityBuildings) {
                // Print building info using new ToString method!
                // Much less code
                Console.WriteLine(building);

    // Print building info using the Get methods on Building:
    //             Console.WriteLine($@"
    // {building.GetAddress()}
    // ------------------
    // Designed by {building.GetDesigner()}
    // Constructed on {building.GetDate()}
    // Owned by {building.GetOwner()}
    // {building.Volume} cubic meters of space
    //             ");
            }
        }
    }
}
