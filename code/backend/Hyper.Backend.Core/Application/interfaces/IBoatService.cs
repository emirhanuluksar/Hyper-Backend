using Domain;

namespace Application.interfaces;

public interface IBoatService {
    public void AddCar(Boat boat);
    public void UpdateCar(Boat updateBoat);
    public void DeleteCar(Guid boatId);
    public IList<Boat> GetCarsByColor(string boatColor);
    public Boat? GetById(Guid boatId);
    public List<Boat> GetAll();
}
