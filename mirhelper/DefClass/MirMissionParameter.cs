using System.Runtime.CompilerServices;

namespace MirHelper
{
    public class MirMissionParameter
    {
        public string guid { get; set; }

        public string action_id { get; set; }

        public string action { get; set; }

        public string mission_action { get; set; }

        public string mission { get; set; }

        public string name { get; set; }

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

        public bool is_input { get; set; }

        public string input_name { get; set; }

        public int type_id { get; set; }
    }
}
