using Application.interfaces;
using Application.services;
using Domain;
using Hyper.Backend.Web.Infrastructure;
using Persistence;
using Persistence.Repository;

namespace WebAPI.Infrastructure;

public static class IocRegistrations {
    public static void AddIocRegistrations(this WebApplicationBuilder builder) {
        builder.Services.AddScoped<IVehicleService, VehicleService>();
        builder.Services.AddScoped<IVehicleDal, VehicleDal>();
        builder.Services.AddScoped<ICarService, CarService>();
        builder.Services.AddScoped<IBusService, BusService>();
        builder.Services.AddScoped<IBoatService, BoatService>();
        builder.Services.AddAutoMapper(typeof(BkhMappingProfile));
    }
}
