using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lind.IX.Common.Objects
{
    [DataContract]
    public class Contract : IXObject
    {
    }
    [DataContract]
    public class Equity : Clause
    {
        [DataMember]
        public ICollection<Action> Triggerables { get; set; }
    }
    [DataContract]
    public class Share : IXObject
    {
        [DataMember]
        public Equity Equity { get; set; }
    }
    [DataContract]
    public class DecisionModel : Clause
    {

    }
    [DataContract]
    public abstract class Clause : IXObject
    {
        [DataMember]
        public string RawText { get; set; }
    }
    [DataContract]
    public class Event : Clause
    {
        [DataMember]
        public ICollection<Clause> Triggers { get; set; }
        [DataMember]
        public DateTime EffectiveDate { get; set; }
    }
    [DataContract]
    public class Ammendment : Clause
    {
        [DataMember]
        public Clause Old { get; set; }
        [DataMember]
        public Clause New { get; set; }
        [DataMember]
        public DateTime EffectiveDate { get; set; }
    }
    [DataContract]
    public class Action : Clause
    {
        [DataMember]
        public ICollection<Event> Triggerables { get; set; }
        [DataMember]
        public DateTime EffectiveDate { get; set; }
    }
}
