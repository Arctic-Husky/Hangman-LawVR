using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Monstro",menuName ="Novo Monstro")]
public class Enemy : ScriptableObject
{
<<<<<<< Updated upstream
    public Spawner spawner;
    [SerializeField]
    public static int enemySpeed = 5;
    // Update is called once per frame

    void Start(){
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.left * enemySpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
    if (col.gameObject.tag == "Player"){
            ScoreVidas.vidas--;
            spawner.SpawnInimigo();
            Destroy (this.gameObject);
            //reduzir a vida do Player
        }
    }
=======
    public string nomeDoMonstro;
    public float dificuldade;
    public int sangue;
    public Sprite spriteMonstro;
>>>>>>> Stashed changes
}
