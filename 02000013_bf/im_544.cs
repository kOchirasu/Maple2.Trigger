namespace Maple2.Trigger._02000013_bf {
    public static class _im_544 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000544}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {103});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000544}, arg2: 0)) {
                    return new State시간텀(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {1103});
            }
        }

        private class State시간텀 : TriggerState {
            internal State시간텀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1103, arg2: "MS2PatrolData_544");
                context.SetConversation(arg1: 1, arg2: 1103, script: "$02000013_BF__IM_544__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 544, arg2: new[] {1103})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1103});
                context.SetTimer(id: "1", arg2: 20);
                context.RemoveBalloonTalk(spawnPointId: 1103);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}