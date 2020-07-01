namespace Maple2.Trigger._84000007_wd {
    public static class _color_7120 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color12", value: 10);
                context.SetMesh(arg1: new[] {812}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {912, 1012}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ColorStart") == 1) {
                    context.State = new StateYellowBefore(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateYellowBefore : TriggerState {
            internal StateYellowBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {812}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {912, 1012}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 3) {
                    // context.State = new StateYellowtoRed(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1012}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {912, 812}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {912}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 3) {
                    context.State = new StateRedAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateYellowAfter : TriggerState {
            internal StateYellowAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {812}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {912}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1012}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 3) {
                    context.State = new StateRedAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedAfter : TriggerState {
            internal StateRedAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1012}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {912}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {812}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {912}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {812}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {1012}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRegen : TriggerState {
            internal StateRegen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {812}, arg2: true, arg3: 400, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {912, 1012}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color12") == 5) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}