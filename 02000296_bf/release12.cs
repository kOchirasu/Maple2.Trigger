namespace Maple2.Trigger._02000296_bf {
    public static class _release12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5010, 50101, 50102});
                context.SetInteractObject(interactIds: new []{10000502}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000502}, arg2: 0)) {
                    return new StateNpcSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn01 : TriggerState {
            internal StateNpcSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5010, 50101, 50102});
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
                context.SetConversation(type: 1, spawnId: 5010, script: "$02000296_BF__NPC3__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 50101, script: "$02000296_BF__NPC9__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 50102, script: "$02000296_BF__NPC10__0$", arg4: 2, arg5: 2);
                context.MoveNpc(spawnId: 5010, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50101, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50102, patrolName: "MS2PatrolData2");
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
                context.DestroyMonster(spawnIds: new []{5010, 50101, 50102});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
