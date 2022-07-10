namespace Maple2.Trigger._52000002_qd {
    public static class _sheep_05 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{615}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000615}, arg2: 0)) {
                    return new StateNPC교체(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.CreateMonster(spawnIds: new []{1095});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.SetInteractObject(interactIds: new []{10000615}, state: 2);
                    return new StateNPC이동(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 6);
                context.SetEffect(triggerIds: new []{615}, visible: true);
                context.MoveNpc(spawnId: 1095, patrolName: "MS2PatrolData_1095");
                context.SetConversation(type: 1, spawnId: 1095, script: "$52000002_QD__SHEEP_05__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateNPCDestroy(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1095});
            }

            public override TriggerState? Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}
