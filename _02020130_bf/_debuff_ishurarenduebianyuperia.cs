using System;

namespace Maple2.Trigger._02020130_bf {
    public static class _debuff_ishurarenduebianyuperia {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraFirstSetEnd", value: 0);
                context.SetUserValue(key: "RenduebianFirstSetEnd", value: 0);
                context.SetUserValue(key: "YuperiaFirstSetEnd", value: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 601, arg2: 1)) {
                    context.State = new State1셋트전투판스킬트리거셋팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1셋트전투판스킬트리거셋팅 : TriggerState {
            internal State1셋트전투판스킬트리거셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {1301}, arg2: true);
                context.SetSkill(arg1: new int[] {1302}, arg2: true);
                context.SetSkill(arg1: new int[] {1303}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 310)) {
                    context.State = new State1셋트전투판마무리신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1셋트전투판마무리신호대기 : TriggerState {
            internal State1셋트전투판마무리신호대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "IshuraFirstSetEnd", value: 1)) {
                    context.State = new State이슈라_디버프스킬끄기(context);
                    return;
                }

                if (context.UserValue(key: "RenduebianFirstSetEnd", value: 1)) {
                    context.State = new State렌듀비앙_디버프스킬끄기(context);
                    return;
                }

                if (context.UserValue(key: "YuperiaFirstSetEnd", value: 1)) {
                    context.State = new State유페리아_디버프스킬끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라_디버프스킬끄기 : TriggerState {
            internal State이슈라_디버프스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraFirstSetEnd", value: 0);
                context.SetSkill(arg1: new int[] {1301}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    context.State = new State1셋트전투판마무리신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙_디버프스킬끄기 : TriggerState {
            internal State렌듀비앙_디버프스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RenduebianFirstSetEnd", value: 0);
                context.SetSkill(arg1: new int[] {1302}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    context.State = new State1셋트전투판마무리신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아_디버프스킬끄기 : TriggerState {
            internal State유페리아_디버프스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "YuperiaFirstSetEnd", value: 0);
                context.SetSkill(arg1: new int[] {1303}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    context.State = new State1셋트전투판마무리신호대기(context);
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