namespace Maple2.Trigger._52000049_qd {
    public static class _main_01 {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {8099}, arg2: false);
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
                context.SetMesh(arg1: new[] {2116, 2201, 2202, 2203, 2204, 2205, 2206}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {1})) {
                    context.State = new Statestart(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {2})) {
                    context.State = new Statestart_23(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {3})) {
                    context.State = new Statestart_23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.CameraSelectPath(arg1: new[] {8001, 8002, 8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7012}, arg2: true);
                context.SetMesh(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115}, arg2: false, arg3: 0, arg4: 100, arg5: 8f);
                context.SetMesh(arg1: new[] {2116}, arg2: true, arg3: 0, arg4: 100, arg5: 3f);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7012}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000049_QD__MAIN_01__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__3$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Event_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.DestroyMonster(arg1: new[] {301, 302, 303, 304, 305, 306});
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006}, arg2: true);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_08 : TriggerState {
            internal Statestart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.CameraSelectPath(arg1: new[] {8005, 8006, 8007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__4$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_09 : TriggerState {
            internal Statestart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000049_QD__MAIN_01__5$", arg4: 3, arg5: 0);
                context.SetPcEmotionSequence(arg1: "Emotion_Failure_A,Emotion_Failure_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_10 : TriggerState {
            internal Statestart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000049_QD__MAIN_01__6$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Emotion_Failure_Idle_A", arg2: 6000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_11 : TriggerState {
            internal Statestart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__7$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Event_A");
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_12 : TriggerState {
            internal Statestart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001761, arg3: "$52000049_QD__MAIN_01__8$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_D");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_13 : TriggerState {
            internal Statestart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7010}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2011");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2012");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2013");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_2015");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_2016");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_14 : TriggerState {
            internal Statestart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: true);
                context.SetPcEmotionSequence(arg1: "Emotion_Failure_A,Emotion_Failure_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_15 : TriggerState {
            internal Statestart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Emotion_Failure_Idle_A", arg2: 18000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_16 : TriggerState {
            internal Statestart_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_17 : TriggerState {
            internal Statestart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {501}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8010, 8011, 8012}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.SetSkill(arg1: new[] {8099}, arg2: true);
                    context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2021");
                    context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2022");
                    context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2023");
                    context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_2024");
                    context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_2025");
                    context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_2026");
                    context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_B");
                    context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_B");
                    context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_B");
                    context.SetNpcEmotionSequence(arg1: 204, arg2: "Bore_B");
                    context.SetNpcEmotionSequence(arg1: 205, arg2: "Bore_B");
                    context.SetNpcEmotionSequence(arg1: 206, arg2: "Bore_B");
                    context.State = new Statestart_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_18 : TriggerState {
            internal Statestart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(arg1: new[] {7010}, arg2: false);
                    context.DestroyMonster(arg1: new[] {201, 202, 203, 204, 205, 206});
                    context.State = new Statestart_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_19 : TriggerState {
            internal Statestart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_2030");
                context.SetConversation(arg1: 1, arg2: 501, arg3: "$52000049_QD__MAIN_01__9$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000049_QD__MAIN_01__10$", arg4: 3, arg5: 0);
                    context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2099");
                    context.State = new Statestart_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_20 : TriggerState {
            internal Statestart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "HeroJunta");
                    context.SetMesh(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115}, arg2: true, arg3: 0, arg4: 100, arg5: 8f);
                    context.DestroyMonster(arg1: new[] {101});
                    context.CameraSelectPath(arg1: new[] {8013}, arg2: true);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.State = new Statestart_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_21 : TriggerState {
            internal Statestart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {501});
                    context.CreateMonster(arg1: new[] {502}, arg2: false);
                    context.State = new Statestart_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_22 : TriggerState {
            internal Statestart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003054}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 52000050, arg2: 1);
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_23 : TriggerState {
            internal Statestart_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {502}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}