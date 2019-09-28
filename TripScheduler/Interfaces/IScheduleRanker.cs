using System;
using System.Threading.Tasks;

namespace TripScheduler.Interfaces
{
     internal interface IScheduleRanker
     {
          double RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm);
     }
}