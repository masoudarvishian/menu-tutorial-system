using System;

public class IntroTaskCmd : ICommand
{
    private readonly MenuController _menuController;

    public Action OnFinished { get; set; }

    public IntroTaskCmd(MenuController menuController)
    {
        _menuController = menuController;
    }

    public void Execute()
    {
        _menuController.introTaskObj.gameObject.SetActive(true);
        _menuController.introTaskObj.OnClickNext += OnClickNext;
    }

    private void OnClickNext()
    {
        _menuController.introTaskObj.OnClickNext -= OnClickNext;
        _menuController.introTaskObj.gameObject.SetActive(false);
        OnFinished?.Invoke();
    }
}
