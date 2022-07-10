namespace Maple2.Trigger._52020019_qd {
    public static class _eone {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{60200010}, questStates: new byte[]{1})) {
                    return new StateTalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk : TriggerState {
            internal StateTalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "무엄하군요! 저리 가세요!", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
