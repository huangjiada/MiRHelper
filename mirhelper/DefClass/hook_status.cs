namespace MirHelper
{
    class MirHook
    {
        public float angle { get; set; }
        public bool available { get; set; }
        public bool braked { get; set; }
        public MirCart cart { get; set; }
        public bool cart_attached { get; set; }
        public float height { get; set; }
        public float length { get; set; }
    }
    class MirCart
    {
        public float height { get; set; }
        public float id { get; set; }
        public float length { get; set; }
        public float offset_locked_wheels { get; set; }
        public float width { get; set; }
    }
}
