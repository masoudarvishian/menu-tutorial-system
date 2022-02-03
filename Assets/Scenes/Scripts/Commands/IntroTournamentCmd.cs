using System;

public class IntroTournamentCmd : ICommand
{
    private readonly MenuController _menuController;

    public Action OnFinished { get; set; }

    public IntroTournamentCmd(MenuController menuController)
    {
        _menuController = menuController;
    }

    public void Execute()
    {
        _menuController.introTournmentObj.gameObject.SetActive(true);
        _menuController.introTournmentObj.OnClickNext += OnClickNext;
    }

    private void OnClickNext()
    {
        _menuController.introTournmentObj.OnClickNext -= OnClickNext;
        _menuController.introTournmentObj.gameObject.SetActive(false);
        OnFinished?.Invoke();
    }
}
