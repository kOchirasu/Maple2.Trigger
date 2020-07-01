namespace Maple2.Trigger._99999841 {
    public static class _boss_hp {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 200) == true) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 911) <= 0.70f) {
                    return new State70프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State70프로 : TriggerState {
            internal State70프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 210, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 911) <= 0.50f) {
                    return new State50프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50프로 : TriggerState {
            internal State50프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 220, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 911) <= 0.30f) {
                    return new State30프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30프로 : TriggerState {
            internal State30프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 230, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 911) <= 0.10f) {
                    return new State10프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10프로 : TriggerState {
            internal State10프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 240, value: true);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}