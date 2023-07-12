using Application.interfaces;
using Application.model;
using Application.utilities.constants;
using Application.utilities.Exceptions;
using AutoMapper;
using Domain;

namespace Application.services;

public class BusService : IBusService {
    public readonly IMapper _mapper;
    private readonly IVehicleDal _vehicleDal;
    public BusService(IMapper mapper, IVehicleDal vehicleDal) {
        _mapper = mapper;
        _vehicleDal = vehicleDal;
    }
    public Bus AddBus(Bus bus) {
        _vehicleDal.Add(bus);
        return bus;
    }

    public Bus DeleteBus(Guid busId) {
        var bus = GetById(busId) ?? throw new BusNotFoundException(Constant.BusNotFound);
        _vehicleDal.Delete(bus);
        return _mapper.Map<Bus>(bus);

    }

    public BusResponse GetAll() {
        var vehicleList = _vehicleDal.GetList(x => x.VehicleType == Constant.BusType).ToList();
        var busList = _mapper.Map<List<Bus>>(vehicleList);
        return BusResponse.Of(busList);
    }

    public Bus? GetById(Guid busId) {
        var bus = _vehicleDal.GetById(busId);
        return _mapper.Map<Bus>(bus);
    }

    public BusResponse GetBusesByColor(string busColor) {
        var vehicleList = _vehicleDal.GetList(x => x.Color == busColor && x.VehicleType == Constant.BusType).ToList();
        var busList = _mapper.Map<List<Bus>>(vehicleList);
        return BusResponse.Of(busList);
    }

    public Bus UpdateBus(Bus updateBus) {
        _vehicleDal.Update(updateBus);
        return updateBus;
    }
}
