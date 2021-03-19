using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    private Rigidbody2D myBody;
    [SerializeField]
    private GameObject bullet;
    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        StartCoroutine(EnemyShoot());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -enemySpeed);
    }
    IEnumerator EnemyShoot()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        Vector3 temp = transform.position;
        temp.y -= 0.5f;
        Instantiate(bullet, temp, Quaternion.identity);
        StartCoroutine(EnemyShoot());
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            Destroy(target.gameObject);
            SampleSceneController.instance.PlaneDiedShowPanel();
        }
        if(target.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
