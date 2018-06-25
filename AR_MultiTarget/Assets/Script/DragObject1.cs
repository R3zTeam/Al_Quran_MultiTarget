using UnityEngine;
using System.Collections;

public class DragObject1 : MonoBehaviour
{

    Vector3 dist;
    float posX;
    float posY;
    float positionYabsolute = 0.3f;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

    }

    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - posX,
                     Input.mousePosition.y - posY, dist.z);

        //Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = new Vector3(worldPos.x,positionYabsolute,worldPos.z);
    }
}