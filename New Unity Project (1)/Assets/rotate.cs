
using UnityEngine;

public class rotate : MonoBehaviour
{
   public float spinx;
   public float spinz;
   public float spiny;
   public float speed;

   private void Start()
   {
      transform.Rotate(spinx,spiny,spinz);
   }
}
