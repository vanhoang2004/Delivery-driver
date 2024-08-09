using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
   public void OnHomeButtonClick()
    {
        SceneManager.LoadScene("HomePage");
    }

    public void OnLevel1Click()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnLevel2Click()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Clicked");
    }
}
