using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentDontDestroy : MonoBehaviour
{
        void Start()
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Canvas");

            if (objs.Length > 1)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(this.gameObject);
        }
}