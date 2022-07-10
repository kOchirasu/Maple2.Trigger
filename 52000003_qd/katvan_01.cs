namespace Maple2.Trigger._52000003_qd {
    public static class _katvan_01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{50001743}, questStates: new byte[]{1})) {
                    return new State카트반Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반Creation : TriggerState {
            internal State카트반Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 101, enable: true);
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대화시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000003_QD__KATVAN_01__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카트반Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반Script1 : TriggerState {
            internal State카트반Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001024, script: "$52000003_QD__KATVAN_01__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카트반Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반Script2 : TriggerState {
            internal State카트반Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001024, script: "$52000003_QD__KATVAN_01__2$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State레논Script1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{102});
            }
        }

        private class State레논Script1 : TriggerState {
            internal State레논Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000003_QD__KATVAN_01__3$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera원위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera원위치 : TriggerState {
            internal StateCamera원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera원위치_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera원위치_1 : TriggerState {
            internal StateCamera원위치_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 0.5f);
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 100, type: "trigger", code: "Katvan");
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
