using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

   public void StartGameButton(){
        SceneManager.LoadScene(1);
   }

   public void AboutUsButton() {
        SceneManager.LoadScene(2);
   }

    public void ReturnToMenu() {
        SceneManager.LoadScene(0);
    }

    public void ExitGameButton(){
        Application.Quit();
   }
}
