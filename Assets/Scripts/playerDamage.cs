using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerDamage : MonoBehaviour
{
    [SerializeField] Text textvida;
    [SerializeField] Animator ded;
    private int vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        ded = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
      
    }
    private void OnCollisionEnter2D (Collision2D other){
        if(other.gameObject.CompareTag("spike")){
            vida--;
            textvida.text = $"vida :{vida}";
            Perder();
        }
    }
    public void Perder(){
          if (vida<=0){
            
        }
    }
}
