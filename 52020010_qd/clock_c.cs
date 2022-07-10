namespace Maple2.Trigger._52020010_qd {
    public static class _clock_c {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007, 5008, 5009, 5010}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2004})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001273}, arg2: 0)) {
                    return new StateEvent_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: true);
                context.CreateMonster(spawnIds: new []{301, 302}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5008}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 302, sequenceName: "Bore_B", duration: 18000f);
                context.AddBalloonTalk(spawnId: 302, msg: "엄마 무서워...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 301, msg: "울지마렴... 조금 있으면 괜찮아 질거야...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5009}, visible: true);
                context.AddBalloonTalk(spawnId: 301, msg: "여보? 어디 간 거에요!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5010}, visible: true);
                context.AddBalloonTalk(spawnId: 301, msg: "여보!!!", duration: 2800, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 302, msg: "엄마... 아빠... 무서워...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007, 5008, 5009, 5010}, visible: false);
                context.DestroyMonster(spawnIds: new []{301, 302});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
