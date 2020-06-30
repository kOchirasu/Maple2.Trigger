using System;

namespace Maple2.Trigger._52010068_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {20002391},
                    arg3: new byte[] {3})) {
                    context.State = new State틴차이_준타_스폰01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {3})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {2})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {1})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100400},
                    arg3: new byte[] {3})) {
                    context.State = new StateOrde_In_Effect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이_준타_스폰01 : TriggerState {
            internal State틴차이_준타_스폰01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {3})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {2})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {1})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100400},
                    arg3: new byte[] {3})) {
                    context.State = new StateOrde_In_Effect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In_Effect : TriggerState {
            internal StateOrde_In_Effect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateOrde_In(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In : TriggerState {
            internal StateOrde_In(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateOrde_In_Turn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In_Turn : TriggerState {
            internal StateOrde_In_Turn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetNpcRotation(arg1: 101, arg2: -45);
                context.AddCinematicTalk(npcID: 11004033, illustID: "Orde_normal", msg: "$52010068_QD__MAIN__0$",
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateOrde_In_Talk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In_Talk : TriggerState {
            internal StateOrde_In_Talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "IceSphere_A");
                context.AddCinematicTalk(npcID: 11004033, illustID: "Orde_normal", msg: "$52010068_QD__MAIN__1$",
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateOrde_In_Talk_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In_Talk_End : TriggerState {
            internal StateOrde_In_Talk_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateOrde_In_ReTurn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_In_ReTurn : TriggerState {
            internal StateOrde_In_ReTurn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 101, arg2: 360);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {3})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {2})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100420},
                    arg3: new byte[] {1})) {
                    context.State = new StateOrde_Out_Effect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_Out_Effect : TriggerState {
            internal StateOrde_Out_Effect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Wizard_Teleport_A");
                context.AddBalloonTalk(spawnPointID: 101, msg: "$52010068_QD__MAIN__2$", duration: 2800, delayTick: 0);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateOrde_Out(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOrde_Out : TriggerState {
            internal StateOrde_Out(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출01 : TriggerState {
            internal State챕터10에필로그연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State챕터10에필로그연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출02 : TriggerState {
            internal State챕터10에필로그연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 9,
                    arg2: @"큰 희생이 있었지만, 우리는 $npc:11001698$를 상대로 승리를 얻었다.\n메이플월드를 공격한 그들에게 죄값을 치르게 만든것이다.");
                context.SetSkip(arg1: "챕터10에필로그연출02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출02스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출02스킵 : TriggerState {
            internal State챕터10에필로그연출02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출03 : TriggerState {
            internal State챕터10에필로그연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: @"비록 $npc:11001698$는 무사히 도망쳤지만, \n그녀 스스로의 의지로 도망친것은 아니었다.");
                context.SetSkip(arg1: "챕터10에필로그연출03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출03스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출03스킵 : TriggerState {
            internal State챕터10에필로그연출03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출05 : TriggerState {
            internal State챕터10에필로그연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "오히려 $npc:11001698$는 이번 전투에서 자신의 요새를 잃고 말았다.");
                context.SetSkip(arg1: "챕터10에필로그연출05스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출05스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출05스킵 : TriggerState {
            internal State챕터10에필로그연출05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출05b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출05b : TriggerState {
            internal State챕터10에필로그연출05b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State챕터10에필로그연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출06 : TriggerState {
            internal State챕터10에필로그연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__3$", arg4: 6);
                context.SetOnetimeEffect(id: 2007, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_01_00002007.xml");
                context.SetSkip(arg1: "챕터10에필로그연출06스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출06스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출06스킵 : TriggerState {
            internal State챕터10에필로그연출06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출07 : TriggerState {
            internal State챕터10에필로그연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__4$", arg4: 6);
                context.SetOnetimeEffect(id: 2008, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_02_00002008.xml");
                context.SetSkip(arg1: "챕터10에필로그연출07스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출07스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출07스킵 : TriggerState {
            internal State챕터10에필로그연출07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출08 : TriggerState {
            internal State챕터10에필로그연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__5$", arg4: 9);
                context.SetOnetimeEffect(id: 2009, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_03_00002009.xml");
                context.SetSkip(arg1: "챕터10에필로그연출08스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State챕터10에필로그연출08스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출08스킵 : TriggerState {
            internal State챕터10에필로그연출08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출09 : TriggerState {
            internal State챕터10에필로그연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__6$", arg4: 5);
                context.SetOnetimeEffect(id: 2009, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_03_00002009.xml");
                context.SetSkip(arg1: "챕터10에필로그연출9스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출9스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출9스킵 : TriggerState {
            internal State챕터10에필로그연출9스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출10 : TriggerState {
            internal State챕터10에필로그연출10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__7$", arg4: 5);
                context.SetOnetimeEffect(id: 2010, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_04_00002010.xml");
                context.SetSkip(arg1: "챕터10에필로그연출10스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출10스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출10스킵 : TriggerState {
            internal State챕터10에필로그연출10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출11 : TriggerState {
            internal State챕터10에필로그연출11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__8$", arg4: 5);
                context.SetOnetimeEffect(id: 2011, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_05_00002011.xml");
                context.SetSkip(arg1: "챕터10에필로그연출11스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출11스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출11스킵 : TriggerState {
            internal State챕터10에필로그연출11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출12 : TriggerState {
            internal State챕터10에필로그연출12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__9$", arg4: 5);
                context.SetOnetimeEffect(id: 2011, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_05_00002011.xml");
                context.SetSkip(arg1: "챕터10에필로그연출12스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출12스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출12스킵 : TriggerState {
            internal State챕터10에필로그연출12스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13 : TriggerState {
            internal State챕터10에필로그연출13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__10$", arg4: 5);
                context.SetOnetimeEffect(id: 2011, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_05_00002011.xml");
                context.SetSkip(arg1: "챕터10에필로그연출13스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출13스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13스킵 : TriggerState {
            internal State챕터10에필로그연출13스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출13_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13_b : TriggerState {
            internal State챕터10에필로그연출13_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__11$", arg4: 5);
                context.SetOnetimeEffect(id: 2012, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_06_00002012.xml");
                context.SetSkip(arg1: "챕터10에필로그연출13b스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State챕터10에필로그연출13b스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출13b스킵 : TriggerState {
            internal State챕터10에필로그연출13b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출14 : TriggerState {
            internal State챕터10에필로그연출14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__12$", arg4: 5);
                context.SetOnetimeEffect(id: 2013, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_07_00002013.xml");
                context.SetSkip(arg1: "챕터10에필로그연출14스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출14스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출14스킵 : TriggerState {
            internal State챕터10에필로그연출14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출15 : TriggerState {
            internal State챕터10에필로그연출15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__13$", arg4: 6);
                context.SetOnetimeEffect(id: 2014, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_08_00002014.xml");
                context.SetSkip(arg1: "챕터10에필로그연출15스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State챕터10에필로그연출15스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출15스킵 : TriggerState {
            internal State챕터10에필로그연출15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출16 : TriggerState {
            internal State챕터10에필로그연출16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52010068_QD__MAIN__14$", arg4: 5);
                context.SetOnetimeEffect(id: 2015, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter10_End_09_00002015.xml");
                context.SetSkip(arg1: "챕터10에필로그연출16스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State챕터10에필로그연출16스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출16스킵 : TriggerState {
            internal State챕터10에필로그연출16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출17 : TriggerState {
            internal State챕터10에필로그연출17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State챕터10에필로그연출18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18 : TriggerState {
            internal State챕터10에필로그연출18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: @"$npc:11001698$는 그녀의 용을 타고 날아올랐다\n그리고 이 것이 마드라칸 요새의 최후였다.");
                context.SetSkip(arg1: "챕터10에필로그연출18스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출18스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18스킵 : TriggerState {
            internal State챕터10에필로그연출18스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출18b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18b : TriggerState {
            internal State챕터10에필로그연출18b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9,
                    arg2: @"$npc:11001698$는 분명 다시 돌아올 것이다.\n그리고 또다시 서로에게 소중한 존재들을 빼앗을지도 모른다.");
                context.SetSkip(arg1: "챕터10에필로그연출18b스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출18b스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출18b스킵 : TriggerState {
            internal State챕터10에필로그연출18b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출19 : TriggerState {
            internal State챕터10에필로그연출19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9,
                    arg2: @"그렇지만, 할 수 있다면 $npc:11001698$와 싸우지 않아도 될 방법을 찾고자 한다.\n복수의 나선은 결국 서로의 모든것을 파괴할것이기 때문이다.");
                context.SetSkip(arg1: "챕터10에필로그연출19스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출19스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출19스킵 : TriggerState {
            internal State챕터10에필로그연출19스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출20 : TriggerState {
            internal State챕터10에필로그연출20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9,
                    arg2: @"그리고 나는 어떤 방법으로든 테룬칼리브들이 살아있다고 굳게 믿고 있다.\n그들이 나를 살렸듯 그들 스스로 어떻게 살아날 방법을 찾았을거라 믿고 싶다.");
                context.SetSkip(arg1: "챕터10에필로그연출20스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출20스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출20스킵 : TriggerState {
            internal State챕터10에필로그연출20스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State챕터10에필로그연출21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출21 : TriggerState {
            internal State챕터10에필로그연출21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9,
                    arg2: @"하여, 나는 블랙 샤드의 폭심지, '아이 오브 라펜타'의 수색과\n라펜샤드의 조사에 최선을 다할 것이라고 다짐했다.");
                context.SetSkip(arg1: "챕터10에필로그연출22");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State챕터10에필로그연출22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State챕터10에필로그연출22 : TriggerState {
            internal State챕터10에필로그연출22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52010068, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}