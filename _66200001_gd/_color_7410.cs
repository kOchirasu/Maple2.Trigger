using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _color_7410 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color41", value: 10);
                context.SetMesh(arg1: new int[] {841}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1041}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorStart", value: 1)) {
                    context.State = new StateYellowBefore(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateYellowBefore : TriggerState {
            internal StateYellowBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {841}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1041}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorClear", value: 1)) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.UserValue(key: "ColorReset", value: 1)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateRegen(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 2)) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 3)) {
                    // context.State = new StateYellowtoRed(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1041}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {841}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorClear", value: 1)) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.UserValue(key: "ColorReset", value: 1)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateRegen(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 1)) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 2)) {
                    context.State = new StateGreenAfter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {941}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorClear", value: 1)) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.UserValue(key: "ColorReset", value: 1)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateRegen(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 1)) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 3)) {
                    context.State = new StateRedAfter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateYellowAfter : TriggerState {
            internal StateYellowAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {841}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1041}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorClear", value: 1)) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.UserValue(key: "ColorReset", value: 1)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateRegen(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 2)) {
                    context.State = new StateGreenAfter(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 3)) {
                    context.State = new StateRedAfter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRedAfter : TriggerState {
            internal StateRedAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1041}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {841}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorClear", value: 1)) {
                    context.State = new StateClear(context);
                    return;
                }

                if (context.UserValue(key: "ColorReset", value: 1)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateRegen(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 1)) {
                    context.State = new StateYellowAfter(context);
                    return;
                }

                if (context.UserValue(key: "Color41", value: 2)) {
                    context.State = new StateGreenAfter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {841}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {1041}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorEnd", value: 1)) {
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
                context.SetUserValue(key: "ColorEnd", value: 0);
                context.SetUserValue(key: "ColorReset", value: 0);
                context.SetUserValue(key: "ColorClear", value: 0);
                context.SetMesh(arg1: new int[] {841}, arg2: true, arg3: 400, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {941}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1041}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetUserValue(key: "ColorReset", value: 0);
                context.SetUserValue(key: "ColorClear", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "ColorEnd", value: 1)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(key: "ColorEnd", value: 0);
            }
        }
    }
}