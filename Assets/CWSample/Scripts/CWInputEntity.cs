using UnityEngine;

namespace CWSample {

    public class CWInputEntity {

        public Vector3 moveDir;

        public CWInputEntity() { }

        public void Tick() {

            moveDir = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) {
                moveDir.z = 1;
            } else if (Input.GetKey(KeyCode.S)) {
                moveDir.z = -1;
            }

            if (Input.GetKey(KeyCode.A)) {
                moveDir.x = -1;
            } else if (Input.GetKey(KeyCode.D)) {
                moveDir.x = 1;
            }

        }

    }
}