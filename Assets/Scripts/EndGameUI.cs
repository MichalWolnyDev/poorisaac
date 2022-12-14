using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameUI : MonoBehaviour
{
    public static EndGameUI instance;

    [SerializeField]
    private Text scoreValueText;

   public static int score = 0;

    private void Awake() {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.SetActive(false);
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }

    public void ActivateGameObject(){
        this.gameObject.SetActive(true);
        score = ScoreManager.instance.score;
        scoreValueText.text = score.ToString();
    }
}
