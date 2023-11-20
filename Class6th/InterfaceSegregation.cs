namespace Class6th
{
	#region 인터페이스 분리 원칙
	// 클라이언트가 자신이 사용하지 않는 함수에 의존하지 않아야 하며,
	// 인터페이스를 구체적이고 작은 단위로 분리하여 사용하는 원칙입니다.
	
	public interface IMoveable
	{
		public void Move();
	}

	public interface IAttackable
	{
		public void Attack();
	}

	public interface ISkillable
	{
		public void Skill();
	}

    public class Wraith : IMoveable, IAttackable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("레이스 이동 중...");
        }

        public void Attack()
        {
            Console.WriteLine("레이스 공격");
        }

        public void Skill()
        {
            Console.WriteLine("은신 중...");
        }
    }

    public class BattleCruiser : IMoveable, IAttackable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("배틀 크루저 이동 중...");
        }

        public void Attack()
        {
            Console.WriteLine("배틀 크루저 공격");
        }

        public void Skill()
        {
            Console.WriteLine("야마토");
        }
    }

    public class Valkyrie : IMoveable, IAttackable
    {
        public void Move()
        {
            Console.WriteLine("발키리 이동 중...");
        }

        public void Attack()
        {
            Console.WriteLine("발키리 공격");
        }
    }

    public class DropShip : IMoveable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("드랍쉽 이동 중...");
        }

        public void Skill()
        {
            Console.WriteLine("유닛 배송 중...");
        }
    }

    #endregion
}