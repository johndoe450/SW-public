using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Imperial.Medieval.Cult;

public sealed class CultRuneMenuBoundUserInterfaceState : BoundUserInterfaceState
{
}

public sealed class CultRuneMenuCarveMessage : BoundUserInterfaceMessage
{
    /// <summary>
    /// If set then rune is being carved at target's left hand (right otherwise).
    /// </summary>
    public bool IsLeft;

    public ProtoId<CultRunePrototype> RuneId;
}

[Serializable, NetSerializable]
public enum CultRuneMenuUiKey
{
    Key
}
