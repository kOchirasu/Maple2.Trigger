namespace Maple2.Trigger._02000386_bf {
    public static class _main_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {901})) {
                    return new Stateready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$02000386_BF__MAIN_02__0$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {901});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}