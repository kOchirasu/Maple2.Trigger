using System;

namespace Maple2.Trigger._02020062_bf {
    public static class _object3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetUserValue(triggerID: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(arg1: new int[] {12000109}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 1)) {
                    context.State = new State레버3_가이드메시지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_가이드메시지 : TriggerState {
            internal State레버3_가이드메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {723}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {9013})) {
                    context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT3__0$", arg3: new int[] {5000},
                        arg4: "9013");
                    context.State = new State레버3_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_체크 : TriggerState {
            internal State레버3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {713})) {
                    context.State = new State레버3_발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_발동 : TriggerState {
            internal State레버3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetInteractObject(arg1: new int[] {12000109}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT3__1$", arg3: new int[] {5000}, arg4: "9013");
            }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000109}, arg2: 0)) {
                    context.State = new State레버3_몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_몬스터등장 : TriggerState {
            internal State레버3_몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990014, key: "EliteSpawn", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State레버3_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성 : TriggerState {
            internal State레버3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000109}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2) && context.MonsterDead(arg1: new int[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000109}, arg2: 0)) {
                    context.State = new State레버3_재활성_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성_대기 : TriggerState {
            internal State레버3_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "ObjectStart", value: 2) && context.MonsterDead(arg1: new int[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State레버3_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetUserValue(triggerID: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(arg1: new int[] {723}, arg2: false);
                context.SetInteractObject(arg1: new int[] {12000109}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}