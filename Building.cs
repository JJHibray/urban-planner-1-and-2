using System;

namespace planner
{
    class Building
    {
       //constructor
         public Building(string address){
            _address = address;
        }


        // public and private
        private string _designer = "Josh Hibray";

        public string getDesigner()
        {
            return _designer;
        }
        private DateTime _dateConstructed { get; set; }

        public DateTime getDate()
        {
            return _dateConstructed;
        }

        private string _address { get; set; }

        public string getAddress()
        {
            return _address;
        }

        private string _owner { get; set; }

        public string getOwner()
        {
            return _owner;
        }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (Stories * 3);
            }
        }


        public void Construct(){
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name){
            _owner = name;
        }


    }
}
