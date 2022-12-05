using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDisplacer : MonoBehaviour
{
    public List<GameObject> roads;
    private float roadLength = 200f;

    // Start is called before the first frame update
    void Start()
    {
        if (roads.Count > 0 && roads != null)
        {
            SortRoads();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SortRoads()
    {
        //using insertion sort as list is practically sorted -> insertion sort runtime is O(n)
        //this is a standard algorithm taken from: https://www.tutorialspoint.com/insertion-sort-in-chash
        for (int i = 1; i < roads.Count; i++)
        {
            GameObject val = roads[i];
            int flag = 0;
            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (val.transform.position.z < roads[j].transform.position.z)
                {
                    roads[j + 1] = roads[j];
                    j--;
                    roads[j + 1] = val;
                }
                else flag = 1;
            }
        }
    }
    public void DisplaceRoad()
    {
        GameObject firstRoad = roads[0];
        //get first road, remove it, then transform and add back to road list
        roads.Remove(firstRoad);
        firstRoad.transform.position = new Vector3(0, 0, getNewZ());
        roads.Add(firstRoad);
    }

    public float getNewZ()
    {
        return roads[roads.Count - 1].transform.position.z + roadLength;
    }
}