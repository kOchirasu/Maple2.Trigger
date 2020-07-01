using System;

namespace Maple2.Trigger._02100001_bf {
    public static class _11_guidenpcspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {109});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9903})) {
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
                if (!context.UserDetected(arg1: new int[] {9903})) {
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