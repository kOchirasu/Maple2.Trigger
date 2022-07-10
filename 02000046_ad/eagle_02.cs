namespace Maple2.Trigger._02000046_ad {
    public static class _eagle_02 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000294}, state: 1);
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000294}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() {
                context.SetActor(triggerId: 202, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{302}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_202");
                context.SetConversation(type: 1, spawnId: 302, script: "$02000046_AD__EAGLE_02__0$", arg4: 2);
                context.SetTimer(timerId: "1", seconds: 20);
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
                context.DestroyMonster(spawnIds: new []{302});
            }

            public override TriggerState? Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}
