namespace Program
{
    public class Magnet : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Magnet");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("wait time : " + timer);
        }
    }
}