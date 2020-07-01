namespace Maple2.Trigger._52000048_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010},
                    arg2: false);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110},
                    arg2: false);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210},
                    arg2: false);
                context.CreateMonster(arg1: new[] {2001});
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
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
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1103, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1104, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1105, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1106, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1107, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1108, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1109, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1110, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1010, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1202, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1203, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1204, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1205, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1206, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1207, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1208, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1209, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1210, arg2: "MS2PatrolData_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State칸두라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라이동 : TriggerState {
            internal State칸두라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_K1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.SetNpcEmotionSequence(arg1: 2001, arg2: "Attack_01_A");
                    context.State = new State칸두라이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라이동2 : TriggerState {
            internal State칸두라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_K2");
                    context.State = new State카메라이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동대기 : TriggerState {
            internal State카메라이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State카메라이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동2 : TriggerState {
            internal State카메라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State라오즈등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈등장 : TriggerState {
            internal State라오즈등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CreateMonster(arg1: new[] {2002});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StatePC말풍선(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선 : TriggerState {
            internal StatePC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000048_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State라오즈대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사01 : TriggerState {
            internal State라오즈대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__1$", arg4: 3);
                context.SetSkip(arg1: "라오즈대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State라오즈대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사01스킵 : TriggerState {
            internal State라오즈대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State라오즈대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사02 : TriggerState {
            internal State라오즈대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__2$", arg4: 6);
                context.SetSkip(arg1: "라오즈대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State라오즈대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사02스킵 : TriggerState {
            internal State라오즈대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State라오즈대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사03 : TriggerState {
            internal State라오즈대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__3$", arg4: 6);
                context.SetSkip(arg1: "라오즈대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라오즈대사03스킵 : TriggerState {
            internal State라오즈대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State퀘스트완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료 : TriggerState {
            internal State퀘스트완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "MessageThroughAnimar");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: false);
                context.MoveUser(arg1: 52000050, arg2: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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