using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float deleteOffset;

    private Transform _cameraTransform;


    // Start is called before the first frame update
    void Start()
    {
        setCameraTransform();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < _cameraTransform.position.z - deleteOffset) {
            Destroy(this.gameObject);
        }

    }

    private void setCameraTransform() {
        GameObject camera = GameObject.Find("Main Camera");
        _cameraTransform = camera.transform;
    }

}
