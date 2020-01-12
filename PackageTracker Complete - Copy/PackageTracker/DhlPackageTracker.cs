using System;
using System.Diagnostics;

namespace PackageTracker
{
    public class DhlPackageTracker : IPackageTracker
    {
        public DhlPackageTracker()
        {
            Debug.WriteLine("in DHL package tracker");
        }

        public DateTime DeliveredDate(string trackingNumber)
        {
            if (!trackingNumber.StartsWith("D"))
            {
                throw new InvalidOperationException();
            }
            return DateTime.Parse("1776-01-01 06:00:00");
        }

        public bool IsValidNumber(string trackingNumber)
        {
            if (trackingNumber == null)
            {
                return false;
            }
            else if (trackingNumber.StartsWith("D"))
            {
                return true;
            }
            else return false;
        }
    }

}
