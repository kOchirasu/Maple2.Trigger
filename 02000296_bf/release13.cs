namespace Maple2.Trigger._02000296_bf {
    public static class _release13 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5011, 50111, 50112});
                context.SetInteractObject(interactIds: new []{10000503}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000503}, arg2: 0)) {
                    return new StateNpcSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn01 : TriggerState {
            internal StateNpcSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5011, 50111, 50112});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMove01 : TriggerState {
            internal StateNpcMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 5011, script: "$02000296_BF__NPC4__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 50111, script: "$02000296_BF__NPC11__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 50112, script: "$02000296_BF__NPC12__0$", arg4: 2, arg5: 2);
                context.MoveNpc(spawnId: 5011, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50111, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50112, patrolName: "MS2PatrolData2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateNpcRemove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5011, 50111, 50112});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
