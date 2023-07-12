using Application.interfaces;
using Application.model;
using Application.utilities.constants;
using Application.utilities.Exceptions;
using AutoMapper;
using Domain;

namespace Application.services;

public class BoatService : IBoatService {
    public readonly IMapper _mapper;
    private readonly IVehicleDal _vehicleDal;
    public BoatService(IMapper mapper, IVehicleDal vehicleDal) {
        _mapper = mapper;
        _vehicleDal = vehicleDal;
    }
    public Boat AddBoat(Boat boat) {
        _vehicleDal.Add(boat);
        return boat;
    }

    public Boat DeleteBoat(Guid boatId) {
        var result = GetById(boatId) ?? throw new BoatNotFoundException(Constant.BoatNotFound);
        _vehicleDal.Delete(result);
        return _mapper.Map<Boat>(result);

    }

    public BoatResponse GetAll() {
        var vehicleList = _vehicleDal.GetList(x => x.VehicleType == Constant.BoatType).ToList();
        var boatList = _mapper.Map<List<Boat>>(vehicleList);
        return BoatResponse.Of(boatList);
    }

    public Boat? GetById(Guid boatId) {
        var boat = _vehicleDal.GetById(boatId);
        return _mapper.Map<Boat>(boat);
    }

    public BoatResponse GetBoatsByColor(string boatColor) {
        var vehicleList = _vehicleDal.GetList(x => x.Color == boatColor && x.VehicleType == Constant.BoatType).ToList();
        var boatList = _mapper.Map<List<Boat>>(vehicleList);
        return BoatResponse.Of(boatList);
    }

    public Boat UpdateBoat(Boat updateBoat) {
        _vehicleDal.Update(updateBoat);
        return updateBoat;
    }
}
