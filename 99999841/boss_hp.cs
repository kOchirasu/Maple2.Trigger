namespace Maple2.Trigger._99999841 {
    public static class _boss_hp {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 200) == true) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 911) <= 0.70f) {
                    return new State70프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State70프로 : TriggerState {
            internal State70프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 210, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 911) <= 0.50f) {
                    return new State50프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50프로 : TriggerState {
            internal State50프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 220, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 911) <= 0.30f) {
                    return new State30프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30프로 : TriggerState {
            internal State30프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 230, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 911) <= 0.10f) {
                    return new State10프로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10프로 : TriggerState {
            internal State10프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 240, value: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
