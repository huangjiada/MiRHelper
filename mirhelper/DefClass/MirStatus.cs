using System.Collections.Generic;

namespace MirHelper
{
    public class GetStatus
    {
        public double battery_percentage { get; set; }

        public int battery_time_remaining { get; set; }

        public double distance_to_next_target { get; set; }
        public List<errors> errors { get; set; }

        public string footprint { get; set; }
     //   public hook_status hook { get; set; }
        public string map_id { get; set; }
        public int mission_queue_id { get; set; }
        public string mission_queue_url { get; set; }
        public string mission_text { get; set; }
        public int mode_id { get; set; }



        public Pos position { get; set; }

        public string robot_name { get; set; }

        public string session_id { get; set; }

        public int state_id { get; set; }

        public string state_text { get; set; }

        public int uptime { get; set; }

        public Vel velocity { get; set; }
    }
}
