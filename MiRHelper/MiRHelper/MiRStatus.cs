using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiRHelper
{
    public class MirStatus
    {
        public double battery_percentage
        {
            get;
            set;
        }

        public int battery_time_remaining
        {
            get;
            set;
        }

        public double distance_to_next_target
        {
            get;
            set;
        }

        public List<StatusError> errors
        {
            get;
            set;
        }

        public string footprint
        {
            get;
            set;
        }

        public int job_id
        {
            get;
            set;
        }

        public string map_id
        {
            get;
            set;
        }

        public Pos position
        {
            get;
            set;
        }

        public string robot_name
        {
            get;
            set;
        }

        public string session_id
        {
            get;
            set;
        }

        public int state_id
        {
            get;
            set;
        }

        public string state_text
        {
            get;
            set;
        }

        public int uptime
        {
            get;
            set;
        }

        public Vel velocity
        {
            get;
            set;
        }
    }

}
