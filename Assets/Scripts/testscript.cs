// ping-pong animate background color
using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour
{
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {



        //float time = Mathf.PingPong(Time.time, duration) / duration;
        //cam.backgroundColor = Color.Lerp(color1, color2, time); //cam.backgroundColor is calling the camera that it is connected to's color background, if theres not already a background image obscuring it. yknow?
    }
}