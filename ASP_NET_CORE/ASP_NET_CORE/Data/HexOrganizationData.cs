using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE.Data
{
    public class HexOrganizationData
    {
        private string _testVar;
        
        public string Testvar 
        { 
                     get 
                     {
                         return _testVar; 
                     } 
                     set
                     { 
                         _testVar=value; 
                     }
        }
        public IEnumerable<String> GetEmployees()
        {
            return null;
        }
    }
}
