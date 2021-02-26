using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSystem : MonoBehaviour
{
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();
            float maxDistance = 100f;
            bool isHit = Physics.Raycast(ray,out hitInfo , maxDistance);
            if (isHit)
            {
                player.RUN(hitInfo.point);
            }
        }
    }
}
