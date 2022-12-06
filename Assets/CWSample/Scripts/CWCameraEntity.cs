using UnityEngine;

namespace CWSample {

    public class CWCameraEntity : MonoBehaviour {

        public void Follow(Vector3 targetPos, Vector3 offset) {
            transform.position = targetPos + offset;
        }

    }

}