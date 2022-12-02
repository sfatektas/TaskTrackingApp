using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Common
{
    public class Response : IResponse
    {
        public string Message { get;set; }

        public ResponseType ResponseType { get; set; }

        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType,string message)
        {
            Message = message;
            ResponseType = responseType;
        }
    }
}
