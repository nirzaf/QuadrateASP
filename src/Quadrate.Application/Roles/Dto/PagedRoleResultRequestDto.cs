﻿using Abp.Application.Services.Dto;

namespace Quadrate.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

