using CoreWCF;
using CoreWCF.Dispatcher;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;

namespace AURRetailService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string ping();
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
  
    public class Service : IService
    {
    //    private ILogger<Service> _logger;

    //    // Parameterized constructor will be called by Dependency Injection
    //    // Logs will be created under the name "LoggingSample.Service" as that's the type name used constructing the logger object
    //    public Service(ILogger<Service> logger)
    //    {
    //        _logger = logger;
    //    }
        public string ping() {
            //_logger.LogInformation("Ping function is called");
            throw new Exception("Test");
            return "pinged";
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
