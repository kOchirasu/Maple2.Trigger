using System;

namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_05 {
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
                context.SetCube(IDs: new int[] {5105}, isVisible: false);
                context.SetMesh(
                    arg1: new int[] {
                        31501, 31502, 31503, 31504, 31505, 31506, 31507, 31508, 31509, 31510, 31511, 31512, 31513,
                        31514, 31515, 31516, 31517, 31518, 31519, 31520, 31521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {41501, 41502}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {10002})) {
                    context.SetMesh(
                        arg1: new int[] {
                            31501, 31502, 31503, 31504, 31505, 31506, 31507, 31508, 31509, 31510, 31511, 31512, 31513,
                            31514, 31515, 31516, 31517, 31518, 31519, 31520, 31521
                        }, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                    context.SetMesh(arg1: new int[] {41501, 41502}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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