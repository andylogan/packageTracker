using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PackageTracker
{
    public class PackageTrackerAdapter
    {
        /* private readonly field */
        private readonly IEnumerable<IPackageTracker> _packageTrackers;
        
        /* constructor */
        public PackageTrackerAdapter(IEnumerable<IPackageTracker> packageTrackers)
        {
            _packageTrackers = packageTrackers;
            Debug.WriteLine("in package tracker adapter constructor");
        }
        
        /* method */
        public void TrackPackage(string trackingNumber)
        {
            foreach (var tracker in _packageTrackers)
            {
                if (tracker.IsValidNumber(trackingNumber))
                {
                    var date = tracker.DeliveredDate(trackingNumber);
                    Console.WriteLine("Package delivered on: " + date + " , for tracking number: " + trackingNumber);
                }
            }
        }
    }
}
