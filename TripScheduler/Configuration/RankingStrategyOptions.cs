namespace TripScheduler.Configuration
{
    public class RankingStrategyOptions
    {
        public int DayWithEventsBadPoints { get; } = 2;
        public int EmptyOneHourSlotBadPoints { get; } = 1;
    }
}