using System;

public class IntroPlayCmd : ICommand
{
    private readonly MenuController _menuController;

    public Action OnFinished { get; set; }

    public IntroPlayCmd(MenuController menuController)
    {
        _menuController = menuController;
    }

    public void Execute()
    {
        _menuController.introPlayObj.gameObject.SetActive(true);
        _menuController.introPlayObj.OnClickNext += OnClickNext;
    }

    private void OnClickNext()
    {
        _menuController.introPlayObj.OnClickNext -= OnClickNext;
        _menuController.introPlayObj.gameObject.SetActive(false);
        OnFinished?.Invoke();
    }
}
