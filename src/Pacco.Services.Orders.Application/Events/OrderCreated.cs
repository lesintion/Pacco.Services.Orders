using System;
using Convey.CQRS.Events;

namespace Pacco.Services.Orders.Application.Events
{
    [Contract]
    public class OrderCreated : IEvent
    {
        public Guid Id { get; }

        public OrderCreated(Guid id)
        {
            Id = id;
        }
    }
}