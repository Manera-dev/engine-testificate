namespace FlexEngineCore.Scripting;

public class Behaviour
{
    public void SubscribeToEvents(EventPublisher _publisher)
    {
        _publisher.Update += Update;
        _publisher.Render += Render;
    }

    void Update() {}

    void Render() {}
}