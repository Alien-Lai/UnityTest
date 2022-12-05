using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class CameraEntity : MonoBehaviour
    {
        public void Ctor()
        {
            // ...
            // transform.position = new Vector3(0,0,0);
        }

        public void Move(Vector3 dir)
        {
            float speed = 0.005f;
            transform.position += speed * dir;
        }
    }
}