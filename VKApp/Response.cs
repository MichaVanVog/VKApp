using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKApp
{
    public class Response<T>
    {
        public IList<T>? response { get; set; }
    }
}
