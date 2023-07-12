namespace Application.utilities.Exceptions;

public class CarAlreadyExistsException : Exception {
    public CarAlreadyExistsException() : base() {
    }

    public CarAlreadyExistsException(string? message) : base(message) {
    }

    public CarAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) {
    }
}
