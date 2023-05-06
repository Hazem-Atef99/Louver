using AutoMapper;
using Louver.DataModel;
//using Louver.dataModel;
using Louver.Models;

namespace Louver.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<ClientFile, clientFileDTO>();
            //CreateMap<ClientFileModel, ClientFile>();
        }

    }
}
