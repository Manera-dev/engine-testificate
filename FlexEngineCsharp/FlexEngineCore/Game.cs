using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

namespace FlexEngineCore;

public delegate void UpdateHandler();
public delegate void RenderHandler();

public class EventPublisher
{
    public event UpdateHandler Update;
    public event RenderHandler Render;
    
    public void RaiseUpdate() => Update?.Invoke();
    public void RaiseRender() => Render?.Invoke();
}

public class Game : GameWindow
{
    private Renderer _renderer;
    private Matrix4 _projection;
    private EventPublisher _eventPublisher;
    
    public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {
        _renderer = new Renderer();
        _eventPublisher = new EventPublisher();
    }

    protected override void OnLoad()
    {
        base.OnLoad();
        
        GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
        _renderer.Initialize();
    }
    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);
        GL.Viewport(0, 0, e.Width, e.Height);
        float aspectRatio = (float)e.Width / e.Height;
        _projection = Matrix4.CreateOrthographic(20 * aspectRatio, 20, -1, 1);
    }
    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        base.OnUpdateFrame(args);

        _eventPublisher.RaiseUpdate();
    }
    protected override void OnRenderFrame(FrameEventArgs args)
    {
        base.OnRenderFrame(args);
        
        _eventPublisher.RaiseRender();
    }
}