using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atv3MultipleTouch : MonoBehaviour
{
    public GameObject circle;
    public List<Atv3TouchLocation> touches = new List<Atv3TouchLocation>();

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Began)
            {
                Debug.Log("touch began");
                touches.Add(new Atv3TouchLocation(t.fingerId, createCircle(t)));
            }
            else if (t.phase == TouchPhase.Ended)
            {
                Debug.Log("touch ended");
                Atv3TouchLocation thisTouch = touches.Find(Atv3Script1 => Atv3Script1.touchId == t.fingerId);
                Destroy(thisTouch.circle);
                touches.RemoveAt(touches.IndexOf(thisTouch));
            }
            else if (t.phase == TouchPhase.Moved)
            {
                Debug.Log("touch is moving");
                Atv3TouchLocation thisTouch = touches.Find(Atv3Script1 => Atv3Script1.touchId == t.fingerId);
                thisTouch.circle.transform.position = getTouchPosition(t.position);
            }
            ++i;
        }
    }

    Vector2 getTouchPosition(Vector2 touchPosition)
    {
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, transform.position.z));
    }

    GameObject createCircle(Touch t)
    {
        GameObject c = Instantiate(circle) as GameObject;
        c.name = "Touch" + t.fingerId;
        c.transform.position = getTouchPosition(t.position);
        return c;
    }
}
