using Domain;

namespace Application.interfaces;

public interface IBusService {
    public void AddCar(Bus bus);
    public void UpdateCar(Bus updateBus);
    public void DeleteCar(Guid busId);
    public IList<Bus> GetCarsByColor(string busColor);
    public Bus? GetById(Guid busId);
    public List<Bus> GetAll();
}
