using UnityEngine;

namespace DefaultNamespace
{
    public class Test2
    {
        private int _qwe = 2;

        public int Qwe
        {
            get { return _qwe; } 
            set { _qwe = value; }
        }

        public int Qwe2
        {
            set { _qwe = value; }
        }

        public int Qwe3 => _qwe;

        public void SayHello()
        {
            Debug.Log("Hello");
        }

        public Test2() : this(10)
        {
        }
        
        public Test2(int a)
        {
            this._qwe = a + 1;
        }
    }

    public struct Vector2
    {
        float x;
        float y;
    }
}