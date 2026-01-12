using System;

namespace Adapter
{
    public class FakeAdult : Adult
    {
        private readonly Teenager _teenager;
        public FakeAdult(Teenager teenager)
        {
            _teenager = teenager;
        }
        public override string Name => _teenager.Name;
        public override int Age => _teenager.Age;
        public override bool IsAdult()
        {
            return true;
        }
    }
}