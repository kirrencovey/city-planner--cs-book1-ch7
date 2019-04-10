using System;

namespace Planner
{
    public class Building {
        private string _designer = "Kirren Covey";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        private double _width;
        public int Stories { get; set; }
        public double Width {
            get {
                return _width;
            }
            set { // buildings must be at least 10 m wide
                if (value > 10) {
                    _width = value;
                }
            }
            }
        public double Depth { get; set; }
        public double Volume
        {
            get {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building (string address) {
            _address = address;
        }
        public void Construct() {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner) {
            _owner = owner;
        }
        // public string GetAddress() {
        //     return _address;
        // }
        // public string GetOwner() {
        //     return _owner;
        // }
        // public string GetDesigner() {
        //     return _designer;
        // }
        // public DateTime GetDate() {
        //     return _dateConstructed;
        // }
        // Write a ToString method to print the desired output,
        // so above Get methods are no longer needed. Less code!
        public override string ToString() {
            return $@"
    {_address}
    ------------------
    Designed by {_designer}
    Constructed on {_dateConstructed}
    Owned by {_owner}
    {Volume} cubic meters of space
    ";
        }
    }
}