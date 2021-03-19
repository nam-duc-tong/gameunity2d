using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public float planeSpeed;
    private Rigidbody2D myBody;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject bullet;
    private bool canShoot = true; 
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlaneMovement(); 
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           
            if (canShoot)
            {
                StartCoroutine(Shoot());
            }
            //transform.positon: vi tri ban vien dan
            //Quaternion.indentity: ko cho vien dan xoay
        }

    }
    void PlaneMovement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;//chieu ngang
        float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;//chieu doc
        myBody.velocity = new Vector2(xAxis, yAxis);

    }
    IEnumerator Shoot()
    {
        canShoot = false;
        Vector3 temp = transform.position;
        temp.y += 0.5f;
        Instantiate(bullet, temp, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
       
        canShoot = true;
    }
}
