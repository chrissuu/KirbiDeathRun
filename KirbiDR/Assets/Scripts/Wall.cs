using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Obstacle", menuName = "Obstacle/Wall")]

public class Wall : Obstacle
{
    public override void Effect()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
