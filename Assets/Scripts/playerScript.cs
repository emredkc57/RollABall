using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerScript : MonoBehaviour
{

    float horizontalPos, verticalPos;
    Rigidbody rigidbody;

    [SerializeField]
    private int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerControl();
        
    }


    void PlayerControl()
    {
        horizontalPos = Input.GetAxisRaw("Horizontal");
        verticalPos = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontalPos, 0, verticalPos);
        rigidbody.AddForce(vec * speed);

        if(Input.GetKeyUp(KeyCode.Space))
        {

            rigidbody.AddForce(new Vector3(0, 4*speed, 0));

        }

    }


}
