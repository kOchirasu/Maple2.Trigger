using System;

namespace Maple2.Trigger._52000066_qd {
    public static class _trap02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001071}, arg2: 0);
                context.SetMesh(
                    arg1: new int[] {
                        2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027,
                        2028, 2029
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetUserValue(key: "TrapLeverOn", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "TrapLeverOn", value: 1)) {
                    context.State = new StateTrapLeverOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrapLeverOn01 : TriggerState {
            internal StateTrapLeverOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001071}, arg2: 1);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001071}, arg2: 0)) {
                    context.State = new StateTrapFalse01(context);
                    return;
                }

                if (context.UserValue(key: "TrapLeverOn", value: 2)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrapFalse01 : TriggerState {
            internal StateTrapFalse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001071}, arg2: 0);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(
                    arg1: new int[] {
                        2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027,
                        2028, 2029
                    }, arg2: true, arg3: 500, arg4: 50, arg5: 1f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9300})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001071}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}