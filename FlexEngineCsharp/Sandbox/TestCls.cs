using FlexEngineCore;
using FlexEngineCore.Scripting;

namespace Sandbox;

public class TestCls : Behaviour
{
    void Update()
    {
        Console.WriteLine("Update");
    }

    void Render()
    {
        Console.WriteLine("Render");
    }
}