namespace Maple2.Trigger._52000032_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Idle_A");
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetEffect(arg1: new[] {602, 603, 604, 605, 606, 607, 608, 609}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State연출시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 2001}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State홀슈타트변신(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트변신 : TriggerState {
            internal State홀슈타트변신(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.AddBuff(arg1: new[] {2002}, arg2: 71000005, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유페리아대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아대사01 : TriggerState {
            internal State유페리아대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "Idle_A");
                context.CameraSelect(arg1: 3022, arg2: true);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, arg3: "$52000032_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유페리아돌진(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아돌진 : TriggerState {
            internal State유페리아돌진(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State카메라전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라전환 : TriggerState {
            internal State카메라전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State이슈라돌진(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이슈라돌진 : TriggerState {
            internal State이슈라돌진(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.CameraSelect(arg1: 3033, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 550)) {
                    return new State홀슈타트어택(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트어택 : TriggerState {
            internal State홀슈타트어택(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.SetEffect(arg1: new[] {604, 602}, arg2: true);
                    return new State화면전환대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면전환대기 : TriggerState {
            internal State화면전환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.DestroyMonster(arg1: new[] {1001, 1003});
                    return new State홀슈타트대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트대사01 : TriggerState {
            internal State홀슈타트대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3034, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001231, arg3: "$52000032_QD__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State홀슈타트이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트이동 : TriggerState {
            internal State홀슈타트이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {2002})) {
                    return new State홀슈타트소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트소멸 : TriggerState {
            internal State홀슈타트소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1101, 1102}, arg2: false);
                context.DestroyMonster(arg1: new[] {2002});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카메라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101}, arg2: 01)) {
                    return new State투입대사10(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 10)) {
                    return new State투입대사10(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 20)) {
                    return new State투입대사20(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 30)) {
                    return new State투입대사30(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 40)) {
                    return new State투입대사40(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 50)) {
                    return new State투입대사50(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 60)) {
                    return new State투입대사60(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 70)) {
                    return new State투입대사70(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 80)) {
                    return new State투입대사80(context);
                }

                if (context.UserDetected(arg1: new[] {101}, arg2: 90)) {
                    return new State투입대사90(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투입대사10 : TriggerState {
            internal State투입대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000032_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사20 : TriggerState {
            internal State투입대사20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001581, arg3: "$52000032_QD__MAIN__5$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사30 : TriggerState {
            internal State투입대사30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State투입대사30_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투입대사30_1 : TriggerState {
            internal State투입대사30_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, arg3: "$52000032_QD__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사40 : TriggerState {
            internal State투입대사40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001578, arg3: "$52000032_QD__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사50 : TriggerState {
            internal State투입대사50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__10$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$52000032_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사60 : TriggerState {
            internal State투입대사60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001583, arg3: "$52000032_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사70 : TriggerState {
            internal State투입대사70(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__14$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001586, arg3: "$52000032_QD__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사80 : TriggerState {
            internal State투입대사80(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__16$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001584, arg3: "$52000032_QD__MAIN__17$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State투입대사90 : TriggerState {
            internal State투입대사90(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__18$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__19$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State누타만전투 : TriggerState {
            internal State누타만전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new State누타만전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State누타만전투종료 : TriggerState {
            internal State누타만전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 305, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State렌듀비앙대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙대사01 : TriggerState {
            internal State렌듀비앙대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1103, 1104}, arg2: false);
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000032_QD__MAIN__20$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유페리아대사_흐느낌(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아대사_흐느낌 : TriggerState {
            internal State유페리아대사_흐느낌(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001576, arg3: "$52000032_QD__MAIN__21$", arg4: 8, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State아노스대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, arg3: "$52000032_QD__MAIN__22$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State렌듀비앙대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙대사02 : TriggerState {
            internal State렌듀비앙대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000032_QD__MAIN__23$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State렌듀비앙이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동 : TriggerState {
            internal State렌듀비앙이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1103, arg2: "MS2PatrolData_1103_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State렌듀비앙캐스팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙캐스팅 : TriggerState {
            internal State렌듀비앙캐스팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1103}, arg2: 71000004, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State포털생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearNutaman");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02000023, arg2: 100);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}