using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public Vector3 MoveVector3 = Vector3.zero;
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // deal();
    }

    private void FixedUpdate()
    {
        MoveSpeed = GetComponent<Stats>().movementSpeed;
        Move();
    }

    private void Move()
    {
        transform.Translate(MoveVector3 * MoveSpeed * Time.fixedDeltaTime * Time.timeScale);
    }

    private void deal()
    {
        GetComponent<Stats>().hp -= (float)1.0;
    }


}
