namespace Maple2.Trigger._52000066_qd {
    public static class _trap02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001071}, arg2: 0);
                context.SetMesh(arg1: new[] {2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetUserValue(key: "TrapLeverOn", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TrapLeverOn") == 1) {
                    return new StateTrapLeverOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrapLeverOn01 : TriggerState {
            internal StateTrapLeverOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001071}, arg2: 1);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001071}, arg2: 0)) {
                    return new StateTrapFalse01(context);
                }

                if (context.GetUserValue(key: "TrapLeverOn") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrapFalse01 : TriggerState {
            internal StateTrapFalse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001071}, arg2: 0);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029}, arg2: true, arg3: 500, arg4: 50, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001071}, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}