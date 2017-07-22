using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using System.Threading;

namespace Lind.IX.Services.Actors
{
    public interface IIXActor : IActor
    {
        Uri IXId { get;}
        IIXRegistry Registry { get; set; }
        Task Destroy(CancellationToken token = default(CancellationToken));
        
    }
}
