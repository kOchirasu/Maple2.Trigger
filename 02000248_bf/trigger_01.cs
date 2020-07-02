using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110});
                context.SetEffect(arg1: new[] {2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 201) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {201})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {798, 799}, arg2: false);
                context.SetTimer(arg1: "89", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "89")) {
                    return new State공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격 : TriggerState {
            internal State공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: true);
                context.SetEffect(arg1: new[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000248_BF__TRIGGER_01__0$", arg3: 5000, arg4: "0");
                context.SetTimer(arg1: "1", arg2: 9, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    return new State공격1(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격1 : TriggerState {
            internal State공격1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104, 105}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {104, 105})) {
                    return new State공격2(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격2 : TriggerState {
            internal State공격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {106, 107, 108}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {106, 107, 108})) {
                    return new State공격2_2(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격2_2 : TriggerState {
            internal State공격2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109, 110}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {109, 110})) {
                    return new State공격3(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3 : TriggerState {
            internal State공격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114, 115, 116}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {114, 115, 116})) {
                    return new State공격3_2(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3_2 : TriggerState {
            internal State공격3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 112, 113}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113})) {
                    return new State공격3_3(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3_3 : TriggerState {
            internal State공격3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {117, 118, 119, 120}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {117, 118, 119, 120})) {
                    return new State공격4(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격4 : TriggerState {
            internal State공격4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125})) {
                    return new State공격4_2(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격4_2 : TriggerState {
            internal State공격4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {126, 127, 128, 129, 130}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {126, 127, 128, 129, 130})) {
                    return new State공격5(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격5 : TriggerState {
            internal State공격5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136})) {
                    return new State공격5_2(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격5_2 : TriggerState {
            internal State공격5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {137, 138, 139, 140}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {137, 138, 139, 140})) {
                    return new State공격6(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격6 : TriggerState {
            internal State공격6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {141, 142, 143, 144, 145, 146, 148}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {141, 142, 143, 144, 145, 146, 148})) {
                    return new State공격7(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격7 : TriggerState {
            internal State공격7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {151, 153, 154, 155, 156, 157, 158}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {151, 153, 154, 155, 156, 157, 158})) {
                    return new State공격8(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격8 : TriggerState {
            internal State공격8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {161, 162, 163, 164, 167, 168, 169, 170}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {161, 162, 163, 164, 167, 168, 169, 170});
                    return new State끝연출(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝연출 : TriggerState {
            internal State끝연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8001, 8003, 8002}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 4, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000249, arg2: 2);
                context.SetTimer(arg1: "1", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State2차진입대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차진입대기 : TriggerState {
            internal State2차진입대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}