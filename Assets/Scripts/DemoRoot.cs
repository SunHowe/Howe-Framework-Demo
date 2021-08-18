using System;
using HoweFramework;
using HoweFramework.Asset;
using HoweFramework.Procedure;
using HoweFramework.Procedure.Extensions;
using Launch;
using UnityEngine;
using Random = System.Random;

public class DemoRoot : MonoBehaviour
{
    private Random _random = new Random();
    
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

    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 500, 300), "Generate"))
            AssetService.That.InstantiateSync("cube").transform.position = new Vector3(_random.Next(-5, 5),0,0);
    }
}