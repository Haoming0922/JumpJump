using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 positionOffset;
    public Vector3 lookAtOffset;
    public Jump jump;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = player.position + positionOffset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);

        //Vector3 direction = player.position + lookAtOffset - transform.position;
        //Quaternion toRotation = Quaternion.FromToRotation(transform.rotation.eulerAngles, direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 2 * Time.deltaTime);

        Vector3 targetLookAt = Vector3.Lerp(transform.position + transform.forward, player.position + lookAtOffset, 0.5f * Time.deltaTime);
        transform.LookAt(targetLookAt);
    }
}
