namespace HideAndSeek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            HidingPlaceName = hidingPlace;
        }

        public override string Description { get { return base.Description + $"\r\nSomeone could hide {HidingPlaceName}."; } }
    }
}
