using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogContainer : MonoBehaviour
{
    public GameObject dialogBoxUI;
    public TextMeshProUGUI dialogText;
    public bool isPlayerInRange;
    public string newDialogText;
    dialogManager instance = dialogManager.instance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInRange)
        {
           if(dialogManager.instance.isUIBoxShowingRightNow() == true)
            {
                dialogManager.instance.hideUI();
            }

            else if(dialogManager.instance.isUIBoxShowingRightNow() == false)
            {
                dialogManager.instance.showUI();
                dialogManager.instance.editText(newDialogText);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogBoxUI.SetActive(false);
        }
    }
}
