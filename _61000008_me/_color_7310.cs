namespace Maple2.Trigger._61000008_me {
    public static class _color_7310 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color31", value: 10);
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931, 1031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {931, 1031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    // context.State = new StateYellowtoRed(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1031}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931, 831}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {931}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    context.State = new StateRedAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateYellowAfter : TriggerState {
            internal StateYellowAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {931}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1031}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    context.State = new StateRedAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedAfter : TriggerState {
            internal StateRedAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1031}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {831}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 2) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {931}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {831}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {1031}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateRegen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRegen : TriggerState {
            internal StateRegen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 400, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931, 1031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                if (context.GetUserValue(key: "Color31") == 5) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}