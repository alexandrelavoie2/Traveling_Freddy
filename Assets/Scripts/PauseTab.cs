using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTab : MonoBehaviour
{
   [SerializeField] GameObject pauseMenu;
  
   public void Pause_Game()
   {
       pauseMenu.SetActive(true);
       //Stops time (straight up)
       Time.timeScale = 0f;
      
   }
  
   public void Resume_Game()
   {
       pauseMenu.SetActive(false);
       //Si j'avais fait 2f, le temps serait 2x plus vite.
       Time.timeScale = 1f;
   }


  
}

