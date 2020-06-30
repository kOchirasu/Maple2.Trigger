using System;

namespace Maple2.Trigger._99999942 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateNone(context);

        private class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: "WaterGunBattle", reset: true);
                context.FieldGameConstant(key: "WaitUserTick", value: "15000");
                context.FieldGameConstant(key: "WaitPlayTick", value: "5000");
                context.FieldGameConstant(key: "ResizeWaitTick", value: "15000,15000,15000,15000");
                context.FieldGameConstant(key: "ResizeWarningTick", value: "5000,5000,5000,5000");
                context.FieldGameConstant(key: "SkillSetID", value: "99930047");
                context.FieldGameConstant(key: "MinPlayer", value: "2");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "WaitUser", value: 1)) {
                    context.State = new State유저대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저대기중 : TriggerState {
            internal State유저대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "MoveUser", value: 1)) {
                    context.State = new State유저이동(context);
                    return;
                }

                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5, arg3: false, arg4: true);
                context.MoveUser(arg1: 99999942, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Play", value: 1)) {
                    context.State = new State게임시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "PlayRound1", value: 1)) {
                    context.State = new State라운드1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드1 : TriggerState {
            internal State라운드1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "PlayRound2", value: 1)) {
                    context.State = new State라운드2(context);
                    return;
                }

                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드2 : TriggerState {
            internal State라운드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28
                    }, arg2: false, arg3: 2, arg4: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "PlayRound3", value: 1)) {
                    context.State = new State라운드3(context);
                    return;
                }

                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드3 : TriggerState {
            internal State라운드3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48},
                    arg2: false, arg3: 2, arg4: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "PlayRound4", value: 1)) {
                    context.State = new State라운드4(context);
                    return;
                }

                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드4 : TriggerState {
            internal State라운드4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60}, arg2: false, arg3: 2,
                    arg4: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64
                    }, arg2: true, arg3: 0, arg4: 0);
                context.MoveUser(arg1: 99999942, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}