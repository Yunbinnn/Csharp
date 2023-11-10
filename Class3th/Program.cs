namespace Class3th
{
    #region 프로퍼티

    public class Transform
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set
            {
                if (value >= 100)
                {
                    Console.WriteLine("예기치 못한 값이 설정 되었습니다.");
                    return;
                }
                else x = value;
            }
        }
    }

    #endregion

    #region 메소드 숨기기
    public class Weapon
    {
        protected int attack;

        public void Information()
        {
            Console.WriteLine("Weapon 정보");
        }

        public virtual void Action()
        {
            Console.WriteLine("Weapon 동작");
        }
    }

    public class Sword : Weapon
    {
        public new void Information()
        {
            Console.WriteLine("Sword 정보");
        }

        public override void Action()
        {
            Console.WriteLine("Sword 동작");
        }
    }

    #endregion

    #region 함수의 오버로딩

    public class GameObject
    {
        public void Destroy()
        {
            Console.WriteLine("Destroy GameObject");
        }

        public void Destroy(float timer)
        {
            Console.WriteLine("Destory GameObject " + "Destroy Time : " + timer);
        }

        public void GetComponent(string name, int id)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("id : " + id);
        }

        public void SetAcitive(bool acitive = true)
        {
            Console.WriteLine("GameObject state : " + acitive);
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티
            /*
            Transform transform = new() { X = 100 };

            Console.WriteLine("Transform의 x값 : " + transform.X);
            */

            // 메소드 숨기기
            /*
            Sword sword = new();
            sword.Information();
            sword.Action();
            */

            // 가상 함수
            /*
            Weapon weapon = new Sword();
            weapon.Information();
            weapon.Action();
            */

            // 함수의 오버로딩
            /*
            GameObject gameObject = new();
            gameObject.Destroy();
            gameObject.Destroy(5f);

            // 명명된 매개변수
            //gameObject.GetComponent(id: 5, name: "Sphere");
            //gameObject.GetComponent("Box", 10);

            // 선택적 매개변수
            //gameObject.SetAcitive();
            //gameObject.SetAcitive(false);
            */
        }
    }
}