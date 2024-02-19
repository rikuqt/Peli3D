using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOut : MonoBehaviour
{
    Fade fadeInOut;
    void Start()
    {
        fadeInOut = FindObjectOfType<Fade>();

        fadeInOut.FadeOut();
    }
}
