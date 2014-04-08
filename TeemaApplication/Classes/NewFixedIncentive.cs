using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeemaApplication.Classes
{
    class NewFixedIncentive
    {
        private string incentiveType;

        public string IncentiveType
        {
            get { return incentiveType; }
            set { incentiveType = value; }
        }
        private double incentiveValue;

        public double IncentiveValue
        {
            get { return incentiveValue; }
            set { incentiveValue = value; }
        }
    }
}
