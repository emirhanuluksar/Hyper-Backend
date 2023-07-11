using Application.interfaces;
using Domain;
using Persistence.Repository;

namespace Persistence;

public class CarDal : Repository<Car>, ICarDal {

}
