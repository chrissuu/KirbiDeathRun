using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    private static ObstacleManager _instance;
    public static ObstacleManager Instance { get { return _instance; } }

    private List<Object> obstacleClones = new List<Object>();

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public void addObstacle(Object obstacle) {
        obstacleClones.Add(obstacle);
    }

    public void removeObstacale(Object obj)
    {
        Destroy(obj);
        obstacleClones.Remove(obj);
    }

    public void removeAllObstacles()
    {
        for (int i = 0; i < obstacleClones.Count; i++) {
            Destroy(obstacleClones[i]);
        }
        obstacleClones.Clear();
    }



}
