using System;
using System.Collections.Generic;

namespace PicoYPlacaUtil.Models
{
    public class ResponseObj
    {
        public ResponseObj()
        {
           
        }
        public ResponseObj(int code, string message)
        {
            Code = code;
            Message = message;
        }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
