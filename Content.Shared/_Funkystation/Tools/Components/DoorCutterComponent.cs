namespace Content.Shared._Funkystation.Tools.Components
{
    [RegisterComponent]
    public sealed partial class DoorCutterComponent : Component
    {
        public string Name => "DoorCutter";
        public float CutTime = 3.0f;
        public string ValidTargetTag = "CuttableDoor";
    }
}
