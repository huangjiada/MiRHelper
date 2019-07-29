namespace MirHelper
{
    public class MirMissionAction
    {
        public string guid { get; set; }
        public string mission_id { get; set; }
        public int action_type_id { get; set; }
        public int priority { get; set; }
        public string scope_reference { get; set; }
        public string mission { get; set; }
        public string parameters { get; set; }
    }
}
