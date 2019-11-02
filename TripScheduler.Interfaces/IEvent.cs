namespace TripScheduler.Interfaces
{
    public interface IEvent
    {
        string EventName { get; }
        string Location { get; }
        IEventTime EventTime { get; }
    }
}