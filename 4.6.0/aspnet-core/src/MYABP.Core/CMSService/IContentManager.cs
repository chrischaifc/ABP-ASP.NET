using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYABP.CMSService
{
    public interface IContentManager : IDomainService
    {
        //Task<Content> GetAsync(Guid id);
        //Task CreateAsync(Content @content);

        IEnumerable<Content> GetAllList();
        Content GetContentByID(int id);
        void Create(Content entity);
        void Update(Content entity);
        void Delete(int id);


    }
}
