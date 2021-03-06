namespace Maple2.Trigger._02000329_bf {
    public static class _cage_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6807}, arg2: false);
                context.SetActor(arg1: 207, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new[] {1007, 1107}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1107})) {
                    return new State닭Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭Creation : TriggerState {
            internal State닭Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 207, arg2: true, arg3: "Opened");
                context.SetTimer(id: "1", arg2: 1);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetEffect(arg1: new[] {6807}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State닭이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭이동 : TriggerState {
            internal State닭이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007");
                context.SetTimer(id: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State닭소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭소멸 : TriggerState {
            internal State닭소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1007});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}