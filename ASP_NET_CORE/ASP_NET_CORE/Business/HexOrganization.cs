using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    using ASP_NET_CORE.Data;
namespace ASP_NET_CORE.Business
{
    public class HexOrganization
    {
        public IEnumerable<String> GetEmployees()
        {
            return new HexOrganizationData().GetEmployees();
        }
    }
}
