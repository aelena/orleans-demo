using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using OrleansDemo.Interfaces;
using Orleans.Providers;

namespace OrleansDemo.Classes
{
    /// <summary>
    /// Orleans grain implementation class Grain1.
    /// </summary>
    [StorageProvider ( ProviderName = "AzureStore" )]
    public class HomeAutomationGrain : Orleans.Grain<IHomeAutomationGrainState>, IHomeAutomationGrain
    {


        public override Task ActivateAsync ()
        {
            Console.WriteLine ( "Activated grain {0}", this.GetPrimaryKeyLong () );
            return base.ActivateAsync ();
        }


        public async Task SetHomeTemperature ( double temperature )
        {
            if ( this.State.LastTemperature != temperature )
            {
                this.State.LastTemperature = temperature;
                await this.State.WriteStateAsync ();
            }
            Console.WriteLine ( "Temp received : {0}", temperature );
        }

    }
}
