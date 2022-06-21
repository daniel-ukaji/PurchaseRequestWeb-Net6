using AutoMapper;
using PurchaseRequest.Web.Data;
using PurchaseRequest.Web.Models;

namespace PurchaseRequest.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
