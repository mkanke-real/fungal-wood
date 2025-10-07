using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

/// <summary>
/// Changes footstep sound
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FootstepModifierComponent : Component
{
    [DataField, AutoNetworkedField]
    public SoundSpecifier? FootstepSoundCollection;

    /// <summary>
    ///  fungalwood - allows an object to change the footstep modifier when held rather than just when worn
    /// </summary>
    [ViewVariables]
    [DataField]
    public bool AllowOnHeld = false;
}
