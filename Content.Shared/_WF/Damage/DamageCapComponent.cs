using Robust.Shared.GameStates;

namespace Content.Shared._WF.Damage;

[RegisterComponent, NetworkedComponent]
public sealed partial class DamageCapComponent : Component
{
    /// <summary>
    /// Maximum allowed damage for all damage types. (Yes, this is generalized. Fight me.)
    /// </summary>
    [DataField]
    public int DamageCap = 3500;
}
