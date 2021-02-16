namespace Maple2.Trigger._02000253_bf {
    public static class _ground {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {701, 702}, arg2: false);
                context.SetMesh(arg1: new[] {107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 906) == 1) {
                    return new State벨라소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
                context.CreateMonster(arg1: new[] {1001});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동 : TriggerState {
            internal State벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 1001, script: "$02000253_BF__GROUND__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동2 : TriggerState {
            internal State벨라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1");
                context.SetConversation(arg1: 1, arg2: 1001, script: "$02000253_BF__GROUND__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라소멸 : TriggerState {
            internal State벨라소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 140);
                context.DestroyMonster(arg1: new[] {1001});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State지진(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지진 : TriggerState {
            internal State지진(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}