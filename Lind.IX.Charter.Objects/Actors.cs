using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Lind.IX.Common.Objects;

namespace Lind.IX.CharterEngine.Objects
{
    
    
    [DataContract]
    public class Committee : Organization
    {

    }
    [DataContract]
    public class Authority : Committee
    {
        [DataMember]
        public ICollection<Process> Processes { get; set; }
    }
    [DataContract]
    public class Congress : Committee
    {
        [DataMember]
        public ICollection<Authority> Authorities { get; set; }
    }
    [DataContract]
    public class CharterCongress: Congress
    {
        [DataMember]
        public Charter Charter { get; set; }
    }
}
