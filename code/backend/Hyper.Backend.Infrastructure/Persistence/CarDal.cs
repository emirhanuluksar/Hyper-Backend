using Application.DataAccess.Repository;
using Application.interfaces;
using Domain;

namespace Persistence;

public class CarDal : Repository<Car>, ICarDal {

}
