using FlexEngineCore;
using System;

namespace Sandbox;

internal class Program
{
    public static void Main(string[] args)
    {
        using (var game = new Game(gameSettings, nativeSettings))
        {
            game.Run();
        }
    }
}