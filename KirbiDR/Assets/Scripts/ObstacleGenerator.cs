using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    enum WallSpan
    {
        SingleTrack,
        DoubleTrack
    }

    enum Track
    {
        Left,
        Middle,
        Right,
    }

    public GameObject obstacleRemover;
    public GameObject wall;

    public float minTime;
    public float maxTime;
    
    private float _timer = 0;
    private float _waitTime = 0;

    public GameObject player;
    private Transform _playerTransform;
    public float distanceFromPlayer;


    void Start()
    {
        _playerTransform = player.transform;
        resetTime();
    }

    void Update()
    {
        if (_timer >= _waitTime)
        {
            generateObstacle();
            resetTime();
        }
        else { 
            _timer += Time.deltaTime;
        }
    }

    private void resetTime()
    {
        _timer = 0;
        _waitTime = Random.Range(minTime, maxTime);
    }


    private void generateObstacle() {
        int trackWidth = 5;

        GameObject newObstacle;
        float posX = _playerTransform.position.x;
        int wallSpan = -1;


        if (Random.Range(0, 5) < 1)
        {
            newObstacle = Instantiate(obstacleRemover);
        }
        else {
            newObstacle = Instantiate(wall);
            wallSpan = Random.Range(0, 2);
        }

        if (wallSpan == (int) WallSpan.SingleTrack || wallSpan == -1)
        {
            int trackLocation = Random.Range(0, 3);
            posX = getTrackPosX(trackLocation);

        } 
        else if (wallSpan == (int) WallSpan.DoubleTrack) {
            newObstacle.transform.localScale = new Vector3(trackWidth * 2, wall.transform.localScale.y, wall.transform.localScale.z);
             posX = generateLongWallX();
        }

        newObstacle.transform.position = new Vector3(posX, 0, _playerTransform.position.z + distanceFromPlayer);

        ObstacleManager.Instance.addObstacle(newObstacle);
    }

    private float generateLongWallX() {
        int openTrack = Random.Range(1, 3);
        int trackWidth = 5;

        return getTrackPosX(1) + Mathf.Pow(-1, openTrack) * .5f * trackWidth;
    }

    public static float getTrackPosX(int trackLocation)
    {
        if (trackLocation == (int) Track.Left)
        {
            return -5.0f;
        } 
        else if (trackLocation == (int) Track.Right)
        {
            return 5.0f;
        } 
        else {
            return 0.0f;
        }
    
    }
 

}

