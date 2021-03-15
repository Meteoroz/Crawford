using Data;
using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IDataLossService
    {
        List<DevLossType> GetLossTypes();
    }
}