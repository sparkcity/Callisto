using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogManager : MonoBehaviour
{ 

    public static dialogManager instance;
    public GameObject dialogBoxUI;
    public TextMeshProUGUI dialogText;
    public bool isBoxShown;

    public static dialogManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<dialogManager>();

                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(instance.gameObject);
            }

            return instance;
        }
    }

    void Start()
    {

        if (instance == null)
        {
            //If I am the first instance, make me the Singleton
            instance = this;
            DontDestroyOnLoad(this);
            //dialogBoxUI = GetComponent<GameObject>();
        }
        else
        {
            //If a Singleton already exists and you find
            //another reference in scene, destroy it!
            if (this != instance)
                Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }

    public void hideUI()
    {
        dialogBoxUI.SetActive(false);
        isBoxShown = false;
    }

    public void showUI()
    {
        dialogBoxUI.SetActive(true);
        isBoxShown = true;
    }

    public void editText(string newText)
    {
        dialogText.text = newText;
    }

    public bool isUIBoxShowingRightNow()
    {
        if (dialogBoxUI.activeInHierarchy)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
