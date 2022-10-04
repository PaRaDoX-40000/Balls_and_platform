using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameManager : MonoBehaviour
{   

    public void StartGame()
    {
        GlobalEventSystem.SpawnEntity?.Invoke();
        GlobalEventSystem.StartGame?.Invoke();
    }

   
}
