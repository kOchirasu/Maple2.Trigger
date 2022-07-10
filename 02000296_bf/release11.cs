namespace Maple2.Trigger._02000296_bf {
    public static class _release11 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5009, 50091, 50092});
                context.SetInteractObject(interactIds: new []{10000501}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000501}, arg2: 0)) {
                    return new StateNpcSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn01 : TriggerState {
            internal StateNpcSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5009, 50091, 50092});
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
                context.SetConversation(type: 1, spawnId: 5009, script: "$02000296_BF__NPC2__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 50091, script: "$02000296_BF__NPC7__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 50092, script: "$02000296_BF__NPC8__0$", arg4: 2, arg5: 2);
                context.MoveNpc(spawnId: 5009, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50091, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 50092, patrolName: "MS2PatrolData2");
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
                context.DestroyMonster(spawnIds: new []{5009, 50091, 50092});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
