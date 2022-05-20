namespace DesignPatterns.Patterns.Mediator.Abstrations
{
    public abstract class UIComponent
    {
        protected UIMediator mediator;

        protected UIComponent(UIMediator mediator)
        {
            this.mediator = mediator;
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool Visible {get; set;} = true;

        public virtual void Click()
        {
            mediator.Notify(this, "Click");
        }
    }
}