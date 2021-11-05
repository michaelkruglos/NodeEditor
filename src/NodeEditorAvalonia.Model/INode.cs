﻿using System.Collections.Generic;

namespace NodeEditor.Model
{
    public interface INode
    {
        INode? Parent { get; set; }
        double X { get; set; }
        double Y { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        object? Content { get; set; }
        IList<IPin>? Pins { get; set; }
    }
}
