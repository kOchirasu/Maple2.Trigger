using System;

namespace Maple2.Trigger._80000015_bonus {
    public static class _train_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3210}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3704, 3705, 3706}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {123})) {
                    context.State = new State아이템체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템체크 : TriggerState {
            internal State아이템체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "itemSpawn", value: 1)) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.WaitTick(waitTick: 200)) {
                    context.CreateItem(arg1: new int[] {9026, 9027, 9028, 9029, 9030, 9031}, arg5: 15);
                    context.SetUserValue(key: "itemSpawn", value: 1);
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1201}, arg2: false);
                context.SetMesh(arg1: new int[] {3200}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.AddBuff(arg1: new int[] {1201}, arg2: 60170051, arg3: 1, arg4: true, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State삼(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼 : TriggerState {
            internal State삼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3706}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이 : TriggerState {
            internal State이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3706}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3705}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State일(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일 : TriggerState {
            internal State일(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3705}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3704}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State출발(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출발 : TriggerState {
            internal State출발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3704}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData1201A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 124, arg2: new int[] {1201})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.DestroyMonster(arg1: new int[] {1201});
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State대기(context);
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