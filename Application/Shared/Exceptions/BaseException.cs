using Application.Shared.Enums;

namespace Application.Shared.Exceptions;

public class BaseException(ExceptionCode code, string message) : Exception($"{code}: {message}")
{
    protected readonly ExceptionCode _code = code;
}