using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBExample.Types
{
    public class Interest
    {
        public int InterestId { get; set; }
        public string InterestName { get; set; }
        public AreayType Type { get; set; }
    }
}
