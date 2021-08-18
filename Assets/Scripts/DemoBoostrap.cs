using CatLib;
using HoweFramework.Addressables;
using HoweFramework.Fsm;
using HoweFramework.Procedure;

public class DemoBoostrap : IBootstrap
{
    public void Bootstrap()
    {
        App.Register(new AddressablesAssetServiceProvider());
        App.Register(new FsmServiceProvider());
        App.Register(new ProcedureServiceProvider());
    }
}