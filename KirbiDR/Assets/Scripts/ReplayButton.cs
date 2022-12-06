using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Replay);
    }

    public void Replay()
    {
        gameObject.SetActive(false);
        ObstacleManager.Instance.removeAllObstacles();
        player.transform.position = new Vector3(0.0f, player.transform.position.y, player.transform.position.z);
        player.GetComponent<PlayerController>().StopAllCoroutines();
        Time.timeScale = 1;

        
        
    }

}
