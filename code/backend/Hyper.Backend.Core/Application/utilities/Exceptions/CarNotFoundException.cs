namespace Application.utilities.Exceptions;

public class CarNotFoundException : Exception {
    public CarNotFoundException() : base() {
    }

    public CarNotFoundException(string? message) : base(message) {
    }

    public CarNotFoundException(string? message, Exception? innerException) : base(message, innerException) {
    }
}
