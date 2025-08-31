using UnityEngine;

public class BananaScript : MonoBehaviour
{
    public string myname = "none";
    public float speed = 1.0f;
    public float turnspeed = 90.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("my name is" + myname);
        //this gets called once when the game  begins
        Debug.Log("hello");

    }

    // Update is called once per frame
    void Update()
    {
        //this  gets called every  frame of the game
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed);
        //speed represents degrees in  this case
        //with both lines uncomented the  object  will go  in a circle as it  moves  foward then turns
        
    }
}
