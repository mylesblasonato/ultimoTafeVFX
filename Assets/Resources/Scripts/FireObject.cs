using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObject : MonoBehaviour
{
    [SerializeField] string attackInput = "Fire01";
    [SerializeField] GameObject barrel, bullet;
    Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, mainCam.transform.eulerAngles.y, transform.eulerAngles.z);

        if(Input.GetButtonDown(attackInput))
        {
            var newBullet = Instantiate(bullet, barrel.transform);      
            newBullet.transform.eulerAngles = Vector3.zero;
            newBullet.transform.parent = null;
        }
    }
}
