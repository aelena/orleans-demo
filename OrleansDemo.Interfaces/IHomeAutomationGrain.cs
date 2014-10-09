using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace OrleansDemo.Interfaces
{
    /// <summary>
    /// Orleans grain communication interface IHomeAutomationGrain
    /// </summary>
    public interface IHomeAutomationGrain : Orleans.IGrain
    {
        Task SetHomeTemperature ( double temperature );
    }

    public interface IHomeAutomationGrainState : IGrainState
    {
        double LastTemperature { get; set; }
    }
}
