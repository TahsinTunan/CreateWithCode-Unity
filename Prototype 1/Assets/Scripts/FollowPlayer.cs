using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Quaternion angle;
    private Vector3 defaultOffset = new Vector3(0, 8, -9), swappedOffset = new Vector3(0, 10, 15);
    private Quaternion defaultAngle = Quaternion.Euler(24, 0, 0), swappedAngle = Quaternion.Euler(27, 180, 0);
    private bool cameraSwapped = false;


    // Start is called before the first frame update
    void Start()
    {
        offset = defaultOffset;
        angle = defaultAngle;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = angle;

        if (Input.GetKeyUp("r"))
        {
            swapCamera();
            
        }
    }

    private void swapCamera()
    {
        if (!cameraSwapped)
        {
            offset = swappedOffset;
            angle = swappedAngle;
        }
        else
        {
            offset = defaultOffset;
            angle = defaultAngle;
        }

        cameraSwapped = !cameraSwapped;
    }
}
