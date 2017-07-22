using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Lind.IX.Common.Objects;

namespace Lind.IX.Services.Actors
{
    public interface IIXRegistry
    {
        Task Register<T>(T obj, CancellationToken token = default(CancellationToken))
            where T : IXObject, new();
        Task Fetch<T>(Uri uri, CancellationToken token = default(CancellationToken))
            where T : IXObject, new();
        Task Delete(Uri uri, CancellationToken token = default(CancellationToken));
        
    }
}
