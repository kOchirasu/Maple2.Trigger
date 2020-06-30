using System;

namespace Maple2.Trigger._02000410_bf {
    public static class _mapskilldebuff {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {444}, arg2: false);
                context.SetSkill(arg1: new int[] {666}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 750, arg2: 1)) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 600)) {
                    context.State = new State1단계_70000103(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 700, arg2: new int[] {0})) {
                    context.State = new State스킬끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_70000103 : TriggerState {
            internal State1단계_70000103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {444}, arg2: true);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 780)) {
                    context.State = new State2단계_70000104(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 700, arg2: new int[] {0})) {
                    context.State = new State스킬끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_70000104 : TriggerState {
            internal State2단계_70000104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {666}, arg2: true);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 900)) {
                    context.State = new State스킬끄기(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 700, arg2: new int[] {0})) {
                    context.State = new State스킬끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬끄기 : TriggerState {
            internal State스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {444}, arg2: false);
                context.SetSkill(arg1: new int[] {666}, arg2: false);
                context.AddBuff(arg1: new int[] {750}, arg2: 50004524, arg3: 1, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
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