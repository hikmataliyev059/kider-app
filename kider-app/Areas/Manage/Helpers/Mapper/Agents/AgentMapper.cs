using AutoMapper;
using kider_app.Areas.Manage.Helpers.DTOs.Agents;
using kider_app.Models;

namespace kider_app.Areas.Manage.Helpers.Mapper.Agents;

public class AgentMapper : Profile
{
    public AgentMapper()
    {
        CreateMap<CreateAgentDto, Agent>().ReverseMap();
        CreateMap<UpdateAgentDto, Agent>().ReverseMap();
    }
}
