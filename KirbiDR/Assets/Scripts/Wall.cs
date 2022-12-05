using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Obstacle", menuName = "Obstacle/Wall")]

public class Wall : Obstacle
{
    public override void Effect()
    {
        PauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }


}
