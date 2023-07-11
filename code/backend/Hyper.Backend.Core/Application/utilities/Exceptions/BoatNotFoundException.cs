
namespace Application.utilities.Exceptions;

public class BoatNotFoundException : Exception {
    public BoatNotFoundException() : base() {
    }

    public BoatNotFoundException(string? message) : base(message) {
    }

    public BoatNotFoundException(string? message, Exception? innerException) : base(message, innerException) {
    }
}
