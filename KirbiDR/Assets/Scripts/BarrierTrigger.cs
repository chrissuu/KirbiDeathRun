using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    RoadDisplacer roadDisplacer;
    // Start is called before the first frame update
    void Start()
    {
        roadDisplacer = GetComponent<RoadDisplacer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BarrierTriggerEntered()
    {
        roadDisplacer.DisplaceRoad();
    }
}