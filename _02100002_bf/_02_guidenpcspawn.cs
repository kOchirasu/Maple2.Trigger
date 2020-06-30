using System;

namespace Maple2.Trigger._02100002_bf {
    public static class _02_guidenpcspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GuideNpcSpawn", value: 0);
                context.DestroyMonster(arg1: new int[] {109});
            }

            public override void Execute() {
                if (context.UserValue(key: "GuideNpcSpawn", value: 1)) {
                    context.State = new StateNpcSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_GuideNpc");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new StateCheckUser(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckUser : TriggerState {
            internal StateCheckUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {109});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}