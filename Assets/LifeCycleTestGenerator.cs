using UnityEngine;

public class LifeCycleTestGenerator : MonoBehaviour
{
    [SerializeField] LifeCycleTest testPre;

    private void Start()
    {
        var test = Instantiate(testPre);
        test.Init();
    }

}
