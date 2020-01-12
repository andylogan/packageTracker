using System;
using StructureMap;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(config => config.Scan(scan =>
            {
                scan.RegisterConcreteTypesAgainstTheFirstInterface();
                scan.TheCallingAssembly();
            }));

            var trackingNumbers = new[]
            {
               // ups numbers
               "1Z204E380338943508",
               "1Z51062E6893884735",
               "1ZXF38300382722839",
               "1ZT675T4YW92275898",
               "1ZW6897XYW00098770",

               // fedex numbers
               "449044304137821",
               "149331877648230",
               "020207021381215",
               "403934084723025",
               "920241085725456",
               "039813852990618",
               "122816215025810",
               "843119172384577",
               "070358180009382",

               // dhl numbers
               "DJJD1234567890123",
               "D1234567890",
               "DSGAGS292388",
               "DGM275322484009027685"
           };

            //var packageTrackers = new[] { new NoOpPackageTracker() };
            //var adapter = new PackageTrackerAdapter(packageTrackers);

            var adapter = container.GetInstance<PackageTrackerAdapter>();

            foreach (var number in trackingNumbers)
                adapter.TrackPackage(number);

            Console.ReadLine();
        }
    }

}
