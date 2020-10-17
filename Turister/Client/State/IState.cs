namespace Turister.Client.State
{
    public interface IState<T>
    {
        T Data { get; set; }
        T PresetData();
    }
}