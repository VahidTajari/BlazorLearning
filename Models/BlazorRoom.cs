namespace Session4.Models
{
    public sealed class BlazorRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }

        public List<BlazorRoomProp> Props { get; set; }
    }

    public sealed class BlazorRoomProp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
