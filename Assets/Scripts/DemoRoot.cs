using HoweFramework;
using UnityEngine;

public class DemoRoot : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        var application = CatLib.Application.New();

        application.Bootstrap(new HCoreBoostrap(), new DemoBoostrap());
        application.Init();
    }
}