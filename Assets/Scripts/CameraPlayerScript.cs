using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    Vector3 distance_between;

    // Start is called before the first frame update
    void Start()
    {
        distance_between = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = player.transform.position + distance_between;
    

    }
}
