namespace Maple2.Trigger._99999931 {
    public static class _processlevel01 {
        public class StateLeverPull : TriggerState {
            internal StateLeverPull(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000217}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000217}, arg2: 0)) {
                    return new StateCount다운1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운1 : TriggerState {
            internal StateCount다운1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "31", arg2: 1);
                context.SetEventUI(arg1: 1, script: "3", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new StateCount다운2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운2 : TriggerState {
            internal StateCount다운2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "32", arg2: 1);
                context.SetEventUI(arg1: 1, script: "2", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    return new StateCount다운3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운3 : TriggerState {
            internal StateCount다운3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "33", arg2: 1);
                context.SetEventUI(arg1: 1, script: "1", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "34", arg2: 1);
                context.SetBreakable(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 114, 115, 116, 118, 119, 121, 123, 126, 130, 131, 132, 133, 134, 135}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    return new State게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임진행1 : TriggerState {
            internal State게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "35", arg2: 1);
                context.SetBreakable(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 114, 115, 116, 118, 119, 121, 123, 126, 130, 131, 132, 133, 134, 135}, arg2: false);
                context.SetSkill(arg1: new[] {801, 802, 803, 804, 805, 806, 807, 814, 815, 816, 818, 819, 821, 823, 826, 830, 831, 832, 833, 834, 835}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new State게임진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임진행2 : TriggerState {
            internal State게임진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "36", arg2: 2);
                context.SetSkill(arg1: new[] {801, 802, 803, 804, 805, 806, 807, 814, 815, 816, 818, 819, 821, 823, 826, 830, 831, 832, 833, 834, 835}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "36")) {
                    return new StateLeverPull(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}