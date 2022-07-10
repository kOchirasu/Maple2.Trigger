namespace Maple2.Trigger._99999931 {
    public static class _processlevel03 {
        public class StateLeverPull : TriggerState {
            internal StateLeverPull(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000219}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000219}, arg2: 0)) {
                    return new StateCount다운1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운1 : TriggerState {
            internal StateCount다운1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 1);
                context.SetEventUI(arg1: 1, script: "3", duration: 1000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new StateCount다운2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운2 : TriggerState {
            internal StateCount다운2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "32", seconds: 1);
                context.SetEventUI(arg1: 1, script: "2", duration: 1000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "32")) {
                    return new StateCount다운3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운3 : TriggerState {
            internal StateCount다운3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "33", seconds: 1);
                context.SetEventUI(arg1: 1, script: "1", duration: 1000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "33")) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "34", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 112, 113, 115, 116, 118, 119, 121, 122, 124, 125, 130, 131, 132, 133, 134, 135, 136}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "34")) {
                    return new State게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임진행1 : TriggerState {
            internal State게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 112, 113, 115, 116, 118, 119, 121, 122, 124, 125, 130, 131, 132, 133, 134, 135, 136}, enabled: false);
                context.SetSkill(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 812, 813, 815, 816, 818, 819, 821, 822, 824, 825, 830, 831, 832, 833, 834, 835, 836}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new State게임진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임진행2 : TriggerState {
            internal State게임진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "36", seconds: 2);
                context.SetSkill(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 812, 813, 815, 816, 818, 819, 821, 822, 824, 825, 830, 831, 832, 833, 834, 835, 836}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "36")) {
                    return new StateLeverPull(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
