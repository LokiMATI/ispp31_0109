public interface IMovable
{
    const int MinSpeed = 0;
    static int MazSpeed = 60;
    void Move();
    string SpeedInfo {  get; }
}