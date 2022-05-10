namespace DesignPatterns.Patterns.Mediator.Abstrations
{
    public interface IMediator
    {
        public void Notify(UIComponent component, string message);
    }
}

