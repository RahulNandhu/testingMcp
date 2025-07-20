namespace testing.Services;

using testing.Interfaces;

public class CommonServices: ICommonServices

{
    public async Task<string> Greeting(string name)
    {
        await Task.Delay(100);
        return $"Hello, {name}!";
    }
}
