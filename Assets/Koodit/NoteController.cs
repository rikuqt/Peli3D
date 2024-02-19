using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;
using UnityEngine.SceneManagement;

public class NoteController : MonoBehaviour
{
    [Header("Input")]
    [Space(10)]
    [SerializeField] private FirstPersonController player;

    [Header("UI Text")]
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private TMP_Text noteTextAreaUI;

    [Space(10)]
    [SerializeField] [TextArea] private string noteText;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;
    [SerializeField] public GameObject kirje4;
    [SerializeField] private KeyCode closeKey = KeyCode.Escape;

    public void ShowNote()
    {
        noteTextAreaUI.text = noteText;
        noteCanvas.SetActive(true);
        openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }

    public void DisableNote()
    {
        noteCanvas.SetActive(false);
        DisablePlayer(false);
        isOpen = false;
    }

    void DisablePlayer(bool disable)
    {
        player.enabled = !disable;
    }

    public void viimeinenKirjeKlikkaus(){
        //GetComponent<>
        if (kirje4)
        {
            SceneManager.LoadScene("loppuScene");
        }

    }

    private void Update()
    {
        if (isOpen)
        {
            if (Input.GetKeyDown(closeKey))
            {
                DisableNote();
            }
        }
    }
}
