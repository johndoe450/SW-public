using Content.Shared.Damage;
using Content.Shared.Imperial.Medieval.Cult;
using Robust.Shared.Prototypes;

namespace Content.Server.Cult.Components;

[RegisterComponent]
public sealed partial class CultMemberComponent : Component
{
    [DataField]
    public EntityUid? Parent;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField]
    public DamageSpecifier Damage = new()
    {
        DamageDict = new()
            {
                { "Poison", 10 },
                { "Asphyxiation", 10}
            }
    };

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public ProtoId<CultRunePrototype>? LeftRuneProto;

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public ProtoId<CultRunePrototype>? RightRuneProto;
}
