using System;

namespace Maple2.Trigger._99999841 {
    public static class _boss_hp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonVariable(varID: 200, value: true)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 70, spawnPointId: 911, isRelative: "true")) {
                    context.State = new State70프로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State70프로 : TriggerState {
            internal State70프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 210, value: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 911, isRelative: "true")) {
                    context.State = new State50프로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50프로 : TriggerState {
            internal State50프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 220, value: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 30, spawnPointId: 911, isRelative: "true")) {
                    context.State = new State30프로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State30프로 : TriggerState {
            internal State30프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 230, value: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 10, spawnPointId: 911, isRelative: "true")) {
                    context.State = new State10프로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10프로 : TriggerState {
            internal State10프로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 240, value: true);
            }

            public override void Execute() {
                if (true) {
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