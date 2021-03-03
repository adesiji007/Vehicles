using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public partial class Car
    {
        //A partial method declaration consists of two parts: the definition and the implementation
        //A partial Method definition
        partial void InitializeCar();

        // car Exterior Functionality
        public void BuildTrim() { }
        public void BuildWheels() { }
    }

    public partial class Car
    {
        //car Interior Functionality
        public void BuildSeats() { }
        public void BuildDashboard() { }
    }

    public partial class Car
    {

        // car Engine
        public void BuildEngine() { }

        // A partial method implementation
        partial void InitializeCar()
        {
            string str = "car";
            //put all car initialization here
            throw new NotImplementedException();
        }

    }
}
