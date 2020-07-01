namespace Maple2.Trigger._02000312_bf {
    public static class _move_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetBreakable(arg1: new[] {4000}, arg2: false);
                context.SetBreakable(arg1: new[] {4001}, arg2: false);
                context.SetBreakable(arg1: new[] {4002}, arg2: false);
                context.SetBreakable(arg1: new[] {4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4002}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4003}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001034}, arg2: 2);
                context.SetUserValue(key: "BoardApp", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BoardApp") == 1) {
                    context.State = new StateBoardApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardApp01 : TriggerState {
            internal StateBoardApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBoardApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardApp02 : TriggerState {
            internal StateBoardApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031204, textId: 20031204);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001034}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001034}, arg2: 0)) {
                    context.State = new StateBoardGoUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp01 : TriggerState {
            internal StateBoardGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031204);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10001034}, arg2: 2);
                context.SetBreakable(arg1: new[] {4000}, arg2: true);
                context.SetBreakable(arg1: new[] {4001}, arg2: true);
                context.SetBreakable(arg1: new[] {4002}, arg2: true);
                context.SetBreakable(arg1: new[] {4003}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4001}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4002}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateBoardGoUp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp02 : TriggerState {
            internal StateBoardGoUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBoardDisApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardDisApp01 : TriggerState {
            internal StateBoardDisApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203}, arg2: true, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateBoardDisApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardDisApp02 : TriggerState {
            internal StateBoardDisApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4000}, arg2: false);
                context.SetBreakable(arg1: new[] {4001}, arg2: false);
                context.SetBreakable(arg1: new[] {4002}, arg2: false);
                context.SetBreakable(arg1: new[] {4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4002}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBoardReset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardReset01 : TriggerState {
            internal StateBoardReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBoardReset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardReset02 : TriggerState {
            internal StateBoardReset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001034}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001034}, arg2: 0)) {
                    context.State = new StateBoardReset03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardReset03 : TriggerState {
            internal StateBoardReset03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBoardGoUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}