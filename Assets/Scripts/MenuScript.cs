using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update

    public void startButton() {
        SceneManager.LoadScene(1);
        ScoreScript.scoreValue = 0;
    }
    
    
    public void quitButton() {
        Application.Quit();
    }

}
