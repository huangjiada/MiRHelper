using System.Collections.Generic;

namespace MirHelper
{
    public class MirMissionQueueId
    {
        public List<MirAction> actions { get; set; }
        public string control_posid { get; set; }
        public int control_state { get; set; }
        public string finished { get; set; }
        public int id { get; set; }
        public int max_action_id { get; set; }
        public string message { get; set; }
        public string mission { get; set; }
        public string mission_id { get; set; }
        public string ordered { get; set; }
        public string parameters { get; set; }
        public string started { get; set; }
        public string state { get; set; }
    }
}
