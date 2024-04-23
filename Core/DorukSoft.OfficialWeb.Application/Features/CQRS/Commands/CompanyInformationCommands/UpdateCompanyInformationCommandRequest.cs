﻿using DorukSoft.OfficialWeb.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace DorukSoft.OfficialWeb.Application.Features.CQRS.Commands.CompanyInformationCommands
{
    public class UpdateCompanyInformationCommandRequest : IRequest<IDTO<object?>>
    {
        public int CompanyInformationId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyTitle { get; set; }
        public IFormFile? AddedImage { get; set; }
        public string? ImageUrl { get; set; }
        public string? WhatsappPhoneNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
