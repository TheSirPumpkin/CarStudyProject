
namespace CarInterfaces
{
    public interface IBuyable
    {
        float Cost { get; set; }
        void Buy(float money);// transfer to shop class But(Customer :ICustomer c, Ibuyable)
    }
}
