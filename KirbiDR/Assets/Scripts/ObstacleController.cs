using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float deleteOffset;
    public Obstacle obstacle;

    private Transform _cameraTransform;

    void Start()
    {
        setCameraTransform();
    }

    void Update()
    {
        if (transform.position.z < _cameraTransform.position.z - deleteOffset) {
            ObstacleManager.Instance.removeObstacale(this.gameObject);
        }

    }

    private void setCameraTransform() {
        GameObject camera = GameObject.Find("Main Camera");
        _cameraTransform = camera.transform;
    }

    public void OnTriggerEnter(Collider other) { 
    
        if (other.gameObject.name == "Kirby") {
            Destroy(gameObject);
            obstacle.Effect();

        }
    }

}
