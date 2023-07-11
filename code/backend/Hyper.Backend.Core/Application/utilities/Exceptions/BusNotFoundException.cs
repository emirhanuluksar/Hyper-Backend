namespace Application.utilities.Exceptions;
public class BusNotFoundException : Exception {
    public BusNotFoundException() : base() {
    }

    public BusNotFoundException(string? message) : base(message) {
    }

    public BusNotFoundException(string? message, Exception? innerException) : base(message, innerException) {
    }
}

