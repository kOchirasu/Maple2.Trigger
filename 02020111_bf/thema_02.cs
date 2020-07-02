namespace Maple2.Trigger._02020111_bf {
    public static class _thema_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1003})) {
                    return new State소환준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환준비 : TriggerState {
            internal State소환준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear : TriggerState {
            internal StateMonsterAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {151, 152, 153, 154, 155, 156});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    return new StateMonsterDestroy(context);
                }

                if (context.MonsterDead(arg1: new[] {151, 152, 153, 154, 155, 156})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    return new StateMonsterDestroy(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateMonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {151, 152, 153, 154, 155, 156});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}