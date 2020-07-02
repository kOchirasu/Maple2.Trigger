namespace Maple2.Trigger._99999926 {
    public static class _main {
        public class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {421, 422, 423, 424, 425}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {421, 422, 423, 424, 425})) {
                    return new StateBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {411, 412, 413, 414, 415}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {411, 412, 413, 414, 415})) {
                    return new StateBattle03Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Random : TriggerState {
            internal StateBattle03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateBattle03A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateBattle03B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03A : TriggerState {
            internal StateBattle03A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {421, 422, 423, 424, 425, 441}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {421, 422, 423, 424, 425})) {
                    return new StateMevidicCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03B : TriggerState {
            internal StateBattle03B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {411, 412, 413, 414, 415, 441}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {411, 412, 413, 414, 415})) {
                    return new StateMevidicCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMevidicCinematic : TriggerState {
            internal StateMevidicCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {451}, arg2: false);
                context.MoveNpc(arg1: 451, arg2: "MS2PatrolData_701");
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 402) == 1) {
                    // return new StateLoadingStart(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}