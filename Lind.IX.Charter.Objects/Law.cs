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
    public class Law : Clause
    {
        [DataMember]
        public ICollection<Right> Rights { get; set; }
        [DataMember]
        public ICollection<Responsibility> Responsibilities { get; set; }
    }
    [DataContract]
    public class Right : Clause
    {
        [DataMember]
        public ICollection<Entity> AppliesTo { get; set; }
    }
    [DataContract]
    public class Responsibility : Clause
    {
        [DataMember]
        public ICollection<Entity> AppliesTo { get; set; }
    }
    
}
