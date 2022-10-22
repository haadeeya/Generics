namespace ClassLibrary1
{
    public interface ICustomStack<T> : IReadOnlyCustomStack<T>
    {
        void Push(T interns);
    }
}