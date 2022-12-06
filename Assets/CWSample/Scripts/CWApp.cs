using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CWSample {

    public class CWApp : MonoBehaviour {

        CWRoleEntity role;
        CWCameraEntity cam;
        CWInputEntity input;

        void Awake() {
            role = GameObject.Find("Role").GetComponent<CWRoleEntity>();
            cam = GameObject.Find("Main Camera").GetComponent<CWCameraEntity>();
            input = new CWInputEntity();
        }

        void Update() {

            float dt = Time.deltaTime;

            input.Tick();

            role.Move(input.moveDir, 5, dt);
            cam.Follow(role.transform.position, new Vector3(0, 5, -10));

        }

    }

}

