using System.Runtime.Serialization;

namespace ConsoleApp4
{
    public abstract class Human : IMove
    {
        private int _speed;
        public int CurrentSpeed
        {
            get { return _speed; }
            set { _speed = GetSpeed(value); }
        }
        public int Time { get; set; }

        private const int _maxSpeed = 30;

        public double Distans { get; set; } = 50;

        public Human(int speed, int time)
        {
            CurrentSpeed=speed;
            Time = time;
        }

        public double Move()
        {
            return Distans = _speed * Time;
        }

        public int GetSpeed(int speed) {
            return speed < _maxSpeed ? speed : _maxSpeed;
        }
    }


}
