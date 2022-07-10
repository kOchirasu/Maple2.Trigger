namespace Maple2.Trigger._52000057_qd {
    public static class _guidescene_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000611}, questStates: new byte[]{2})) {
                    return new State오필리아리젠(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000611}, questStates: new byte[]{1})) {
                    return new State오필리아리젠(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000610}, questStates: new byte[]{3})) {
                    return new State오필리아리젠상시(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000610}, questStates: new byte[]{2})) {
                    return new State오필리아리젠상시(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000610}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script01 : TriggerState {
            internal State말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 198, spawnIds: new []{1001})) {
                    return new State시네마틱Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시네마틱Script01 : TriggerState {
            internal State시네마틱Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001871, script: "$52000057_QD__GUIdESCENE_01__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001871, script: "$52000057_QD__GUIdESCENE_01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State연퀘감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연퀘감지 : TriggerState {
            internal State연퀘감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000611}, questStates: new byte[]{1})) {
                    return new State오필리아대사Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오필리아리젠 : TriggerState {
            internal State오필리아리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State오필리아대사Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오필리아대사Cinematic01 : TriggerState {
            internal State오필리아대사Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001871, script: "$52000057_QD__GUIdESCENE_01__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSendSignalToGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSendSignalToGuide01 : TriggerState {
            internal StateSendSignalToGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 60660);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오필리아리젠상시 : TriggerState {
            internal State오필리아리젠상시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000611}, questStates: new byte[]{1})) {
                    return new State오필리아대사Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
