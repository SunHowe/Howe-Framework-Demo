using HoweFramework.Fsm;
using HoweFramework.Procedure;
using UnityEngine;

namespace Launch
{
    /// <summary>
    /// 启动初始化流程
    /// </summary>
    public class LaunchProcedure : ProcedureBase
    {
        protected override void OnEnter(IFsm fsm)
        {
            base.OnEnter(fsm);
            Debug.Log("OnEnter LaunchProcedure");
        }

        protected override void OnLeave(IFsm fsm)
        {
            base.OnLeave(fsm);
        }

        protected override void OnUpdate(IFsm fsm, float dt)
        {
            base.OnUpdate(fsm, dt);
            Debug.Log("OnUpdate LaunchProcedure");
        }
    }
}