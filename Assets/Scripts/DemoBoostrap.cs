using CatLib;
using HoweFramework.Fsm;
using HoweFramework.Procedure;

public class DemoBoostrap : IBootstrap
{
    public void Bootstrap()
    {
        App.Register(new FsmServiceProvider());
        App.Register(new ProcedureServiceProvider());
    }
}