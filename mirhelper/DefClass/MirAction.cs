using System.Collections.Generic;

namespace MirHelper
{
    public class MirAction
    {
        public string action_type { get; set; }

        public int action_type_id { get; set; }

        public string finished { get; set; }

        public int id { get; set; }

        public string message { get; set; }

        public List<MirQueueParameter> parameters { get; set; }

        public string started { get; set; }

        public string state { get; set; }
    }
}
