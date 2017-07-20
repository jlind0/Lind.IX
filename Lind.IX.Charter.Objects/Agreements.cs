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
    public class Agreement : Contract
    {
        [DataMember]
        public Committee AgreementCommitte { get; set; }
    }
    [DataContract]
    public class Process : Agreement
    {
        [DataMember]
        public Authority Owner { get; set; }
    }
    [DataContract]
    public class DueProcess : Process
    {

    }
    
}
