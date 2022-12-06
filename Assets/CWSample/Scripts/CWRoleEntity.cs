using UnityEngine;

namespace CWSample {

    public class CWRoleEntity : MonoBehaviour {

        public void Move(Vector3 dir, float speed, float dt) {
            transform.position += dir * speed * dt;
        }

    }

}