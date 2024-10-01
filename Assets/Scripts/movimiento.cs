using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField]  float velocidad;
    [SerializeField] float fuerzaSalto;
    private Rigidbody2D cuerpoRigido; 
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool tocaPiso = true;
  
     // Start is called before the first frame update
    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var ejeX = Input.GetAxis("Horizontal");
        if (ejeX !=0){
            animator.SetBool("corriendo",true);

            if(ejeX < 0){
                spriteRenderer.flipX = true;
            }
            else{
                spriteRenderer.flipX = false;
            }
        }
        else
        {
            animator.SetBool("corriendo",false);
        }
        
        var vectorMovimiento = new Vector2(ejeX,0);
        transform.Translate(vectorMovimiento * Time.deltaTime * velocidad);

        //paso 3
        if (Input.GetKeyDown(KeyCode.Space) && tocaPiso)
        {
            var salto =  new Vector2(0,fuerzaSalto);
            cuerpoRigido.AddForce (salto,ForceMode2D.Impulse);
            tocaPiso = false;
            
            
        }    }
        private void OnCollisionEnter2D(Collision2D collision){
            if (collision.gameObject.tag == "Ground"){
                tocaPiso = true;
            }
        }
}
