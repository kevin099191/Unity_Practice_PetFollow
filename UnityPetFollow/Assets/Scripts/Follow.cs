
using UnityEngine;

public class Follow : MonoBehaviour
{
    [Header("跟隨速度"), Range(1, 10)]
    public float speed;

    private Transform Op;

    private void track()
    {

        Vector3 posOp = Op.position;
        Vector3 posFg = transform.position;

        transform.position = Vector3.Lerp(posOp, posFg, 0.1f * Time.deltaTime * speed);
        transform.LookAt(posOp);

    }

    private void Start()
    {
        Op = GameObject.Find("野蠻人").transform;
    }


    private void LateUpdate()
    {
        track();
    }
}

