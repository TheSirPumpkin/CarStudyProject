namespace Interfaces
{
    public interface IBuyable
    {
        string Id { get; set; }
        float Cost { get; set; }
        bool Bought { get; set; }
    }
}