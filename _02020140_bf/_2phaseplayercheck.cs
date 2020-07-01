namespace Maple2.Trigger._02020140_bf {
    public static class _2phaseplayercheck {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State안잡힌플레이어체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안잡힌플레이어체크 : TriggerState {
            internal State안잡힌플레이어체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhasePlayerCheckStart") == 1) {
                    return new State1페이즈지점체크하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1페이즈지점체크하기 : TriggerState {
            internal State1페이즈지점체크하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {98})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 900)) {
                    return new State추가로최초시작지점체크하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가로최초시작지점체크하기 : TriggerState {
            internal State추가로최초시작지점체크하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 900)) {
                    return new State안잡힌플레이어없음확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안잡힌플레이어없음확인 : TriggerState {
            internal State안잡힌플레이어없음확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2페이즈복격진행_안내메시지출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2페이즈복격진행_안내메시지출력 : TriggerState {
            internal State2페이즈복격진행_안내메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {91}, arg2: true);
                context.ShowGuideSummary(entityId: 29200003, textId: 29200003);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200003);
            }
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