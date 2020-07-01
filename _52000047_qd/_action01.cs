using System;

namespace Maple2.Trigger._52000047_qd {
    public static class _action01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetEffect(arg1: new int[] {5207}, arg2: false);
                context.SetEffect(arg1: new int[] {5208}, arg2: false);
                context.SetEffect(arg1: new int[] {5209}, arg2: false);
                context.SetEffect(arg1: new int[] {5210}, arg2: false);
                context.SetEffect(arg1: new int[] {5220}, arg2: false);
                context.SetEffect(arg1: new int[] {5221}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetSkill(arg1: new int[] {7000}, arg2: false);
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetSkill(arg1: new int[] {7002}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017, 3018, 3019, 3020, 3021
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "VasaraTired", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StateLoadingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003044},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003044},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003043},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003043},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003043},
                    arg3: new byte[] {1})) {
                    context.State = new StateLoadingDelay02(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 201, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539},
                    arg2: false);
                context.MoveUser(arg1: 52000047, arg2: 3, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestOnGoing02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing02 : TriggerState {
            internal StateQuestOnGoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.CreateMonster(arg1: new int[] {500, 501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn01 : TriggerState {
            internal StatePCWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 501, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn02 : TriggerState {
            internal StatePCWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 500, arg2: "Talk_A", arg3: 6000f);
                context.SetNpcEmotionSequence(arg1: 507, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkIn03 : TriggerState {
            internal StatePCWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 502, arg2: "Talk_A", arg3: 6000f);
                context.SetNpcEmotionLoop(arg1: 509, arg2: "Talk_A", arg3: 6000f);
                context.SetNpcEmotionSequence(arg1: 503, arg2: "Bore_A");
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice01 : TriggerState {
            internal StateNPCNotice01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 509, arg2: "MS2PatrolData_509");
                context.SetConversation(arg1: 1, arg2: 509, arg3: "$52000047_QD__ACTION01__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice02 : TriggerState {
            internal StateNPCNotice02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_500");
                context.MoveNpc(arg1: 507, arg2: "MS2PatrolData_507");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice03 : TriggerState {
            internal StateNPCNotice03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 504, arg2: "MS2PatrolData_504");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice04 : TriggerState {
            internal StateNPCNotice04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 508, arg2: "MS2PatrolData_508");
                context.SetConversation(arg1: 1, arg2: 504, arg3: "$52000047_QD__ACTION01__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPCNotice05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice05 : TriggerState {
            internal StateNPCNotice05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_501");
                context.MoveNpc(arg1: 506, arg2: "MS2PatrolData_506");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice06 : TriggerState {
            internal StateNPCNotice06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 502, arg2: "MS2PatrolData_502");
                context.MoveNpc(arg1: 505, arg2: "MS2PatrolData_505");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPCNotice07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCNotice07 : TriggerState {
            internal StateNPCNotice07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 503, arg2: "MS2PatrolData_503");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMafiaReadyToFight01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaReadyToFight01 : TriggerState {
            internal StateMafiaReadyToFight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 505, arg3: "$52000047_QD__ACTION01__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMafiaReadyToFight02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaReadyToFight02 : TriggerState {
            internal StateMafiaReadyToFight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.SetPcEmotionSequence(arg1: "Striker_Bore_A");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000047_QD__ACTION01__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMafiaReadyToFight03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaReadyToFight03 : TriggerState {
            internal StateMafiaReadyToFight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
                context.ChangeMonster(arg1: 500, arg2: 900);
                context.ChangeMonster(arg1: 501, arg2: 901);
                context.ChangeMonster(arg1: 502, arg2: 902);
                context.ChangeMonster(arg1: 503, arg2: 903);
                context.ChangeMonster(arg1: 504, arg2: 904);
                context.ChangeMonster(arg1: 505, arg2: 905);
                context.ChangeMonster(arg1: 506, arg2: 906);
                context.ChangeMonster(arg1: 507, arg2: 907);
                context.ChangeMonster(arg1: 508, arg2: 908);
                context.ChangeMonster(arg1: 509, arg2: 909);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateMafiaReadyToFight04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaReadyToFight04 : TriggerState {
            internal StateMafiaReadyToFight04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 504, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateMafiaFightStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaFightStart01 : TriggerState {
            internal StateMafiaFightStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 25200471, textID: 25200471);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {900, 901, 902, 903, 904, 905, 906, 907, 908, 909})) {
                    context.State = new StateMafiaFightEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaFightEnd01 : TriggerState {
            internal StateMafiaFightEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.HideGuideSummary(entityID: 25200471);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeihongWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongWalkIn01 : TriggerState {
            internal StateWeihongWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeihongWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongWalkIn02 : TriggerState {
            internal StateWeihongWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {100}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeihongWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongWalkIn03 : TriggerState {
            internal StateWeihongWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_200");
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.MoveUser(arg1: 52000047, arg2: 2, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeihongTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongTalk01 : TriggerState {
            internal StateWeihongTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$52000047_QD__ACTION01__4$", arg4: 4);
                context.SetSkip(arg1: "WeihongTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateWeihongTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongTalk01Skip : TriggerState {
            internal StateWeihongTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetUserValue(triggerID: 500, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 501, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 502, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 503, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 504, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 505, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 506, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 507, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 508, key: "NpcRemove", value: 1);
                context.SetUserValue(triggerID: 509, key: "NpcRemove", value: 1);
                context.CreateMonster(arg1: new int[] {520, 521, 522, 523, 524, 525, 526, 527, 528, 529}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeihongTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongTalk02 : TriggerState {
            internal StateWeihongTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$52000047_QD__ACTION01__5$", arg4: 4);
                context.SetSkip(arg1: "WeihongTalk02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateWeihongTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongTalk02Skip : TriggerState {
            internal StateWeihongTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMeetAgainWeihong01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetAgainWeihong01 : TriggerState {
            internal StateMeetAgainWeihong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 520, arg2: "MS2PatrolData_520");
                context.MoveNpc(arg1: 521, arg2: "MS2PatrolData_521");
                context.MoveNpc(arg1: 522, arg2: "MS2PatrolData_522");
                context.MoveNpc(arg1: 523, arg2: "MS2PatrolData_523");
                context.MoveNpc(arg1: 524, arg2: "MS2PatrolData_524");
                context.MoveNpc(arg1: 525, arg2: "MS2PatrolData_525");
                context.MoveNpc(arg1: 526, arg2: "MS2PatrolData_526");
                context.MoveNpc(arg1: 527, arg2: "MS2PatrolData_527");
                context.MoveNpc(arg1: 528, arg2: "MS2PatrolData_528");
                context.MoveNpc(arg1: 529, arg2: "MS2PatrolData_529");
                context.SetConversation(arg1: 1, arg2: 520, arg3: "$52000047_QD__ACTION01__6$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMeetAgainWeihong02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetAgainWeihong02 : TriggerState {
            internal StateMeetAgainWeihong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 527, arg3: "$52000047_QD__ACTION01__7$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 529, arg3: "$52000047_QD__ACTION01__8$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMeetAgainWeihong03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetAgainWeihong03 : TriggerState {
            internal StateMeetAgainWeihong03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000047_QD__ACTION01__9$", arg4: 4, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMeetAgainWeihong04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetAgainWeihong04 : TriggerState {
            internal StateMeetAgainWeihong04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMeetAgainWeihong05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetAgainWeihong05 : TriggerState {
            internal StateMeetAgainWeihong05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMeetAgainWeihong06(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {100, 200, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529});
                context.CreateMonster(arg1: new int[] {101, 201, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539},
                    arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateMeetAgainWeihong06 : TriggerState {
            internal StateMeetAgainWeihong06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "MeetAgainWeihong");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {10003044},
                    arg3: new byte[] {1})) {
                    context.State = new StatePositionArrange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange01 : TriggerState {
            internal StatePositionArrange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePositionArrange02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange02 : TriggerState {
            internal StatePositionArrange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 700, arg2: true);
                context.MoveUser(arg1: 52000047, arg2: 3, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePositionArrange03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange03 : TriggerState {
            internal StatePositionArrange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeihongStepBack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongStepBack01 : TriggerState {
            internal StateWeihongStepBack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000047_QD__ACTION01__10$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWeihongStepBack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongStepBack02 : TriggerState {
            internal StateWeihongStepBack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000047_QD__ACTION01__11$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCTryToAttackWeihong01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTryToAttackWeihong01 : TriggerState {
            internal StatePCTryToAttackWeihong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 710, arg2: true);
                context.SetPcEmotionLoop(arg1: "Knuckle_Attack_Idle_A", arg2: 1734f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000047_QD__ACTION01__12$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePCTryToAttackWeihong02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTryToAttackWeihong02 : TriggerState {
            internal StatePCTryToAttackWeihong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 711, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StatePCTryToAttackWeihong03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTryToAttackWeihong03 : TriggerState {
            internal StatePCTryToAttackWeihong03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateVasaraPush01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPush01 : TriggerState {
            internal StateVasaraPush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000047_QD__ACTION01__20$", arg4: 1, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraPush02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPush02 : TriggerState {
            internal StateVasaraPush02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Attack_01_H");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraPush03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPush03 : TriggerState {
            internal StateVasaraPush03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new StateVasaraPush04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPush04 : TriggerState {
            internal StateVasaraPush04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 1500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSceneChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSceneChange01 : TriggerState {
            internal StateSceneChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSceneChange02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSceneChange02 : TriggerState {
            internal StateSceneChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 720, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSceneChange03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSceneChange03 : TriggerState {
            internal StateSceneChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVasaraTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk01 : TriggerState {
            internal StateVasaraTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000047_QD__ACTION01__13$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateVasaraTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk02 : TriggerState {
            internal StateVasaraTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000047_QD__ACTION01__14$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateVasaraTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk03 : TriggerState {
            internal StateVasaraTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000047_QD__ACTION01__15$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateVasaraBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraBattle01 : TriggerState {
            internal StateVasaraBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 720, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVasaraBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraBattle02 : TriggerState {
            internal StateVasaraBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 25200472, textID: 25200472);
            }

            public override void Execute() {
                if (context.UserValue(key: "VasaraTired", value: 1)) {
                    context.State = new StateVasaraBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraBattle03 : TriggerState {
            internal StateVasaraBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.HideGuideSummary(entityID: 25200472);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVasaraTired01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTired01 : TriggerState {
            internal StateVasaraTired01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraTired02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTired02 : TriggerState {
            internal StateVasaraTired02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 720, arg2: true);
                context.MoveUser(arg1: 52000047, arg2: 4, arg3: 9900);
                context.DestroyMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraTired03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTired03 : TriggerState {
            internal StateVasaraTired03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Down_Idle_A", arg3: 9000f);
                context.SetPcEmotionLoop(arg1: "Knuckle_Attack_Idle_A", arg2: 9537f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraTired04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTired04 : TriggerState {
            internal StateVasaraTired04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 600)) {
                    context.State = new StateVasaraTired05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTired05 : TriggerState {
            internal StateVasaraTired05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$52000047_QD__ACTION01__21$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWeihongOrder01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongOrder01 : TriggerState {
            internal StateWeihongOrder01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 730, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeihongOrder02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongOrder02 : TriggerState {
            internal StateWeihongOrder02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$52000047_QD__ACTION01__16$", arg4: 5);
                context.SetSkip(arg1: "WeihongOrder02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWeihongOrder02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeihongOrder02Skip : TriggerState {
            internal StateWeihongOrder02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateMafiaMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaMove01 : TriggerState {
            internal StateMafiaMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 731, arg2: true);
                context.MoveNpc(arg1: 530, arg2: "MS2PatrolData_530");
                context.MoveNpc(arg1: 535, arg2: "MS2PatrolData_535");
                context.MoveNpc(arg1: 534, arg2: "MS2PatrolData_534");
                context.MoveNpc(arg1: 537, arg2: "MS2PatrolData_537");
                context.MoveNpc(arg1: 532, arg2: "MS2PatrolData_532");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateMafiaMove02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaMove02 : TriggerState {
            internal StateMafiaMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 531, arg2: "MS2PatrolData_531");
                context.MoveNpc(arg1: 533, arg2: "MS2PatrolData_533");
                context.MoveNpc(arg1: 536, arg2: "MS2PatrolData_536");
                context.MoveNpc(arg1: 538, arg2: "MS2PatrolData_538");
                context.MoveNpc(arg1: 539, arg2: "MS2PatrolData_539");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk10 : TriggerState {
            internal StateVasaraTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_204");
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$52000047_QD__ACTION01__17$", arg4: 5);
                context.SetSkip(arg1: "VasaraTalk10Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateVasaraTalk10Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk10Skip : TriggerState {
            internal StateVasaraTalk10Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateVasaraPushAgain01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPushAgain01 : TriggerState {
            internal StateVasaraPushAgain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraPushAgain02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPushAgain02 : TriggerState {
            internal StateVasaraPushAgain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_02_G,Attack_03_G");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new StateVasaraPushAgain03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPushAgain03 : TriggerState {
            internal StateVasaraPushAgain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVasaraPushAgain04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraPushAgain04 : TriggerState {
            internal StateVasaraPushAgain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 6000f);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_01_I,Attack_Idle_A,Attack_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new StateVasaraLastAttack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraLastAttack01 : TriggerState {
            internal StateVasaraLastAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7002}, arg2: true);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateVasaraLastAttack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraLastAttack02 : TriggerState {
            internal StateVasaraLastAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5220}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017, 3018, 3019, 3020, 3021
                    }, arg2: true, arg3: 22, arg4: 50, arg5: 80);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetEffect(arg1: new int[] {5204}, arg2: true);
                context.SetEffect(arg1: new int[] {5205}, arg2: true);
                context.SetEffect(arg1: new int[] {5206}, arg2: true);
                context.SetEffect(arg1: new int[] {5207}, arg2: true);
                context.SetEffect(arg1: new int[] {5208}, arg2: true);
                context.SetEffect(arg1: new int[] {5209}, arg2: true);
                context.SetEffect(arg1: new int[] {5210}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVasaraLastAttack03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraLastAttack03 : TriggerState {
            internal StateVasaraLastAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5221}, arg2: true);
                context.CameraSelect(arg1: 731, arg2: true);
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateVasaraTalk20(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5220}, arg2: true);
            }
        }

        private class StateVasaraTalk20 : TriggerState {
            internal StateVasaraTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$52000047_QD__ACTION01__18$", arg4: 5);
                context.SetSkip(arg1: "VasaraTalk20Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateVasaraTalk20Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk20Skip : TriggerState {
            internal StateVasaraTalk20Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateVasaraTalk21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk21 : TriggerState {
            internal StateVasaraTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$52000047_QD__ACTION01__19$", arg4: 5);
                context.SetSkip(arg1: "VasaraTalk21Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateVasaraTalk21Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVasaraTalk21Skip : TriggerState {
            internal StateVasaraTalk21Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 731, arg2: false);
                context.SetEffect(arg1: new int[] {5221}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFriendOfVasara01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendOfVasara01 : TriggerState {
            internal StateFriendOfVasara01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5220}, arg2: true);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "FriendOfVasara");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_205");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5221}, arg2: true);
                context.MoveUser(arg1: 02000138, arg2: 105, arg3: 9900);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}