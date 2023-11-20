namespace Class6th
{
	#region 개방 폐쇄 원칙
	// 객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀있어야 합니다.

	public abstract class Unit
	{
		protected int health;
		protected int deffense;

		public abstract void Move();
	}

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("마린 이동 중...");
        }
    }

	public class Firebat : Unit
	{
		public override void Move() 
		{
            Console.WriteLine("파이어 배트 이동 중...");
        }
	}

    public class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine("고스트 이동 중...");
        }
    }

    public class UnitManager
	{
		public void Command(Unit unit)
		{
			unit.Move();
		}
	}

    #endregion
}