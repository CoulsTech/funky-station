using Content.Shared._Funkystation.Tools.Components;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Components.SolutionManager;
using Content.Shared.Database;
using Content.Shared.DoAfter;
using Content.Shared.Examine;
using Content.Shared.FixedPoint;
using Content.Shared.Interaction;
using Content.Shared.Item.ItemToggle.Components;
using Content.Shared.Tools.Components;
using Content.Shared.Tools.Systems;

namespace Content.Shared._Funkystation.Tools.Systems;

public sealed class SharedToolSystemDoorCutter : EntitySystem
{
    public override void Initialize()
    {

    }

    private void OnInteract(EntityUid uid, DoorCutterComponent comp, AfterInteractEvent args)
    {

    }

    private void OnDoAfterComplete(EntityUid uid, DoorCutterComponent comp, DoAfterEvent args)
    {

    }
}
