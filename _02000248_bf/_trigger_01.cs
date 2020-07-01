using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110});
                context.SetEffect(arg1: new int[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 201, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {201})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {798, 799}, arg2: false);
                context.SetTimer(arg1: "89", arg2: 3, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "89")) {
                    context.State = new State공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격 : TriggerState {
            internal State공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: true);
                context.SetEffect(arg1: new int[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000248_BF__TRIGGER_01__0$", arg3: new int[] {5000}, arg4: "0");
                context.SetTimer(arg1: "1", arg2: 9, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103})) {
                    context.State = new State공격1(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격1 : TriggerState {
            internal State공격1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104, 105}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {104, 105})) {
                    context.State = new State공격2(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격2 : TriggerState {
            internal State공격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {106, 107, 108}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {106, 107, 108})) {
                    context.State = new State공격2_2(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격2_2 : TriggerState {
            internal State공격2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {109, 110}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {109, 110})) {
                    context.State = new State공격3(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격3 : TriggerState {
            internal State공격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {114, 115, 116}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {114, 115, 116})) {
                    context.State = new State공격3_2(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격3_2 : TriggerState {
            internal State공격3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111, 112, 113}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112, 113})) {
                    context.State = new State공격3_3(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격3_3 : TriggerState {
            internal State공격3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {117, 118, 119, 120}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {117, 118, 119, 120})) {
                    context.State = new State공격4(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격4 : TriggerState {
            internal State공격4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {121, 122, 123, 124, 125}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {121, 122, 123, 124, 125})) {
                    context.State = new State공격4_2(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격4_2 : TriggerState {
            internal State공격4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {126, 127, 128, 129, 130}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {126, 127, 128, 129, 130})) {
                    context.State = new State공격5(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격5 : TriggerState {
            internal State공격5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {131, 132, 133, 134, 135, 136})) {
                    context.State = new State공격5_2(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격5_2 : TriggerState {
            internal State공격5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {137, 138, 139, 140}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {137, 138, 139, 140})) {
                    context.State = new State공격6(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격6 : TriggerState {
            internal State공격6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {141, 142, 143, 144, 145, 146, 148}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {141, 142, 143, 144, 145, 146, 148})) {
                    context.State = new State공격7(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격7 : TriggerState {
            internal State공격7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {151, 153, 154, 155, 156, 157, 158}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {151, 153, 154, 155, 156, 157, 158})) {
                    context.State = new State공격8(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공격8 : TriggerState {
            internal State공격8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {161, 162, 163, 164, 167, 168, 169, 170}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new int[] {161, 162, 163, 164, 167, 168, 169, 170});
                    context.State = new State끝연출(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {999})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝연출 : TriggerState {
            internal State끝연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001, 8003, 8002}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 4, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000249, arg2: 2);
                context.SetTimer(arg1: "1", arg2: 3, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State2차진입대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차진입대기 : TriggerState {
            internal State2차진입대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}