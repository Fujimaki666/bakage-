using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // 前進の速度
    private bool isMoving = true; // 前進中かどうか
    private Vector3 moveDirection = Vector3.forward; // 移動方向

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }

    // プレイヤーを停止させる
    public void Stop()
    {
        isMoving = false;
        //Debug.Log("Player stopped moving.");
    }

    // 左方向に移動を開始
    public void MoveLeft()
    {
        isMoving = true;
        moveDirection = Vector3.left;
        //Debug.Log("Player moving left.");
    }

    // 右方向に移動を開始
    public void MoveRight()
    {
        isMoving = true;
        moveDirection = Vector3.right;
        //Debug.Log("Player moving right.");
    }
}
