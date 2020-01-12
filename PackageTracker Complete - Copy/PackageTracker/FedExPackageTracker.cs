using System;
using System.Diagnostics;

namespace PackageTracker
{
    public class FedExPackageTracker : IPackageTracker
    {
        public FedExPackageTracker()
        {
            Debug.WriteLine("in FedEx package tracker");
        }

        public DateTime DeliveredDate(string trackingNumber)
        {
            if (trackingNumber.Length != 15)
            {
                throw new InvalidOperationException();
            }
            return DateTime.Parse("1985-01-01 06:00:00");
        }

        public bool IsValidNumber(string trackingNumber)
        {
            if (trackingNumber == null)
            {
                return false;
            }
            if (trackingNumber.Length != 15)
            {
                return false;
            }
            else return true;
        }
    }

}
