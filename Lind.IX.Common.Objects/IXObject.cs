using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lind.IX.Common.Objects
{
    public abstract class IXObject
    {
        [DataMember]
        public Uri Id { get; set; }
    }
}
