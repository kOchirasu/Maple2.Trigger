namespace Maple2.Trigger._52010005_qd {
    public static class _act02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.SetInteractObject(arg1: new[] {10000872}, arg2: 0);
                    return new StateQuest조건02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건02 : TriggerState {
            internal StateQuest조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002821}, arg3: new byte[] {2})) {
                    return new StateQ2_미카Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카Appear01 : TriggerState {
            internal StateQ2_미카Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateQ2_Delay01(context);
            }

            public override void OnExit() { }
        }

        private class StateQ2_Delay01 : TriggerState {
            internal StateQ2_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 2);
                context.CameraSelect(arg1: 3001, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StateQ2_미카대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화01 : TriggerState {
            internal StateQ2_미카대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT02__0$", arg4: 3);
                context.SetSkip(arg1: "Q2_미카대화02Wait");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new StateQ2_미카대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화02Wait : TriggerState {
            internal StateQ2_미카대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateQ2_미카대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화02 : TriggerState {
            internal StateQ2_미카대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT02__1$", arg4: 3);
                context.SetSkip(arg1: "Q2_미카대화종료");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new StateQ2_미카대화종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화종료 : TriggerState {
            internal StateQ2_미카대화종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 3001, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}