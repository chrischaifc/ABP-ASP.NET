﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MYABP.Contents.DTO
{
    public class UpdateContentInput
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageContent { get; set; }
    }
}
