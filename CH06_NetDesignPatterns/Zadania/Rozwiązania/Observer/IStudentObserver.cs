namespace Observer
{
    public interface IStudentObserver
    {
        string Name { get; }
        void ReceiveGrade(int grade);
    }
}