namespace Maple2.Trigger._02020142_bf {
    public static class _2phaseplayercheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "2PhasePlayerCheckStart") == 1) {
                    return new State1Phase지점체크하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Phase지점체크하기 : TriggerState {
            internal State1Phase지점체크하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{98})) {
                    return new StateEnd(context);
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99})) {
                    return new StateEnd(context);
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

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2Phase복격진행_안내DisplayGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Phase복격진행_안내DisplayGuide : TriggerState {
            internal State2Phase복격진행_안내DisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{91}, enabled: true);
                context.ShowGuideSummary(entityId: 29200003, textId: 29200003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200003);
            }
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
