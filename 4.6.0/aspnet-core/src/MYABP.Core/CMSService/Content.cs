using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MYABP.CMSService
{
    //this is the entity class, it use default id
    public class Content : Entity
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;

        [Required]
        [StringLength(MaxTitleLength)]
        public string PageName { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string PageContent { get; set; }

        public Content()
        {

        }

    //    public static Content Create(string pageName, string pageContent)
    //    {
    //        var @content = new Content
    //        {
    //            PageName = pageName,
    //            PageContent = pageContent,
    //        };
    //        return @content;
    //    }
    }
}
