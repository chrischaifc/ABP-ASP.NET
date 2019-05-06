using Abp.Application.Services;
using MYABP.Contents.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYABP.Contents
{
    public interface IContentAppService : IApplicationService
    {
        IEnumerable<GetContentOutput> ListAll();
        void Create(CreateContentInput input);
        void Update(UpdateContentInput input);
        GetContentOutput GetContentById(GetContentInput input);
    }
}
