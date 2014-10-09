using System;
using OrleansDemo.Interfaces;

namespace OrleansDemo.LocalSilo
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main ( string [] args )
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain ( "OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            } );

            Orleans.OrleansClient.Initialize ( "DevTestClientConfiguration.xml" );

            // TODO: once the previous call returns, the silo is up and running.
            //       This is the place your custom logic, for example calling client logic
            //       or initializing an HTTP front end for accepting incoming requests.
            var grain = HomeAutomationGrainFactory.GetGrain ( 0 );

            while ( true )
            {
                grain.SetHomeTemperature ( Double.Parse ( Console.ReadLine () ) );
            }


            Console.WriteLine ( "Orleans Silo is running.\nPress Enter to terminate..." );
            Console.ReadLine ();

            hostDomain.DoCallBack ( ShutdownSilo );
        }

        static void InitSilo ( string [] args )
        {
            hostWrapper = new OrleansHostWrapper ( args );

            if ( !hostWrapper.Run () )
            {
                Console.Error.WriteLine ( "Failed to initialize Orleans silo" );
            }
        }

        static void ShutdownSilo ()
        {
            if ( hostWrapper != null )
            {
                hostWrapper.Dispose ();
                GC.SuppressFinalize ( hostWrapper );
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
