using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    public float speed;

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        
        // Comprobar si el animator está ejecutando una animación específica
        if (stateInfo.IsName("Walk_Forward"))
        {
            Vector3 positio = transform.position;
            positio.x += Time.deltaTime * speed;

            transform.position = positio;
            Debug.Log("La animación 'NombreDeTuAnimacion' está en ejecución.");
        }

        if (stateInfo.IsName("Walk_Backward"))
        {

            Vector3 positio = transform.position;
            positio.x += Time.deltaTime * -speed;

            transform.position = positio;
            Debug.Log("La animación 'NombreDeTuAnimacion' está en ejecución.");
        }
    }
}
