namespace Maple2.Trigger._02000329_bf {
    public static class _cage_08 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6808}, arg2: false);
                context.SetActor(arg1: 208, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new[] {1008, 1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1108})) {
                    context.State = new State닭생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State닭생성 : TriggerState {
            internal State닭생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 208, arg2: true, arg3: "Opened");
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {608}, arg2: false);
                context.SetEffect(arg1: new[] {6808}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State닭이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State닭이동 : TriggerState {
            internal State닭이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008");
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State닭소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State닭소멸 : TriggerState {
            internal State닭소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1008});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}