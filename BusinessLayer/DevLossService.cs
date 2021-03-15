using Common.Interfaces;
using Data;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class DevLossService : IDataLossService
    {
        private readonly InterviewContext _context;

        public DevLossService(InterviewContext context)
        {
            _context = context;
        }
        public List<DevLossType> GetLossTypes()
        {
            return _context.DevLossType.ToList();
        }
    }
}
