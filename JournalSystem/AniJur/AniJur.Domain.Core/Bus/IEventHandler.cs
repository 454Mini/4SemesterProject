﻿using AniJur.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.Domain.Core.Bus
{
    public interface IEventHandler <in TEvent> :IEventHandler
        where TEvent :Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }

}