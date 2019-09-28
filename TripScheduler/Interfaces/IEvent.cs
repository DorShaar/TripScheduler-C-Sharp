namespace TripScheduler.Interfaces
{
     internal interface IEvent
     {
          string EventName { get; }
          string Location { get; }
          EventTime EventTime { get; }
     }
}