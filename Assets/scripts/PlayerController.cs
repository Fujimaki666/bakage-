using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // �O�i�̑��x
    private bool isMoving = true; // �O�i�����ǂ���
    private Vector3 moveDirection = Vector3.forward; // �ړ�����

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }

    // �v���C���[���~������
    public void Stop()
    {
        isMoving = false;
        //Debug.Log("Player stopped moving.");
    }

    // �������Ɉړ����J�n
    public void MoveLeft()
    {
        isMoving = true;
        moveDirection = Vector3.left;
        //Debug.Log("Player moving left.");
    }

    // �E�����Ɉړ����J�n
    public void MoveRight()
    {
        isMoving = true;
        moveDirection = Vector3.right;
        //Debug.Log("Player moving right.");
    }
}
