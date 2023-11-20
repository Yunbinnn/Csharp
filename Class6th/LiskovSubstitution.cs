﻿namespace Class6th
{
	#region 리스코프 치환 원칙
	// 상위 클래스와 하위 클래스가 있을 때
	// 상위 클래스가 호출하는 동작에서 하위 클래스가
	// 상위 클래스를 완벽하게 대체할 수 있어야 하는 원칙입니다.

	public abstract class Zerg
	{
		protected int attack;
		protected int defense;

		public abstract void Move();
	}

	public class GroundUnit : Zerg
	{
        public GroundUnit(int attack, int defense)
        {
            this.attack = attack;
			this.defense = defense;
        }

		public void Ground()
		{
            Console.WriteLine("On the Ground");
        }

        public override void Move()
		{
			Ground();
            Console.WriteLine("Ground Unit Move...");
        }
	}

	public class FlyUnit : Zerg
	{
        public FlyUnit(int attack, int defense)
        {
            this.attack= attack;
			this.defense= defense;
        }

		public void Fly()
		{
            Console.WriteLine("Flying");
        }

        public override void Move()
        {
			Fly();
            Console.WriteLine("Fly Unit Move...");
        }
    }

	public class Drone : GroundUnit
	{
		public Drone() : base(10, 5)
        {
            base.Move();
        }
    }

	#endregion
}