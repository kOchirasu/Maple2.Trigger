using System;

namespace Maple2.Trigger._52100201_qd {
    public static class _cube4_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "CubeOff", value: 1)) {
                    context.State = new StateOff_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_1 : TriggerState {
            internal StateOff_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOn_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_1 : TriggerState {
            internal StateOn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOff_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_2 : TriggerState {
            internal StateOff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOn_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_2 : TriggerState {
            internal StateOn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOff_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_3 : TriggerState {
            internal StateOff_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOn_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_3 : TriggerState {
            internal StateOn_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateOff_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_4 : TriggerState {
            internal StateOff_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOn_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_4 : TriggerState {
            internal StateOn_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOff_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_5 : TriggerState {
            internal StateOff_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOn_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_5 : TriggerState {
            internal StateOn_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOff_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_6 : TriggerState {
            internal StateOff_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOn_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOn_6 : TriggerState {
            internal StateOn_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 150)) {
                    context.State = new StateOff_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff_7 : TriggerState {
            internal StateOff_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5006, 5007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.SetUserValue(triggerID: 920004, key: "CubeOff", value: 0);
                    context.SetUserValue(triggerID: 910004, key: "Cube", value: 2);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}