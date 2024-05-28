using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace NazarAspire.Web.Components.Nodes;

public class AddTwoNumbersNode : NodeModel
{
    public AddTwoNumbersNode(Point? position = null) : base(position) { }

    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public double Result => FirstNumber + SecondNumber;
}