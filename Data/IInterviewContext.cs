using Microsoft.EntityFrameworkCore;

namespace Data
{
    public interface IInterviewContext
    {
        DbSet<DevLossType> DevLossType { get; set; }
        DbSet<DevUser> DevUser { get; set; }
    }
}