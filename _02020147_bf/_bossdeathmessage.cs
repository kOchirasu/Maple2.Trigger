using System;

namespace Maple2.Trigger._02020147_bf {
    public static class _bossdeathmessage {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 601, arg2: 1)) {
                    context.State = new State변수초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State변수초기화 : TriggerState {
            internal State변수초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DeathIshuraRbladerDark", value: 0);
                context.SetUserValue(key: "DeathRenduebianRbladerDark", value: 0);
                context.SetUserValue(key: "DeathYuperiaRbladerDark", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State신호받기대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State신호받기대기중 : TriggerState {
            internal State신호받기대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
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
    }
}