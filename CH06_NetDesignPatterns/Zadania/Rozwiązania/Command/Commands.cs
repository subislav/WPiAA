namespace Command
{
    public class ToyCommand : ICommand
    {
        private readonly SantaClausFactory _factory;
        private readonly string _toyName;
        public ToyCommand(SantaClausFactory factory, string toyName)
        {
            _factory = factory;
            _toyName = toyName;
        }
        public void Execute()
        {
            _factory.ProduceToy(_toyName);
        }
    }
    public class StickCommand : ICommand
    {
        private readonly SantaClausFactory _factory;
        private readonly string _childName;

        public StickCommand(SantaClausFactory factory, string childName)
        {
            _factory = factory;
            _childName = childName;
        }
        public void Execute()
        {
            _factory.ProduceStick(_childName);
        }
    }
}