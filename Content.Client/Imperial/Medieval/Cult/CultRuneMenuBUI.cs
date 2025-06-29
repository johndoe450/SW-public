using Content.Shared.Imperial.Medieval.Cult;

namespace Content.Client.Imperial.Medieval.Cult;

/// <summary>
/// Window for carving wrist runes
/// </summary>
public sealed class CultRuneMenuBoundUserInterface : BoundUserInterface
{
    private CultRuneMenuWindow? _window;

    public CultRuneMenuBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey) { }

    protected override void Open()
    {
        base.Open();

        _window = new CultRuneMenuWindow();
        _window.OpenCentered();
        _window.OnClose += Close;
    }

    protected override void UpdateState(BoundUserInterfaceState state)
    {
        if (state is CultRuneMenuBoundUserInterfaceState admState)
            _window?.Update(admState);
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
            _window?.Dispose();
        }
    }
}
