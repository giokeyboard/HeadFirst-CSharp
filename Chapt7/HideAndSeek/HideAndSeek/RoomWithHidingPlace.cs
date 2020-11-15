namespace HideAndSeek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }

        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            HidingPlaceName = hidingPlace;
        }

        public override string Description { get { return base.Description + $"\r\nSomeone could hide {HidingPlaceName}."; } }
    }
}
