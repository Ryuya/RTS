using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        mousePosition = Input.mousePosition;
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo = new RaycastHit();
        Physics.Raycast(ray, out hitInfo,100);
        //左
        if (Screen.width * 0.1 > mousePosition.x)
        {
            this.transform.position = new Vector3(this.transform.position.x + 1, transform.position.y,transform.position.z - 1);
        }
        //右
        if (Screen.width * 0.9 < mousePosition.x)
        {
            this.transform.position = new Vector3(this.transform.position.x - 1, transform.position.y,transform.position.z + 1);
        }
        //下
        if (Screen.height * 0.1 > mousePosition.y)
        {
            this.transform.position = new Vector3(this.transform.position.x + 1, transform.position.y,transform.position.z + 1);
        }
        //上
        if (Screen.height * 0.9 < mousePosition.y)
        {
            this.transform.position = new Vector3(this.transform.position.x - 1, transform.position.y,transform.position.z - 1);
        }
    }
}
