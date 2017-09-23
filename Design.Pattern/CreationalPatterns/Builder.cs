using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.CreationalPatterns
{
    public class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        
        public VehicleBuilder AddLicensePlate(string lic)
        {
            _vehicle.LicensePlate = lic;
            return this;
        }

        public VehicleBuilder AddMark(string mark)
        {
            _vehicle.Mark = mark;
            return this;
        }

        public Vehicle ToVehicle()
        {
            return _vehicle;
        }


    }

    public class Vehicle
    {

        public string LicensePlate { get; set; }

        public string Mark { get; set; }
    }
}
