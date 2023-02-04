using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFunction : MonoBehaviour
{
    // Exiting the game
    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit()
        #endif
        
    }
}