using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lind.IX.Common.Objects
{
    [DataContract]
    public class Entity : IXObject
    {
        [DataMember]
        public string Name { get; set; }
    }
    [DataContract]
    public class Organization : Entity
    {
        [DataMember]
        public ICollection<Entity> Entities { get; set; }
    }
    [DataContract]
    public class Person : Entity
    {
        [DataMember]
        public ICollection<Organization> Organizations { get; set; }
    }
}
