namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_hint {
        public class State힌트 : TriggerState {
            internal State힌트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818}, visible: true, meshCount: 2, arg4: 0, delay: 1000);
                context.SetTimer(timerId: "99", seconds: 3, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818}, visible: false);
                context.SetTimer(timerId: "41", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "41")) {
                    return new State힌트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
