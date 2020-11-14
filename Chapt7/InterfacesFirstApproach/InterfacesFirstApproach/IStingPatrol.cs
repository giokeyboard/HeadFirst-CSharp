namespace InterfacesFirstApproach
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }

        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
