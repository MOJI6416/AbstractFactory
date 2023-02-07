namespace AbstractFactory
{
    public abstract class AbstractLevel
    {
        public Car c;
        public Road r;
        public Finish f;
        public abstract Car createCar();
        public abstract Road createRoad();
        public abstract Finish createFinish();
        public abstract void Play();
    }
}