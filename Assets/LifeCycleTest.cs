using UnityEngine;

public class LifeCycleTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Main()
    {
        Debug.Log("Main");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void OnWillRenderObject()
    {
        Debug.Log("OnWillRenderObject");
    }

    private void OnPreCull()
    {
        Debug.Log("OnPreCull");
    }

    private void OnBecameVisible()
    {
        Debug.Log("OnBecameVisible");
    }

    private void OnBecameInvisible()
    {
        Debug.Log("OnBecameInvisible");
    }

    private void OnPreRender()
    {
        Debug.Log("OnPreRender");
    }

    private void OnRenderObject()
    {
        Debug.Log("OnRenderObject");
    }

    private void OnPostRender()
    {
        Debug.Log("OnPostRender");
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("OnRenderImage");
    }

    private void OnDrawGizmos()
    {
        Debug.Log("OnDrawGizmos");
    }

    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    private void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause: " + pause);
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    public void Init()
    {
        Debug.Log("Init");
    }
}
