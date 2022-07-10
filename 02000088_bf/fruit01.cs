namespace Maple2.Trigger._02000088_bf {
    public static class _fruit01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000138}, state: 1);
                context.SetEffect(triggerIds: new []{201}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000138}, arg2: 0)) {
                    return new StateMonster리젠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster리젠 : TriggerState {
            internal StateMonster리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{201}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 90);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateTriggerReset(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
