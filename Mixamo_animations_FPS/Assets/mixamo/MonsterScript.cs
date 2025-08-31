using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the Animator component attached to the GameObject
        //what  we will use  to gain acces  to the various animations
        anim = GetComponent<Animator>();
        Debug.Log("MonsterScript started and Animator component found.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private  void  OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        //what is other? it is the object that entered the trigger collider
        //other is a  varable which represents the collider that entered the trigger
        if (other.CompareTag("Player"))
        {
            // Set the "Threatened" trigger in the Animator to play the threatened animation
            //this is  what  we  seted up in  the animator window, so  anim  is the  animator component
            //aka the animator controller/window attached to the game object
            anim.SetTrigger("Threatened");   
        }
    }
}
