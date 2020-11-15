namespace HouseProject
{
    class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                return base.Description + ((hot) ? "It’s very hot here." : "It is not very hot here.");
            }
        }
    }
}
