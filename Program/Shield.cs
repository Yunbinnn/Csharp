namespace Program
{
    public class Shield : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Shield");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("wait time : " + timer);
        }
    }
}