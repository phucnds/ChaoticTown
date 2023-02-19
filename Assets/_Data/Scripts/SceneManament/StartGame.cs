using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public LoadEventChannelSO onPlayButtonPress;
    public GameSceneSO[] locationsToLoad;
    public bool showLoadScreen;

    public void OnPlayButtonPress()
    {
        onPlayButtonPress.RaiseEvent(locationsToLoad, showLoadScreen);
    }
}

