using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYABP.CMSService
{
    //this is the domin service part
    public class ContentManager : DomainService, IContentManager
    {
        private readonly IRepository<Content> _repositoryContent;

        public ContentManager(IRepository<Content> repositoryContent)
        {
            _repositoryContent = repositoryContent;
        }

        public void Create(Content entity)
        {
            
            var content = _repositoryContent.FirstOrDefault(x => x.Id == entity.Id);
            if (content != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
           
            content = new Content { Id = entity.Id ,PageContent = entity.PageContent, PageName = entity.PageName };
            _repositoryContent.Insert(content);
        }

        public void Delete(int id)
        {
            var content = _repositoryContent.FirstOrDefault(x => x.Id == id);
            if (content == null)
            {
                throw new UserFriendlyException("No Data");
            }
            else
            {
                _repositoryContent.Delete(content);
            }
        }

        public IEnumerable<Content> GetAllList()
        {
            return _repositoryContent.GetAll();
        }

        public Content GetContentByID(int id)
        {
            return _repositoryContent.Get(id);
        }

        public void Update(Content entity)
        {
            _repositoryContent.Update(entity);
        }
    }
}
