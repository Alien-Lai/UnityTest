using UnityEngine;

namespace MyProject
{
    class ClientApp : MonoBehaviour
    {
        InputEntity inputEntity;
        RoleEntity roleEntity;
        CameraEntity cameraEntity;

        void Awake()
        {
            Debug.Log("程序启动");

            inputEntity = new InputEntity();

            GameObject go = GameObject.Find("RoleEntity");
            roleEntity = go.GetComponent<RoleEntity>();

            go = GameObject.Find("CameraEntity");
            cameraEntity = go.GetComponent<CameraEntity>();
        }

        void Start()
        {
            roleEntity.Ctor();
            cameraEntity.Ctor();
        }

        void FixUpdate()
        {

        }

        void Update()
        {
            inputEntity.Tick();
            roleEntity.Move(inputEntity.roleMoveDir);
            cameraEntity.Move(inputEntity.cameraMoveDir);
        }

        void LateUpdate()
        {

        }

        void OnApplicationQuit()
        {

        }

        void OnDestroy()
        {

        }
    }
}