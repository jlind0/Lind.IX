using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using System.Threading;
using Lind.IX.Common.Objects;

namespace Lind.IX.Services.Actors
{
    public abstract class IXActor<T> : Actor, IIXActor
        where T: IXObject, new()
    {
        protected IActorService Service { get; private set; }
        protected IXActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
            this.Service = actorService;
        }
        
        public Uri ActorId { get; set; }
        public IIXRegistry Registry { get; set; }

        public Uri IXId => throw new NotImplementedException();

        public virtual Task Destroy(CancellationToken token = default(CancellationToken))
        {
            return this.Service.DeleteActorAsync(this.Id, token);
        }
        protected override Task OnActivateAsync()
        {
            return base.OnActivateAsync();
        }
        protected override Task OnDeactivateAsync()
        {
            return base.OnDeactivateAsync();
        }
    }
}
