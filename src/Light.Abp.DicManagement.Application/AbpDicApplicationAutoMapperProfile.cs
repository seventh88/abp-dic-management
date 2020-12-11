using AutoMapper;

namespace Light.Abp.DicManagement
{
    public class AbpDicManagementApplicationAutoMapperProfile : Profile
    {
        public AbpDicManagementApplicationAutoMapperProfile()
        {
            CreateMap<Dic, DicDto>().ReverseMap();
            CreateMap<Dic, CreateDicDto>().ReverseMap();
            CreateMap<Dic, UpdateDicDto>().ReverseMap();

            CreateMap<ComplexDic, ComplexDicDto>().ReverseMap();
            CreateMap<ComplexDic, CreateComplexDicDto>().ReverseMap();
            CreateMap<ComplexDic, UpdateComplexDicDto>().ReverseMap();
        }
    }
}
