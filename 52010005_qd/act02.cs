namespace Maple2.Trigger._52010005_qd {
    public static class _act02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    context.SetInteractObject(interactIds: new []{10000872}, state: 0);
                    return new StateQuest조건02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건02 : TriggerState {
            internal StateQuest조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002821}, questStates: new byte[]{2})) {
                    return new StateQ2_미카Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카Spawn01 : TriggerState {
            internal StateQ2_미카Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateQ2_Delay01(context);
            }

            public override void OnExit() { }
        }

        private class StateQ2_Delay01 : TriggerState {
            internal StateQ2_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 2);
                context.CameraSelect(triggerId: 3001, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StateQ2_미카대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화01 : TriggerState {
            internal StateQ2_미카대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010005_QD__ACT02__0$", arg4: 3);
                context.SetSkip(state: new StateQ2_미카대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
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

            public override TriggerState? Execute() {
                return new StateQ2_미카대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화02 : TriggerState {
            internal StateQ2_미카대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010005_QD__ACT02__1$", arg4: 3);
                context.SetSkip(state: new StateQ2_미카대화종료(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
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
                context.CameraSelect(triggerId: 3001, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
