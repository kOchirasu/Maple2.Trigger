using System;

namespace Maple2.Trigger._02000367_bf {
    public static class _main2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3107, 3108, 3109, 3110, 3111, 3112}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {3115, 3116}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000989}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000990}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000991}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000992}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000993}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000994}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000997}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000998}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1002})) {
                    context.State = new State전투01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[]
                        {21101, 21102, 21103, 21104, 21105, 21106, 21107, 21201, 21202, 21203, 21204, 21205},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {21101, 21102, 21103, 21104, 21105, 21106, 21107, 21201, 21202, 21203, 21204, 21205})) {
                    context.State = new State전투02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3107, 3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000989}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000990}, arg2: 1);
                context.CreateMonster(
                    arg1: new int[]
                        {22101, 22102, 22103, 22104, 22105, 22106, 22107, 22201, 22202, 22203, 22204, 22205, 22206},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {22101, 22102, 22103, 22104, 22105, 22106, 22107, 22201, 22202, 22203, 22204, 22205, 22206})) {
                    context.State = new State전투03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투03 : TriggerState {
            internal State전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3109, 3110}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000991}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000992}, arg2: 1);
                context.CreateMonster(
                    arg1: new int[]
                        {23101, 23102, 23103, 23104, 23105, 23106, 23107, 23108, 23201, 23202, 23203, 23204, 23205},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {23101, 23102, 23103, 23104, 23105, 23106, 23107, 23108, 23201, 23202, 23203, 23204, 23205})) {
                    context.SetMesh(arg1: new int[] {3111, 3112}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new int[] {10000993}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {10000994}, arg2: 1);
                    context.SetUserValue(triggerID: 9999901, key: "main", value: 1);
                    context.State = new State합류대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State합류대기 : TriggerState {
            internal State합류대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "main2", value: 1)) {
                    context.State = new State전투04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투04 : TriggerState {
            internal State전투04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[] {
                        51101, 51102, 51103, 51104, 51105, 51106, 51107, 51108, 51201, 51202, 51203, 51204, 51205, 51206
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    51101, 51102, 51103, 51104, 51105, 51106, 51107, 51108, 51201, 51202, 51203, 51204, 51205, 51206
                })) {
                    context.SetMesh(arg1: new int[] {3115, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new int[] {10000997}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {10000998}, arg2: 1);
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