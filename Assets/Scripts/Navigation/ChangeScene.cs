using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue storedPlayerPosition;
    public GameObject fadeInTransition;
    public GameObject fadeOutTransition;
    public float fadeWait;

    void Awake()
    {
        if(fadeInTransition != null)
        {
            GameObject panel = Instantiate(fadeInTransition, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
{

        if(collision.CompareTag("Player") && !collision.isTrigger)
        {
            storedPlayerPosition.initValue = playerPosition;
            StartCoroutine(FadeCoroutine());
            
        }

}

    public IEnumerator FadeCoroutine()
    {
        if (fadeOutTransition != null)
        {
            Instantiate(fadeOutTransition, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeWait);
        AsyncOperation asyncOp = SceneManager.LoadSceneAsync(sceneToLoad);
        while(!asyncOp.isDone)
        {
            yield return null;
        }

    }

}
