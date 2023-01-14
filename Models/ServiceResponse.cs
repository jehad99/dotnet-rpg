using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rbg.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Status { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
