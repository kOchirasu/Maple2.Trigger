using System;

namespace Maple2.Trigger._02020061_bf {
    public static class _boss_object4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetUserValue(triggerID: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new int[] {714, 724});
                context.SetInteractObject(arg1: new int[] {12000097}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 1)) {
                    context.State = new State레버4_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_체크 : TriggerState {
            internal State레버4_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {724}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {714})) {
                    context.State = new State레버4_발동(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_발동 : TriggerState {
            internal State레버4_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5301}, arg2: true);
                context.SetInteractObject(arg1: new int[] {12000097}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000097}, arg2: 0)) {
                    context.State = new State레버4_안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_안내 : TriggerState {
            internal State레버4_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State레버4_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_재활성 : TriggerState {
            internal State레버4_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000097}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000097}, arg2: 0)) {
                    context.State = new State레버4_재활성_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_재활성_대기 : TriggerState {
            internal State레버4_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BossObjectStart", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State레버4_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetUserValue(triggerID: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new int[] {714, 724});
                context.SetInteractObject(arg1: new int[] {12000097}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}