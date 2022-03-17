using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Models
{
    public class BaseModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
    }
}
