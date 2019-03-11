using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class interactObject : MonoBehaviour
{
    public GameObject dialogBoxUI;
    public TextMeshProUGUI dialogText;
    public string dialogString;
    public bool isPlayerInRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isPlayerInRange)
        {
            if(dialogBoxUI.activeInHierarchy)
            {
                dialogBoxUI.SetActive(false);
            }
            else if(!dialogBoxUI.activeInHierarchy)
            {
                dialogBoxUI.SetActive(true);
                dialogText.text = dialogString;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogBoxUI.SetActive(false);
        }
    }
}
