using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class coleccionables : MonoBehaviour
{
    [SerializeField] Text textItems;
    private int contador = 0;

    private void OnTriggerEnter2D(Collider2D collider){
    if (collider.gameObject.tag == "apple"){
        Destroy(collider.gameObject);
        contador++;
        textItems.text = $"Items X {contador}";
    }
   }
}
