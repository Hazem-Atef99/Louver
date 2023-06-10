using AutoMapper;
using Louver.DataModel;
using Louver.Models;

namespace Louver.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<ClientFile, clientFileDTO>();
            CreateMap<Status, statusDTO>();
            CreateMap<updateClientFile, ClientFile>();
            CreateMap<AnClientFileDetail,AnClientFileDetailDTO>();
            CreateMap<AnClientFileDetailDTO, AnClientFileDetail>();

            CreateMap<AnCuttingListDetail, AnCuttingListDetailDTO>();
            CreateMap<AnCuttingListDetailDTO, AnCuttingListDetail>();

        }

    }
}
