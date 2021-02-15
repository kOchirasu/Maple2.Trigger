namespace Maple2.Trigger._99999931 {
    public static class _processlevel04 {
        public class StateLeverPull : TriggerState {
            internal StateLeverPull(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000220}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000220}, arg2: 0)) {
                    return new StateCount다운1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운1 : TriggerState {
            internal StateCount다운1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "3", arg3: 1000);
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
                context.SetTimer(arg1: "32", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "2", arg3: 1000);
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
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "1", arg3: 1000);
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
                context.SetTimer(arg1: "34", arg2: 1);
                context.SetBreakable(arg1: new[] {101, 102, 104, 105, 107, 108, 111, 112, 114, 115, 117, 118, 120, 121, 122, 123, 125, 126, 128, 129, 130, 131, 132, 135, 136}, arg2: true);
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
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetBreakable(arg1: new[] {101, 102, 104, 105, 107, 108, 111, 112, 114, 115, 117, 118, 120, 121, 122, 123, 125, 126, 128, 129, 130, 131, 132, 135, 136}, arg2: false);
                context.SetSkill(arg1: new[] {801, 802, 804, 805, 807, 808, 811, 812, 814, 815, 817, 818, 820, 821, 822, 823, 825, 826, 828, 829, 830, 831, 832, 835, 836}, arg2: true);
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
                context.SetTimer(arg1: "36", arg2: 2);
                context.SetSkill(arg1: new[] {801, 802, 804, 805, 807, 808, 811, 812, 814, 815, 817, 818, 820, 821, 822, 823, 825, 826, 828, 829, 830, 831, 832, 835, 836}, arg2: false);
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