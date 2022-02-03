using System;

public class IntroSettingsCmd : ICommand
{
    private readonly MenuController _menuController;

    public Action OnFinished { get; set; }

    public IntroSettingsCmd(MenuController menuController)
    {
        _menuController = menuController;
    }

    public void Execute()
    {
        _menuController.introSettingsObj.gameObject.SetActive(true);
        _menuController.introSettingsObj.OnClickNext += OnClickNext;
    }

    private void OnClickNext()
    {
        _menuController.introSettingsObj.OnClickNext -= OnClickNext;
        _menuController.introSettingsObj.gameObject.SetActive(false);
        OnFinished?.Invoke();
    }
}
