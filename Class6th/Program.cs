namespace Class6th
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

            //Marine marine = new();
            //Firebat firebat = new();
            //Ghost ghost = new();

            //UnitManager unitManager = new();

            //unitManager.Command(marine);
            //unitManager.Command(firebat);
            //unitManager.Command(ghost);

            #endregion

            #region ISP 5대 원칙

            //Wraith wraith = new();

            //wraith.Move();
            //wraith.Attack();
            //wraith.Skill();

            //BattleCruiser battleCruiser = new();

            //battleCruiser.Move();
            //battleCruiser.Attack();
            //battleCruiser.Skill();

            //Valkyrie valkyrie = new();

            //valkyrie.Move();
            //valkyrie.Attack();

            //DropShip dropShip = new();

            //dropShip.Move();
            //dropShip.Skill();

            #endregion

            #region DIP 5대 원칙

            //Character character = new(100, new Knife());

            //character.ChangeWeapon(new Axe());
            //character.ChangeWeapon(new Rifle());

            #endregion

            #region LSP 5대 원칙

            //Drone drone = new();

            #endregion
        }
    }
}