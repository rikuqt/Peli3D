using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
    Fade fadeInOut;

    void Start()
    {
        fadeInOut = FindObjectOfType<Fade>();
    }
    
    // Loppu scene
    public IEnumerator ChangeSceneLoppu()
    {
        fadeInOut.FadeIn();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("loppuScene");
        
        // Kursorin takaisin otto (FirstPersonController lockkaus pois)
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

        // Kuolema scene
      public IEnumerator ChangeSceneKuolema()
    {
        fadeInOut.FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("kuolemaScene");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }



    private void OnTriggerEnter(Collider other)
    {
        // Check if collided with the player
        if (other.CompareTag("Player"))
        {
            // Check if collided with water
            if (gameObject.CompareTag("vesi"))
            {
                Debug.Log("Collided with water");
                StartCoroutine(ChangeSceneKuolema());
            }
            // Check if collided with house
            else if (gameObject.CompareTag("talo"))
            {
                Debug.Log("Collided with house");
                StartCoroutine(ChangeSceneLoppu());
            }
        }
    }
}





