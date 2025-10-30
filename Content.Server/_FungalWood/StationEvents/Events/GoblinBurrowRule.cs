using Content.Server._FungalWood.StationEvents.Components;
using Content.Server.StationEvents.Events;
using Content.Shared.GameTicking.Components;
using Content.Shared.Storage;
using Robust.Server.Player;

namespace Content.Server._FungalWood.StationEvents.Events;

public sealed class GoblinBurrowRule : StationEventSystem<GoblinBurrowRuleComponent>
{
    [Dependency] private readonly IPlayerManager _playerManager = default!;
    protected override void Started(EntityUid uid, GoblinBurrowRuleComponent component, GameRuleComponent gameRule, GameRuleStartedEvent args)
    {
        base.Started(uid, component, gameRule, args);

        int entSpawn = Convert.ToInt32(Math.Round(_playerManager.PlayerCount * component.Ratio) + 1);

        for (var i = 0; i < entSpawn; i++)
        {
            if (!TryFindRandomTile(out _, out _, out _, out var coords))
                continue;

            var ents = EntitySpawnCollection.GetSpawns(component.Prototypes, RobustRandom);
            foreach (var spawn in ents)
            {
                SpawnAtPosition(spawn, coords);
            }
        }
    }
}
