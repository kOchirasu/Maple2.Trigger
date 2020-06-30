using System;

namespace Maple2.Trigger._02020130_bf {
    public static class _skillbreakwarningmessage {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 601, arg2: 1)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State신호받기대기중 : TriggerState {
            internal State신호받기대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WarningMessage", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "WarningMessage", value: 1)) {
                    context.State = new State스킬브레이크메시지출력(context);
                    return;
                }

                if (context.UserValue(key: "DeathIshuraRbladerDark", value: 1)) {
                    context.State = new State이슈라죽음알림(context);
                    return;
                }

                if (context.UserValue(key: "DeathRenduebianRbladerDark", value: 1)) {
                    context.State = new State렌듀비앙죽음알림(context);
                    return;
                }

                if (context.UserValue(key: "DeathYuperiaRbladerDark", value: 1)) {
                    context.State = new State유페리아죽음알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크메시지출력 : TriggerState {
            internal State스킬브레이크메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20051001, textID: 20051001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State천천히다시처음으로돌아가기직전(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20051001);
            }
        }

        private class State이슈라죽음알림 : TriggerState {
            internal State이슈라죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20051002, textID: 20051002);
                context.SetUserValue(key: "DeathIshuraRbladerDark", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }

                if (context.UserValue(key: "DeathRenduebianRbladerDark", value: 1)) {
                    context.State = new State렌듀비앙죽음알림(context);
                    return;
                }

                if (context.UserValue(key: "DeathYuperiaRbladerDark", value: 1)) {
                    context.State = new State유페리아죽음알림(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20051002);
            }
        }

        private class State렌듀비앙죽음알림 : TriggerState {
            internal State렌듀비앙죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20051003, textID: 20051003);
                context.SetUserValue(key: "DeathRenduebianRbladerDark", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }

                if (context.UserValue(key: "DeathIshuraRbladerDark", value: 1)) {
                    context.State = new State이슈라죽음알림(context);
                    return;
                }

                if (context.UserValue(key: "DeathYuperiaRbladerDark", value: 1)) {
                    context.State = new State유페리아죽음알림(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20051003);
            }
        }

        private class State유페리아죽음알림 : TriggerState {
            internal State유페리아죽음알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20051004, textID: 20051004);
                context.SetUserValue(key: "DeathYuperiaRbladerDark", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }

                if (context.UserValue(key: "DeathIshuraRbladerDark", value: 1)) {
                    context.State = new State이슈라죽음알림(context);
                    return;
                }

                if (context.UserValue(key: "DeathRenduebianRbladerDark", value: 1)) {
                    context.State = new State렌듀비앙죽음알림(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20051004);
            }
        }

        private class State천천히다시처음으로돌아가기직전 : TriggerState {
            internal State천천히다시처음으로돌아가기직전(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}