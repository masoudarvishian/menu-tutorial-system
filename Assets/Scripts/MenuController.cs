using System.Collections;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public TutorialPanel introTaskObj, introSettingsObj, introTournmentObj, introPlayObj;

    private void Start()
    {
        StartCoroutine(DisplayTutorialCr());
    }

    IEnumerator DisplayTutorialCr()
    {
        yield return new WaitForSecondsRealtime(1f);

        var commandQueue = new CommandQueue();

        commandQueue.Enqueue(new IntroTaskCmd(this));
        commandQueue.Enqueue(new IntroPlayCmd(this));
        commandQueue.Enqueue(new IntroTournamentCmd(this));
        commandQueue.Enqueue(new IntroSettingsCmd(this));
    }
}
