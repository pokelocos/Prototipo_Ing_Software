using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieceHandler : MonoBehaviour
{
    public GameObject piece;
    public Slider sliderZoom;
    public float scale = 200f;

    public float speed = 5;
    [Range(0,1)] public float freno = 0.1f;

    private float force;
    private Vector3 last = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up,force * speed * Time.deltaTime);

        if (force > 0)
        {
            force -= force * freno * Time.deltaTime;
        }
    }
    private void OnMouseDown()
    {
        last = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        var d = last - Input.mousePosition;
        force = d.x;
        last = Input.mousePosition;
    }

    public void Zoom()
    {
        scale = sliderZoom.value;
        piece.transform.localScale = new Vector3(scale,scale,scale);
    }
    
}
