﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.MVC.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IActionResult : IInvocable
    {
        IRenderable Action { get; set; }
    }
}
