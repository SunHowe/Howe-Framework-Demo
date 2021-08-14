using CatLib;
using HoweFramework.Fsm;

public class DemoBoostrap : IBootstrap
{
    public void Bootstrap()
    {
        App.Register(new FsmServiceProvider());
    }
}