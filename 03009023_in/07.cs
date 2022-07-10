namespace Maple2.Trigger._03009023_in {
    public static class _07 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000239}, state: 1);
                context.CreateMonster(spawnIds: new []{107}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000239}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 12);
                context.DestroyMonster(spawnIds: new []{107});
                context.CreateMonster(spawnIds: new []{207}, arg2: true);
                context.MoveNpc(spawnId: 207, patrolName: "MS2PatrolData_207");
                context.SetConversation(type: 1, spawnId: 207, script: "$03009023_IN__07__0$", arg4: 4, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{207});
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
