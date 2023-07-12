using Application.model;
using Domain;

namespace Application.interfaces;

public interface IBoatService {
    public Boat AddBoat(Boat boat);
    public Boat UpdateBoat(Boat updateBoat);
    public Boat DeleteBoat(Guid boatId);
    public BoatResponse GetBoatsByColor(string boatColor);
    public Boat? GetById(Guid boatId);
    public BoatResponse GetAll();
}
