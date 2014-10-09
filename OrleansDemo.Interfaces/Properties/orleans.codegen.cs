//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace OrleansDemo.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class HomeAutomationGrainFactory
    {
        

                        public static OrleansDemo.Interfaces.IHomeAutomationGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(OrleansDemo.Interfaces.IHomeAutomationGrain), 1080842075, primaryKey));
                        }

                        public static OrleansDemo.Interfaces.IHomeAutomationGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(OrleansDemo.Interfaces.IHomeAutomationGrain), 1080842075, primaryKey, grainClassNamePrefix));
                        }

                        public static OrleansDemo.Interfaces.IHomeAutomationGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(OrleansDemo.Interfaces.IHomeAutomationGrain), 1080842075, primaryKey));
                        }

                        public static OrleansDemo.Interfaces.IHomeAutomationGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(OrleansDemo.Interfaces.IHomeAutomationGrain), 1080842075, primaryKey, grainClassNamePrefix));
                        }

            public static OrleansDemo.Interfaces.IHomeAutomationGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return HomeAutomationGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("OrleansDemo.Interfaces.OrleansDemo.Interfaces.IHomeAutomationGrain")]
        internal class HomeAutomationGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, OrleansDemo.Interfaces.IHomeAutomationGrain
        {
            

            public static OrleansDemo.Interfaces.IHomeAutomationGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (OrleansDemo.Interfaces.IHomeAutomationGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(OrleansDemo.Interfaces.IHomeAutomationGrain), (global::Orleans.Runtime.GrainReference gr) => { return new HomeAutomationGrainReference(gr);}, grainRef, 1080842075);
            }
            
            protected internal HomeAutomationGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal HomeAutomationGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1080842075;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "OrleansDemo.Interfaces.OrleansDemo.Interfaces.IHomeAutomationGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                HomeAutomationGrainReference input = ((HomeAutomationGrainReference)(original));
                return ((HomeAutomationGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                HomeAutomationGrainReference input = ((HomeAutomationGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return HomeAutomationGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return HomeAutomationGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task OrleansDemo.Interfaces.IHomeAutomationGrain.SetHomeTemperature(double temperature)
            {

                return base.InvokeMethodAsync<object>(-179647451, new object[] {temperature} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("OrleansDemo.Interfaces.OrleansDemo.Interfaces.IHomeAutomationGrain", 1080842075)]
    internal class HomeAutomationGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1080842075;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1080842075:  // IHomeAutomationGrain
                        switch (methodId)
                        {
                            case -179647451: 
                                return ((IHomeAutomationGrain)grain).SetHomeTemperature((Double)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1080842075:  // IHomeAutomationGrain
                    switch (methodId)
                    {
                        case -179647451:
                            return "SetHomeTemperature";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif