using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MuleSoft.DotNet.BusinessLogic;   

namespace MuleSoft.DotNet.GeneralLedgerService
{

    //Interface for our Process GL Service

    [ServiceContract]
    [XmlSerializerFormat]
    public interface IGeneralLedgerService
    {
       [OperationContract]
        TimeSheetForGLResponse ProcessGL(TimeSheetForGL gl);
    }
}


