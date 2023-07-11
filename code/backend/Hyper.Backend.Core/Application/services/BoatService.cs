using Application.interfaces;
using Application.utilities.Exceptions;
using Domain;

namespace Application.services;

public class BoatService : IBoatService {
    public readonly IBoatDal _boatDal;
    public BoatService(IBoatDal boatDal) {
        _boatDal = boatDal;
    }
    public void AddCar(Boat boat) {
        _boatDal.Add(boat);
    }

    public void DeleteCar(Guid boatId) {
        var result = GetById(boatId) ?? throw new BoatNotFoundException("Boat not found!");
        _boatDal.Delete(result);
    }

    public List<Boat> GetAll() {
        return _boatDal.GetAll().ToList();
    }

    public Boat? GetById(Guid boatId) {
        return _boatDal.GetById(boatId);
    }

    public IList<Boat> GetCarsByColor(string boatColor) {
        return _boatDal.GetByColor(boatColor);
    }

    public void UpdateCar(Boat updateBoat) {
        _boatDal.Update(updateBoat);
    }
}
