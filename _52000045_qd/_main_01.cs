using System;

namespace Maple2.Trigger._52000045_qd {
    public static class _main_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateready(context);

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "701", arg2: 110)) {
                    context.SetEffect(arg1: new int[] {7001}, arg2: true);
                    context.State = new Statestart(context);
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
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.AddBuff(arg1: new int[] {701}, arg2: 70000105, arg3: 1);
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$52000045_QD__MAIN_01__0$", arg4: 5);
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204, 205, 206}, arg2: false);
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305, 306}, arg2: false);
                context.CreateMonster(arg1: new int[] {401, 402, 403, 404, 405}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 306, arg2: "MS2PatrolData_2001");
                context.CameraSelectPath(arg1: new int[] {8001, 8002, 8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$52000045_QD__MAIN_01__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.CreateMonster(arg1: new int[] {101}, arg2: false);
                    context.RemoveBuff(arg1: 701, arg2: 70000105);
                    context.CameraSelectPath(arg1: new int[] {8004}, arg2: true);
                    context.DestroyMonster(arg1: new int[] {101});
                    context.DestroyMonster(arg1: new int[] {401, 402, 403, 404, 405});
                    context.SetActor(arg1: 5001, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5002, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5003, arg2: false, arg3: "Idle_A");
                    context.SetProductionUI(arg1: 4);
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEffect(arg1: new int[] {7001}, arg2: false);
                    context.AddBuff(arg1: new int[] {701}, arg2: 70000094, arg3: 1);
                    context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 4000f);
                    context.SetProductionUI(arg1: 1);
                    context.SetProductionUI(arg1: 3);
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.SetPcEmotionSequence(arg1: "Emotion_Failure_Idle_A");
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
                    context.SetEffect(arg1: new int[] {7002}, arg2: true);
                    context.MoveUserPath(arg1: "MS2PatrolData_2002");
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_08 : TriggerState {
            internal Statestart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
                context.CreateMonster(arg1: new int[] {901}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_2003");
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
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$52000045_QD__MAIN_01__2$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_A_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_A_10 : TriggerState {
            internal Statestart_A_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$52000045_QD__MAIN_01__11$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_01__12$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_10 : TriggerState {
            internal Statestart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_01__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetEffect(arg1: new int[] {7003}, arg2: true);
                    context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_2005");
                    context.State = new Statestart_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_11 : TriggerState {
            internal Statestart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {801, 802, 803, 804, 805, 806}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statestart_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_12 : TriggerState {
            internal Statestart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statestart_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_13 : TriggerState {
            internal Statestart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7004}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: true);
                context.CreateMonster(arg1: new int[] {809}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 901, arg2: "Down_Idle_A", arg3: 300000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.ShowGuideSummary(entityID: 25200473, textID: 25200473);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.State = new Statestart_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_14 : TriggerState {
            internal Statestart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {801, 802, 803, 804, 805, 806, 809})) {
                    context.HideGuideSummary(entityID: 25200473);
                    context.State = new Statestart_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_15 : TriggerState {
            internal Statestart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {7701, 7702}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                    context.State = new Statestart_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_17 : TriggerState {
            internal Statestart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 7702, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000045_QD__MAIN_01__4$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_18 : TriggerState {
            internal Statestart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 7701, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000045_QD__MAIN_01__5$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_2006");
                    context.MoveNpc(arg1: 7701, arg2: "MS2PatrolData_7003");
                    context.MoveNpc(arg1: 7702, arg2: "MS2PatrolData_7004");
                    context.State = new Statestart_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_19 : TriggerState {
            internal Statestart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
                    context.State = new Statestart_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_20 : TriggerState {
            internal Statestart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 7701, arg3: "$52000045_QD__MAIN_01__6$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 7702, arg3: "$52000045_QD__MAIN_01__7$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_21 : TriggerState {
            internal Statestart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_01__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_01__9$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_01__10$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Statestart_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_22 : TriggerState {
            internal Statestart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "MeetAgainStriker");
                    context.MoveUser(arg1: 02000138, arg2: 103);
                    context.State = new Statestart_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}