using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiRHelper
{
    public class MiRQueueParameter
    {
        public string input_name
        {
            get;
            set;
        }

        public string value
        {
            [CompilerGenerated]
            get
            {
                return value;
            }
            [CompilerGenerated]
            set
            {
                this.value = value;
            }
        }
    }
}
