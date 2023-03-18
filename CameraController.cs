using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3P : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position - transform.position;

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}