using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// cuando creas un script fuera y quiere jalar a la carpeta se dispone de esta forma : ** public cladd NewBehaviourScript : MonoBehaviour**
// y el problema se da que debe tener el nombre de archivo asi que solo debes cambiarlo y moverlo: ** public class GotitaMove : MonoBehaviour**
public class GotitaMove : MonoBehaviour
{
    [SerializeField]
    // Start is called before the first frame update
    public float speed = 15f;
    //public float rotationSpeed = 3f;
    //float velX = 0f;
    public Rigidbody2D rb;
    //public SpriteRenderer renderedSprite;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        Vector3 dir = Vector3.zero;
        dir.x = (Mathf.Abs(Input.acceleration.y) > 0.1) ? -Input.acceleration.y : 0;
        dir.y = (Mathf.Abs(Input.acceleration.x) > 0.1) ? Input.acceleration.x : 0;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);
        //rb.MovePosition(dir * speed );
        //velX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        //rb.MovePosition(rb.position + forward * Time.fixedDeltaTime);
        // para moverse
        //rb = gameObject.GetComponent<Rigidbody2D>();
        //rb.AddForce(Vector2.up * speed * Time.fixedDeltaTime * velX);
        
        //rb.AddForce(0, speed, ForceMode.Force);
        //transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        // para rotacion
        //transform.Rotate(Vector3.forward * velX * rotationSpeed * Time.fixedDeltaTime);
    }
}
