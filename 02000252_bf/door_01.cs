namespace Maple2.Trigger._02000252_bf {
    public static class _door_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {169, 170}, arg2: true);
                context.SetEffect(arg1: new[] {8031, 8032}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000401}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000401}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.SetEffect(arg1: new[] {8031, 8032}, arg2: false);
                context.SetMesh(arg1: new[] {169, 170}, arg2: false);
                context.CreateMonster(arg1: new[] {1012}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1012, script: "$02000252_BF__DOOR_01__0$", arg4: 2);
                context.MoveNpc(arg1: 1012, arg2: "MS2PatrolData_3");
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
                context.DestroyMonster(arg1: new[] {1012});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}