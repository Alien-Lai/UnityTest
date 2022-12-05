using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    class RoleEntity : MonoBehaviour
    {
        public void Ctor()
        {
            // 初始化...
        }

        public void Move(Vector3 dir)
        {
            float moveSpeed = 0.005f;
            transform.position += dir * moveSpeed;
        }
    }
}