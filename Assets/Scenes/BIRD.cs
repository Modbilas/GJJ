using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIRD : MonoBehaviour
{
    public float speed;
    public int Startpoint;
    public Transform[] points;

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[Startpoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            transform.localScale = new Vector2(0.6286f, 0.6286f);
            if(i == points.Length)
            {
                i = 0;
                transform.localScale = new Vector2(-0.6286f, 0.6286f);
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.position.y > transform.position.y)
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        other.transform.SetParent(null);
    } 
}
