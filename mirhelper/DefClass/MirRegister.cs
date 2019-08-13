using System.Runtime.CompilerServices;

namespace MirHelper
{
    public class MirRegister
    {
        public int id { get; set; }

        public double value
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
