using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lind.IX.Common.Objects;
using System.Runtime.Serialization;

namespace Lind.IX.CharterEngine.Objects
{
    [DataContract]
    public class Charter : Contract
    {
        [DataMember]
        public Structure Structure { get; set; }
        [DataMember]
        public Law Law { get; set; }
        [DataMember]
        public ICollection<Goal> Goals { get; set; }
    }
    [DataContract]
    public class Goal : Clause
    {

    }
    [DataContract]
    public class Structure : Clause
    {
        [DataMember]
        public ICollection<CharterCongress> CharterCongresses { get; set; }
        [DataMember]
        public ICollection<Authority> Authorities { get; set; }
        [DataMember]
        public ICollection<Congress> Congresses { get; set; }
        [DataMember]
        public ICollection<DueProcess> DueProcess { get; set; }
    }
}
