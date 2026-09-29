using Unity.VisualScripting;
using UnityEngine;

public class InteractiveTrigger : MonoBehaviour
{
    [SerializeField] private Animator activador1, activador2, activador3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(CompareTag("activador1"))
        {
            activador1.Play("Puerta1");
        }
       if(CompareTag("activador2"))
        {
            activador2.Play("Puerta2");
        }
        if (CompareTag("activador3"))
        {
            activador3.Play("Puerta3");
        }
    }
}
