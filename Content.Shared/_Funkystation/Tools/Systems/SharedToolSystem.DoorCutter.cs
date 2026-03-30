using Content.Shared._Funkystation.Tools.Components;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Components.SolutionManager;
using Content.Shared.Database;
using Content.Shared.DoAfter;
using Content.Shared.Examine;
using Content.Shared.FixedPoint;
using Content.Shared.Interaction;
using Content.Shared.Item.ItemToggle.Components;
using Content.Shared.Popups;
using Content.Shared.Tag;
using Content.Shared.Tools.Components;
using Content.Shared.Tools.Systems;

namespace Content.Shared._Funkystation.Tools.Systems;

public sealed class SharedToolSystemDoorCutter : EntitySystem
{
    [Dependency] private readonly TagSystem _tag = default!;
    [Dependency] private readonly SharedPopupSystem _popup = default!;
    public override void Initialize()
    {
        SubscribeLocalEvent<DoorCutterComponent, AfterInteractEvent>(OnInteract);
        SubscribeLocalEvent<DoorCutterComponent, DoAfterEvent>(OnDoAfterComplete);
    }

    private void OnInteract(EntityUid uid, DoorCutterComponent comp, AfterInteractEvent args)
    {
            if (args.Target == null)
                return;
            if (!_tag.HasTag(args.Target.Value, "CuttableDoor"))
            {
                //cut da door
            }
            else
            {
                //do not cut da door
                _popup.PopupEntity(Loc.GetString("doorcutter-invalid-target"), uid);
                return;
            }
    }

    private void OnDoAfterComplete(EntityUid uid, DoorCutterComponent comp, DoAfterEvent args)
    {
        // TODO: Actions that fire when the doafter completes successfully
        if (args.Cancelled)
            return;
    }
}
