using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AloitusRuutu : MonoBehaviour
{
   public void PlayGame(){
    SceneManager.LoadSceneAsync(1);
   }

public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
