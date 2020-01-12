using System;

namespace PackageTracker
{
    public interface IPackageTracker
    {
        DateTime DeliveredDate(string trackingNumber);
        bool IsValidNumber(string trackingNumber);
    }
}
