using Content.Shared.Damage;
using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Imperial.Medieval.Cult;

/// <summary>
/// Prototype for a rune in carved in a wrist of someone with the 'CultMemberComponent' by something with the 'CultMeleeComponent'.
/// </summary>
[Prototype("cultRune")]
public sealed partial class CultRunePrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true)]
    public SpriteSpecifier Sprite = SpriteSpecifier.Invalid;

    [DataField(required: true)]
    public List<EntityEffect> Effects = [];

    [DataField]
    public DamageSpecifier CarveDamage = new();
}

public record CultRuneEffectArgs : EntityEffectBaseArgs
{
    public bool Reverse;

    public CultRuneEffectArgs(EntityUid targetEntity, IEntityManager entityManager, bool reverse) : base(targetEntity, entityManager)
    {
        Reverse = reverse;
    }
}
