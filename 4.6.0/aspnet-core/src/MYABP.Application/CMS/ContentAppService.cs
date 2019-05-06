using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using MYABP.CMSService;
using MYABP.Contents.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYABP.Contents
{
    //this is the applicaiton service part
    public class ContentAppService : ApplicationService, IContentAppService
    {
        private readonly IContentManager _contentManager;

        public ContentAppService(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }
        public void Create(CreateContentInput input)
        {
           
            var output = input.MapTo<Content>();
            _contentManager.Create(output);
        }

        public GetContentOutput GetContentById(GetContentInput input)
        {
            var getContent = _contentManager.GetContentByID(input.Id);
            GetContentOutput output = Mapper.Map<Content, GetContentOutput>(getContent);
            return output;
        }

        public IEnumerable<GetContentOutput> ListAll()
        {
            var getAll = _contentManager.GetAllList().ToList();
            List<GetContentOutput> output = Mapper.Map<List<Content>, List<GetContentOutput>>(getAll);
            return output;
        }

        public void Update(UpdateContentInput input)
        {
            var output = input.MapTo<Content>();
            _contentManager.Update(output);

        }
    }
}
