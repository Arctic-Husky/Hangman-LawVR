using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Spawner spawner;
    [SerializeField]
    public static int enemySpeed = 5;
    // Update is called once per frame

    void Start(){
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        //GameManager.Instance.OnVidasChanged += Instance_OnVidasChanged;
    }

    /*private void Instance_OnVidasChanged(int vidas)
    {
        throw new System.NotImplementedException();
    }*/

    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.left * enemySpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
    if (col.gameObject.tag == "Player"){
            //ScoreVidas.vidas--;
            GameManager.Instance.PerderVida();
            spawner.SpawnInimigo();
            Destroy (this.gameObject);
            //reduzir a vida do Player
        }
    }
}
