namespace Maple2.Trigger._02000095_bf {
    public static class _quest_music {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{101}, visible: false);
                context.SetInteractObject(interactIds: new []{10000465}, state: 1);
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000465}, arg2: 0)) {
                    return new StateNPC대화(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{892});
                context.CreateMonster(spawnIds: new []{893});
                context.CreateMonster(spawnIds: new []{894});
            }
        }

        private class StateNPC대화 : TriggerState {
            internal StateNPC대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 892, script: "$02000095_BF__QUEST_MUSIC__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 893, script: "$02000095_BF__QUEST_MUSIC__1$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 894, script: "$02000095_BF__QUEST_MUSIC__2$", arg4: 2, arg5: 4);
                context.SetTimer(timerId: "1", seconds: 8);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{101}, visible: true);
                context.DestroyMonster(spawnIds: new []{892, 893, 894});
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
