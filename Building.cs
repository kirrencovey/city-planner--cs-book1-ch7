using System;

namespace Planner
{
    public class Building {
        private string _designer = "Kirren Covey";
        private DateTime _dateConstructed { get; set; }
        private string _address;
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
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
        public string GetAddress() {
            return _address;
        }
        public string GetOwner() {
            return _owner;
        }
        public string GetDesigner() {
            return _designer;
        }
        public DateTime GetDate() {
            return _dateConstructed;
        }
    }
}