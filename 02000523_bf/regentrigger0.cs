namespace Maple2.Trigger._02000523_bf {
    public static class _regentrigger0 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 100, spawnIds: new []{900})) {
                    return new State웜리젠91(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웜리젠91 : TriggerState {
            internal State웜리젠91(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1, 2});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1, 2})) {
                    return new State웜리젠91CoolTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웜리젠91CoolTime : TriggerState {
            internal State웜리젠91CoolTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "9");
                context.SetTimer(timerId: "9", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    context.ResetTimer(timerId: "9");
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
