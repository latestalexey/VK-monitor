﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;

namespace VK_Monitor.Domain.Interfaces
{
    public interface IReport
    {
        object GetData(IVkRepository vkRepository, ulong userId);
    }
}
