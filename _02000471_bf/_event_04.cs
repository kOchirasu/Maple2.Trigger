using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _event_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1803}, arg2: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new int[] {1804}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new int[] {1805}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new int[] {1806}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "705")) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1803}, arg2: false, arg3: 0, arg4: 200, arg5: 85f);
                context.SetMesh(arg1: new int[] {1804}, arg2: true, arg3: 0, arg4: 200, arg5: 85f);
                context.SetMesh(arg1: new int[] {1805}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateReady_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1803}, arg2: false, arg3: 0, arg4: 200, arg5: 5f);
                context.SetMesh(arg1: new int[] {1804}, arg2: true, arg3: 0, arg4: 200, arg5: 5f);
                context.SetMesh(arg1: new int[] {1806}, arg2: true, arg3: 0, arg4: 200, arg5: 5f);
                context.SetAchievement(arg1: 705, arg2: "trigger", arg3: "Hauntedmansion");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReady_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_03 : TriggerState {
            internal StateReady_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1806}, arg2: false, arg3: 0, arg4: 200, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}