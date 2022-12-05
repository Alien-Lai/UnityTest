using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class InputEntity
    {
        public Vector3 roleMoveDir;
        public Vector3 cameraMoveDir;

        public float cameraEntity;

        public InputEntity()
        {
            // 构造函数
        }

        public void Tick()
        {
            // role
            Vector3 dir = Vector3.zero;
            if(Input.GetKey(KeyCode.W)){
                dir.z = 1;
            }else if(Input.GetKey(KeyCode.S)){
                dir.z = -1;
            }

            if(Input.GetKey(KeyCode.A)){
                dir.x = -1;
            }else if(Input.GetKey(KeyCode.D)){
                dir.x = 1;
            }

            roleMoveDir = dir;

            // camera
            Vector3 cameraDir = Vector3.zero;
            cameraDir.x = dir.x;
            cameraDir.z = dir.z;
            cameraMoveDir = cameraDir;
        }
    }
}