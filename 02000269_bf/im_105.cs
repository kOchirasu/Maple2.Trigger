namespace Maple2.Trigger._02000269_bf {
    public static class _im_105 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000680}, state: 1);
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{105});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000680}, arg2: 0)) {
                    return new State시간텀(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{1105});
            }
        }

        private class State시간텀 : TriggerState {
            internal State시간텀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1105, patrolName: "MS2PatrolData_1105");
                context.SetConversation(type: 1, spawnId: 1105, script: "$02000269_BF__IM_105__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 1105, spawnIds: new []{1105})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1105});
                context.SetTimer(timerId: "1105", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1105")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
