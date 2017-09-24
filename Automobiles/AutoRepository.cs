using Automobiles.Autos;

namespace Automobiles
{
    public class AutoRepository
    {
        public AutomobileBase Find(string carName)
        {
            if (carName.Contains("mini"))
                return new MiniCooper();
            else if (carName.Contains("bmw"))
                return new BMW335XI();

            return AutomobileBase.NULL;
        }
    }
}