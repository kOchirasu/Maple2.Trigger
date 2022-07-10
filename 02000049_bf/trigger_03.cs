namespace Maple2.Trigger._02000049_bf {
    public static class _trigger_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
                context.SetInteractObject(interactIds: new []{10000288}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000288}, arg2: 0)) {
                    return new State반항(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반항 : TriggerState {
            internal State반항(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000049_BF__TRIGGER_03__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                return new State반항2(context);
            }

            public override void OnExit() { }
        }

        private class State반항2 : TriggerState {
            internal State반항2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 30, clearAtZero: false);
                context.SetInteractObject(interactIds: new []{10000288}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
