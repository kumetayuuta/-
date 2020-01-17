using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject target;

    [SerializeField]
    float offset = 2f;

    [SerializeField]
    float cameraMaxDistance = 10f;

    float cameraY;
    float cameraZ;


    // Start is called before the first frame update
    void Start()
    {
        cameraY = transform.position.y;
        cameraZ = transform.position.z;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float distance = Mathf.Abs(Vector3.Distance(transform.position, target.transform.position));

        if (distance < this.offset || distance > cameraMaxDistance)
        {
            Vector3 targetPosition = target.transform.position;
            targetPosition.x += (this.offset * target.transform.localScale.x);
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);
            transform.position = new Vector3(
                transform.position.x,
                this.cameraY,
                this.cameraZ
                );
        }
    }
}
