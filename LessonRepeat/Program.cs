using System.Security.Cryptography;

namespace LessonRepeat
{
    enum Condition
    {
        Bad,
        Well,
        Good, 
        Excellent
    }

    enum Status
    {
        onWork, 
        offWork,
        inVacation
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Automobile
        {
            public string Mark { get; set; }
            public long Number { get; set; }

            public Condition Condition { get; set; }


            public void SetCondition(Condition newCondition)
            {
                Condition = newCondition;
            }
        }

        class Driver
        {
            public Driver(string name, Status currentStatus)
            {
                Name = name;
                CurrentStatus = currentStatus;
            }

            public string Name { get; set; }
            public Status CurrentStatus { get; set; }

            public void SetAnOrder()
            {

            }


            public void MarkTripAsOver()
            {

            }
        }

        class Operator
        {
            public void TripDistribution(Driver driver, Trip trip )
            {

            }

            public void FireDriver(Driver driver)
            {

            }
        }

        public class Trip
        {
            public long TripNumber { get; set; }
            public DateTime TripStartTime { get; set; }

            public DateTime TripEndTime { get; set; }

            public string TripDescribtion { get; set; }


        }
    }
}