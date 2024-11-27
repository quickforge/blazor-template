namespace Application.Shared.Interfaces;

public interface IMockBuilder<T>
{
    T BuildMock();
}