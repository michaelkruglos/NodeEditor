using System.Collections;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls.Primitives;
using NodeEditor.Model;

namespace NodeEditor.Controls;

public class Toolbox : TemplatedControl
{    
    public static readonly StyledProperty<IEnumerable<INodeTemplate>?> TemplatesSourceProperty =
        AvaloniaProperty.Register<Toolbox, IEnumerable<INodeTemplate>?>(nameof(TemplatesSource));

    public IEnumerable<INodeTemplate>? TemplatesSource
    {
        get => GetValue(TemplatesSourceProperty);
        set => SetValue(TemplatesSourceProperty, value);
    }
}
