using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public float speed;
    private Rigidbody2D playerRigidbody;
    private Vector3 change;
    private Animator anim;
    public VectorValue startPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.position = startPosition.initValue;

    }//end void start

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        updateAllAnimAndMove();

    }//end update

    void updateAllAnimAndMove()
    {

        if (change != Vector3.zero)
        {
            moveCharacter();
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("moving", true);
        }

        else
        {
            anim.SetBool("moving", false);
        }
    }

    void moveCharacter()
    {
        playerRigidbody.MovePosition(
            transform.position + change.normalized * speed * Time.deltaTime
        );
    }
    //end moveCharacter
}