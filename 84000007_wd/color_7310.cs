namespace Maple2.Trigger._84000007_wd {
    public static class _color_7310 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color31", value: 10);
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931, 1031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ColorStart") == 1) {
                    return new StateYellowBefore(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateYellowBefore : TriggerState {
            internal StateYellowBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {831}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {931, 1031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    // return new StateYellowtoRed(context);
                    return null;
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1031}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {931, 831}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {931}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    return new StateRedAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 3) {
                    return new StateRedAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color31") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color31") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateRegen(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Color31") == 5) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}