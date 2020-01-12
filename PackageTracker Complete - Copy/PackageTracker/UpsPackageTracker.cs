using System;
using System.Diagnostics;

namespace PackageTracker
{
    public class UpsPackageTracker : IPackageTracker
    {
        public UpsPackageTracker()
        {
            Debug.WriteLine("in UPS package tracker");
        }
        public DateTime DeliveredDate(string trackingNumber)
        {
            if (!trackingNumber.StartsWith("1Z"))
            {
                throw new InvalidOperationException();
            }
            return DateTime.Parse("1989-09-20 12:00:00");
        }

        public bool IsValidNumber(string trackingNumber)
        {
            if (!trackingNumber.StartsWith("1Z"))
            {
                return false;
            }
            else return true;
        }
    }

}
