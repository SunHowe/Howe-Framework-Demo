using HoweFramework;
using HoweFramework.Procedure;
using HoweFramework.Procedure.Extensions;
using Launch;
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

        ProcedureService.That.Launch<LaunchProcedure>(new ProcedureBase[] {new LaunchProcedure()});
    }
}