using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Obstacle", menuName = "Obstacle/ObstacleDestroyer")]

public class ObstacleDestroyer : Obstacle
{
    public override void Effect() {
        ObstacleManager.Instance.removeAllObstacles();
    }

}
