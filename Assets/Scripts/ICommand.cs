using System;

public interface ICommand
{
    Action OnFinished { get; set; }

    void Execute();
}
