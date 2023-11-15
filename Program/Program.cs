namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙

            //Monster spider = new("독거미", 10, 100);

            //spider.Patrol();

            //Information information = new();

            //information.MonseterInfo(spider); 

            #endregion

            #region OCP 5대 원칙

            Marine marine = new();
            Firebat firebat = new();
            Ghost ghost = new();

            UnitManager unitManager = new();

            unitManager.Command(marine);
            unitManager.Command(firebat);
            unitManager.Command(ghost);

            #endregion
        }
    }
}