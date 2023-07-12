using Application.model;
using AutoMapper;
using Domain;

namespace Hyper.Backend.Web.Infrastructure;

public class BkhMappingProfile : Profile {
    public BkhMappingProfile() {
        CreateMap<CarRequest, Vehicle>();
        CreateMap<CarRequest, Car>();
        CreateMap<BusRequest, Bus>();
        CreateMap<BoatRequest, Boat>();
    }
}
