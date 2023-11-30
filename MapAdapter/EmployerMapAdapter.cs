using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAdapter
{
    internal class EmployerMapAdapter : IMapService
    {
        private readonly Employer employer;

        public EmployerMapAdapter(Employer employer)
        {
            this.employer = employer;
        }

        public void DisplayOnMap(PersonInfo personInfo)
        {
           
            Console.WriteLine($"Map: {personInfo.FirstName} {personInfo.LastName}");
            employer.DisplayInfo();
        }
    }
}
