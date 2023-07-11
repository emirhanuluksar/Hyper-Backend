using Application.interfaces;
using Application.utilities.Exceptions;
using Domain;

namespace Application.services;

public class BusService : IBusService {
    private readonly IBusDal _busDal;
    public BusService(IBusDal busDal) {
        _busDal = busDal;
    }
    public void AddCar(Bus bus) {
        _busDal.Add(bus);
    }

    public void DeleteCar(Guid busId) {
        var result = GetById(busId) ?? throw new BusNotFoundException("Car not found!");
        _busDal.Delete(result);
    }

    public List<Bus> GetAll() {
        return _busDal.GetAll().ToList();
    }

    public Bus? GetById(Guid busId) {
        return _busDal.GetById(busId);
    }

    public IList<Bus> GetCarsByColor(string busColor) {
        return _busDal.GetByColor(busColor);
    }

    public void UpdateCar(Bus updateBus) {
        _busDal.Update(updateBus);
    }
}
