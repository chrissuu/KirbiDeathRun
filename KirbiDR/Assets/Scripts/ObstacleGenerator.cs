using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    private static ObstacleGenerator _instance;

    public GameObject[] obstaclePrefabs;
    public GameObject wall;

    public float minTime;
    public float maxTime;
    

    private float _timer = 0;
    private float _waitTime = 0;

    public GameObject player;
    public float playerOffset;
    private Transform _playerTransform;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    void Start()
    {
        _playerTransform = player.transform;
        resetTime();
    }

    void Update()
    {
        if (_timer >= _waitTime)
        {
            generateWall();
            resetTime();
        }
        else 
        {
            _timer += Time.deltaTime;
        }
    }

    private void resetTime()
    {
        _timer = 0;
        _waitTime = Random.Range(minTime, maxTime);
    }



    private void generateWall() {
        // TEMP
        int trackWidth = 5;


        int wallSpan = Random.Range(1, 3);
        GameObject newWall = Instantiate(wall);

        if (wallSpan == 1)
        {
            int trackLocation = Random.Range(0, 3);
            newWall.transform.position = new Vector3(getTrackPosX(trackLocation), 1, _playerTransform.position.z + playerOffset);

        }
        else if (wallSpan == 2) {
            int openTrack = Random.Range(1, 3);

            newWall.transform.localScale = new Vector3(trackWidth * 2, wall.transform.localScale.y, wall.transform.localScale.z);
            //newWall.transform.position = new Vector3(getLongWallX(openTrack) , 1, _playerTransform.position.z + playerOffset);
        }
    }

    private float getLongWallX(int openTrack) {
        // TEMP
        int trackWidth = 5;

        return getTrackPosX(1) + Mathf.Pow(-1, openTrack) * .05f * trackWidth;



    }

    // HARD CODED... for now.
    private float getTrackPosX(int trackLocation)
    {
        if (trackLocation == 0)
        {
            return -5.0f;
        }
        else if (trackLocation == 1)
        {
            return 0.0f;
        }
        else
        {
            return 5.0f;
        }
    
    }
 

}

