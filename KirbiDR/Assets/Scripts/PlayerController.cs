using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public float speed = 4.0f;
    public BarrierTrigger rd;
    private static float[] arr = { -5.0f, 0.0f, 5.0f };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        if (gameObject.transform.position.x == arr[0])
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                StartCoroutine("ShiftRight");
            }

        }
        else if (gameObject.transform.position.x == arr[2])
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                StartCoroutine("ShiftLeft");
            }
        }
        else if (gameObject.transform.position.x == arr[1])
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                StartCoroutine("ShiftRight");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                StartCoroutine("ShiftLeft");
            }

        }




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Road")
        {
            rd.BarrierTriggerEntered();
        }
    }

    IEnumerator ShiftRight()
    {
        for (int x = 0; x < 10; x++)
        {
            transform.Translate(0.5f, 0, 0);
            // Debug.Log("right");
            yield return new WaitForSeconds(0.05f);

        }
    }

    IEnumerator ShiftLeft()
    {
        for (int x = 0; x < 10; x++)
        {
            transform.Translate(-0.5f, 0, 0);
            // Debug.Log("right");
            yield return new WaitForSeconds(0.05f);

        }
    }

    public static float getKirbiPosX(int kirbiLocation)
    {
        if (arr[kirbiLocation] == -5.0f)
        {
            return -5.0f;
        }
        else if (arr[kirbiLocation] == 5.0f)
        {
            return 5.0f;
        }
        else
        {
            return 0.0f;
        }

    }

}
