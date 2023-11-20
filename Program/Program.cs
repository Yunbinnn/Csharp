namespace Program
{
    public class GameObject
    {
        private string? name;

        public string Name 
        { 
            set { name = value; } 
            get { return name; } 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션

            // ArrayList
            /*
            ArrayList arrayList = new()
            {
                10,
                "String",
                57.5f,
                'A'
            };

            foreach(var element in arrayList)
            {
                Console.WriteLine(element);
            }

            //  0       1         2      3
            // [10] ["String"] [57.5f] ['A']

            arrayList.Remove(10);
            Console.WriteLine(" ");
            Console.WriteLine("arrayList Count : " + arrayList.Count);

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);

            }
            */

            // List
            /*
             * List<int> list = new()
            {
                Capacity = 10
            };

            // [10] [20] [30] [40] [50] [] [] [] [] []
            list.Add(35);
            list.Add(77);
            list.Add(1);
            list.Add(39);
            list.Add(15);

            list.Remove(45);
            list.RemoveAt(list.Count - 1);

            list.Reverse(); // 리스트 안에 있는 원소를 반전하는 함수
            list.Sort();    // 리스트 안에 있는 원소를 정렬하는 함수

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<string> games = new()
            {
                Capacity = 10
            };

            games.Add("메이플스토리");
            games.Add("서든어택");
            games.Add("바람의나라");
            games.Add("피파온라인");
            games.Add("마구마구");

            Random random = new();
            int tempCount = games.Count;

            for(int i = 0; i< tempCount; i++)
            {
                int rand = random.Next(0, games.Count);
                Console.WriteLine(games[rand]);
                games.RemoveAt(rand);
            }*/

            // Random 클래스
            /*
            Random random = new();

            int rand = random.Next(0, 10);

            Console.WriteLine("rand : " + rand);
            */

            // LinkedList
            /*
            LinkedList<int> linkedList = new();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddLast(100);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }*/

            // Stack
            /*
            Stack<int> stack = new();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            // Pop : 가장 위에 있는 데이터를 삭제합니다.
            stack.Pop();

            // Peek : 가장 위에 있는 데이터를 반환합니다.
            Console.WriteLine("stack Peek : " + stack.Peek()); 

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }*/

            // Queue
            Queue<GameObject> queue = new();

            string[] objects = new string[4] { "Cube", "Sphere", "Capsule", "Cylinder" }; 

            queue.Enqueue(new GameObject()); // []
            queue.Enqueue(new GameObject()); // [] []
            queue.Enqueue(new GameObject()); // [] [] [] 
            queue.Enqueue(new GameObject()); // [] [] [] []

            Console.WriteLine("Queue Size : " + queue.Count);
            Console.WriteLine(" ");

            int queueCount = queue.Count;

            for (int i = 0; i < queueCount; i++)
            {
                GameObject gameObject = queue.Dequeue();
                gameObject.Name = objects[i];
                Console.WriteLine(gameObject.Name);
            }

            #endregion
        }
    }
}