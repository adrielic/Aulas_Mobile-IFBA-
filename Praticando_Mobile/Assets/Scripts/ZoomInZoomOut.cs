using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ZoomInZoomOut : MonoBehaviour
{
    private Camera mainCamera;
    private float prevTouchPosDiff, curTouchPosDiff, zoomMod;
    private Vector2 firstTouchPrevPos, secondTouchPrevPos;
    [SerializeField] private float zoomModSpeed = 0.005f;
    [SerializeField] private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);
            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;
            prevTouchPosDiff = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
            curTouchPosDiff = (firstTouch.position - secondTouch.position).magnitude;

            zoomMod = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModSpeed;

            if (prevTouchPosDiff > curTouchPosDiff)
                mainCamera.orthographicSize += zoomMod;
            if (prevTouchPosDiff < curTouchPosDiff)
                mainCamera.orthographicSize -= zoomMod;
        }

        mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, 2f, 10f);
        text.text = "Camera size: " + mainCamera.orthographicSize;
    }
}
