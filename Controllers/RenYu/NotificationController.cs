﻿using HotelFuen31.APIs.Dtos.RenYu;
using HotelFuen31.APIs.Hubs;
using HotelFuen31.APIs.Services.RenYu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace HotelFuen31.APIs.Controllers.RenYu
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationService _service;
        private IHubContext<MessageHub, IMessageHub> _hub;

        public NotificationController(NotificationService service, IHubContext<MessageHub, IMessageHub> hub)
        {
            _service = service;
            _hub = hub;
        }

        [HttpGet]
        public async Task<IEnumerable<NotificationDto>> GetNotifications()
        {
            return await _service.GetNotification().ToListAsync();
        }

        [HttpPost]
        public string ToAll()
        {
            List<string> messages = new List<string>();
            messages.Add("First Notification");
            messages.Add("Second Notification");

            _hub.Clients.All.sendToAllConnection(messages);

            return "成功推播通知至全體";
        }
    }
}
