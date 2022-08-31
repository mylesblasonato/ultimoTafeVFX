using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float distance = 1000f;
    Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bulletDirection = (mainCam.transform.position + mainCam.transform.forward * 1000) - transform.position;
        transform.Translate(bulletDirection * speed * Time.deltaTime);
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
