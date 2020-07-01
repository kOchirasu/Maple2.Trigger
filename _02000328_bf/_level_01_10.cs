using System;

namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_10 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(IDs: new int[] {5110}, isVisible: false);
                context.SetMesh(
                    arg1: new int[] {
                        32001, 32002, 32003, 32004, 32005, 32006, 32007, 32008, 32009, 32010, 32011, 32012, 32013,
                        32014, 32015, 32016, 32017, 32018, 32019, 32020, 32021, 32022
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {42001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {10006})) {
                    context.SetMesh(
                        arg1: new int[] {
                            32001, 32002, 32003, 32004, 32005, 32006, 32007, 32008, 32009, 32010, 32011, 32012, 32013,
                            32014, 32015, 32016, 32017, 32018, 32019, 32020, 32021, 32022
                        }, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                    context.SetMesh(arg1: new int[] {42001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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