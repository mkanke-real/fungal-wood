using Content.Server._FungalWood.StationEvents.Events;
using Content.Shared.Storage;

namespace Content.Server._FungalWood.StationEvents.Components;

[RegisterComponent, Access(typeof(GoblinBurrowRule))]
public sealed partial class GoblinBurrowRuleComponent : Component
{
    /// <summary>
    /// what's being spawned - future-proofing for goblin hole / burrow variants
    /// </summary>
    [DataField("prototypes")]
    public List<EntitySpawnEntry> Prototypes = new();

    /// <summary>
    /// Amount of prototypes to spawn per player in-round.
    /// </summary>
    [DataField]
    public float Ratio = 0.2f;
}
