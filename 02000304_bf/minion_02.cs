namespace Maple2.Trigger._02000304_bf {
    public static class _minion_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{112})) {
                    context.CreateMonster(spawnIds: new []{1003, 1004}, arg2: false);
                    return new StateEnd체크(context);
                }

                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1003, 1004})) {
                    return new StateWaitTime(context);
                }

                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.DestroyMonster(spawnIds: new []{1003, 1004});
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.MoveUser(mapId: 02000304, portalId: 10, boxId: 112);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
