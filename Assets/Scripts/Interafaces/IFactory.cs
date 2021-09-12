using Scriptables;

namespace Interfaces
{
    public interface IFactory<T>
    {
         T Create(CarSpecifications specifications);
    }
}