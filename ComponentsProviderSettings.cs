using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components
{
    public abstract class ComponentsProviderSettings
    {
        public abstract List<string> Styles { get; }
        public abstract List<string> Scripts { get; }

        public abstract void Init(IServiceCollection service);
    }
}
