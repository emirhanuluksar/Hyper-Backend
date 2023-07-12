using Application.model;
using Domain;

namespace Application.interfaces;

public interface IBusService {
    public Bus AddBus(Bus bus);
    public Bus UpdateBus(Bus updateBus);
    public Bus DeleteBus(Guid busId);
    public BusResponse GetBusesByColor(string busColor);
    public Bus? GetById(Guid busId);
    public BusResponse GetAll();
}
