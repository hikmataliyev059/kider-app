using AutoMapper;
using kider_app.Areas.Manage.Helpers.DTOs.Positions;
using kider_app.Models;

namespace kider_app.Areas.Manage.Helpers.Mapper.Positions;

public class PositionMapper : Profile
{
    public PositionMapper()
    {
        CreateMap<CreatePositionDto, Position>().ReverseMap();
        CreateMap<UpdatePositionDto, Position>().ReverseMap();
    }
}
