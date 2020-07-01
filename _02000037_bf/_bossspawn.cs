using System;

namespace Maple2.Trigger._02000037_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000931}, arg2: 2);
                context.SetMesh(arg1: new int[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4040, 4041, 4042, 4043, 4044, 4045, 4046}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4050}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State난이도체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonLevel(level: 2)) {
                    context.State = new State레이드(context);
                    return;
                }

                if (context.DungeonLevel(level: 3)) {
                    context.State = new State카오스레이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이드 : TriggerState {
            internal State레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2000})) {
                    context.State = new State연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카오스레이드 : TriggerState {
            internal State카오스레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.State = new State연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출딜레이 : TriggerState {
            internal State연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000931}, arg2: 1);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000931})) {
                    context.State = new State사념등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사념등장01 : TriggerState {
            internal State사념등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4050}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetRandomMesh(arg1: new int[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009},
                    arg2: true, arg3: 10, arg4: 0, arg5: 50);
                context.SetRandomMesh(arg1: new int[] {4040, 4041, 4042, 4043, 4044, 4045, 4046}, arg2: true, arg3: 7,
                    arg4: 400, arg5: 50);
                context.SetRandomMesh(
                    arg1: new int[]
                        {4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034},
                    arg2: true, arg3: 15, arg4: 800, arg5: 50);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}