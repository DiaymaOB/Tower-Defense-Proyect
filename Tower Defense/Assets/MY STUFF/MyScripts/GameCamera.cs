using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {

    [SerializeField] private float speed = 10f;
    [SerializeField] private float border = 10f;
    [SerializeField] private Vector2 limit;

    [SerializeField] private float scrollSpeed = 20f;
    [SerializeField] private float minY = 20f;
    [SerializeField] private float maxY = 120f;

	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (Input.mousePosition.y >= Screen.height - border)
        {
            if(pos.z <= -6)
                pos.z += speed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= border)
        {
            if (pos.z >= -29)
                pos.z -= speed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - border)
        {
            if (pos.x <= 6)
                pos.x += speed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= border)
        {
            if (pos.x >= -26)
                pos.x -= speed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollSpeed * 200 * Time.deltaTime;

        transform.position = pos;
    }
}
