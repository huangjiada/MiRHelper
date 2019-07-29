namespace MirHelper
{
    public class MirMission
    {
        public string guid { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public bool read_only { get; set; }

        public string session_id { get; set; }

        public bool show_in_app { get; set; }

        public bool hide_in_missionlist { get; set; }

        public bool delete_after_finish { get; set; }

        public string inputs { get; set; }

        public string actions { get; set; }
    }
}
