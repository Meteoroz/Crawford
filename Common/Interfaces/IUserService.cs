namespace Common.Interfaces
{
    public interface IUserService
    {
        bool Login(string userName, string password);
    }
}