namespace Maple2.Trigger._02000252_bf {
    public static class _door_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {173, 174}, arg2: true);
                context.SetEffect(arg1: new[] {8035, 8036}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000404}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000404}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new[] {173, 174}, arg2: false);
                context.SetEffect(arg1: new[] {8035, 8036}, arg2: false);
                context.CreateMonster(arg1: new[] {1013}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1013, arg3: "$02000252_BF__DOOR_03__0$", arg4: 2);
                context.MoveNpc(arg1: 1013, arg2: "MS2PatrolData_6");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삭제 : TriggerState {
            internal State삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1013});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}