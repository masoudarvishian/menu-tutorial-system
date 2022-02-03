using System;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    public Action OnClickNext { get; set; }

    public void Next()
    {
        OnClickNext?.Invoke();
    }
}
