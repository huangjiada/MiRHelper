using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiRHelper
{

    public class MiRAction
    {
        public string action_type
        {
            get;
            set;
        }

        public int action_type_id
        {
            get;
            set;
        }

        public string finished
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }

        public List<MiRQueueParameter> parameters
        {
            get;
            set;
        }

        public string started
        {
            get;
            set;
        }

        public string state
        {
            get;
            set;
        }
    }

}
