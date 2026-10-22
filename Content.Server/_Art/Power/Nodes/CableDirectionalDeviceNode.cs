using Content.Server.Power.Nodes;
using Content.Shared.NodeContainer;

namespace Content.Server._Art.Power.Nodes
{
    [DataDefinition]
    public sealed partial class CableDirectionalDeviceNode : CableDeviceNode
    {
        public const int CardinalMask =
            (1 << (int)Direction.South) |
            (1 << (int)Direction.East) |
            (1 << (int)Direction.North) |
            (1 << (int)Direction.West);
    }
}