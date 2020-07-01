namespace Maple2.Trigger._52000029_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001, 2001, 1002, 1003, 1004, 1005, 1006}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State구르는천둥대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구르는천둥대사01 : TriggerState {
            internal State구르는천둥대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001581, arg3: "$52000029_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State유페리아대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아대사01 : TriggerState {
            internal State유페리아대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, arg3: "$52000029_QD__MAIN__1$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 3022, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPC이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동2 : TriggerState {
            internal StateNPC이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPC이동3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동3 : TriggerState {
            internal StateNPC이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State카메라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이펙트연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트연출 : TriggerState {
            internal State이펙트연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 71000003, arg3: 1, arg4: true, arg5: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이슈라이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동01 : TriggerState {
            internal State이슈라이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이슈라대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사01 : TriggerState {
            internal State이슈라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000029_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State홀슈타트방향전환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트방향전환 : TriggerState {
            internal State홀슈타트방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State홀슈타트대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트대사01 : TriggerState {
            internal State홀슈타트대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001231, arg3: "$52000029_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State홀슈타트도망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트도망 : TriggerState {
            internal State홀슈타트도망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3055, arg2: true);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이슈라추격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라추격 : TriggerState {
            internal State이슈라추격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1004, 1005, 1006});
                context.CreateMonster(arg1: new[] {1007, 1008, 1009, 1010, 1011, 1101, 1102, 1104, 1105, 1106}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNPC집결(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC집결 : TriggerState {
            internal StateNPC집결(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_B");
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008_B");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_1009_B");
                context.MoveNpc(arg1: 1010, arg2: "MS2PatrolData_1010_B");
                context.MoveNpc(arg1: 1011, arg2: "MS2PatrolData_1011_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State렌듀비앙대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙대사01 : TriggerState {
            internal State렌듀비앙대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000029_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, arg3: "$52000029_QD__MAIN__5$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State제나대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제나대사01 : TriggerState {
            internal State제나대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001583, arg3: "$52000029_QD__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State유페리아대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아대사02 : TriggerState {
            internal State유페리아대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, arg3: "$52000029_QD__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State이슈라대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사02 : TriggerState {
            internal State이슈라대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000029_QD__MAIN__8$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이슈라대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사03 : TriggerState {
            internal State이슈라대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000029_QD__MAIN__9$", arg4: 11, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11500)) {
                    context.State = new State이슈라대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사04 : TriggerState {
            internal State이슈라대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_D");
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000029_QD__MAIN__10$", arg4: 6, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State렌듀비앙대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙대사02 : TriggerState {
            internal State렌듀비앙대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000029_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State렌듀비앙이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동 : TriggerState {
            internal State렌듀비앙이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State렌듀비앙캐스팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙캐스팅 : TriggerState {
            internal State렌듀비앙캐스팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1007}, arg2: 71000004, arg3: 1, arg4: true, arg5: false);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
                context.CameraSelect(arg1: 309, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이슈라대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사05 : TriggerState {
            internal State이슈라대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000029_QD__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 52000030, arg2: 0);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}