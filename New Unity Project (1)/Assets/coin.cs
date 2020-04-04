
using UnityEngine;

public class coin : MonoBehaviour
{
   {
         void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))

        {


            Destroy(other.gameObject);


        }

    }
}
}
