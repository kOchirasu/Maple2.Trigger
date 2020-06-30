using System;

namespace Maple2.Trigger._52020028_qd {
    public static class _main30000328 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {30000328},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020028, arg2: 6002);
                context.SetOnetimeEffect(id: 1000, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아크로폴리스내부확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아크로폴리스내부확인 : TriggerState {
            internal State아크로폴리스내부확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "아크로폴리스", desc: "고대 크리티아스 지식의 안식처",
                    align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.CameraSelectPath(arg1: new int[] {4002, 4003, 4004}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "여기가 아크로폴리스...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012, 4001}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcID: 0, msg: "생각보다 조용하군.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "수호자 때문에 안에 들어갈 수가 없다니, 얼마나 대단한 녀석인거지.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "싸우지 않을 수 있었으면 좋겠는데.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "그나저나, 정말 아무도 없는 것 같은데...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State유저자격확인하기전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저자격확인하기전 : TriggerState {
            internal State유저자격확인하기전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Trigger_panic");
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 6000f);
                context.AddBalloonTalk(spawnPointID: 0, msg: "?!", duration: 3000);
                context.AddBalloonTalk(spawnPointID: 0, msg: "이... 이건?", duration: 3000, delayTick: 3000);
                context.SetSceneSkip(arg1: "경고", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State유저자격확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저자격확인 : TriggerState {
            internal State유저자격확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "침입자 발견. 자격을 확인한다.", arg3: false);
                context.SetSceneSkip(arg1: "아르케온등장4", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저자격확인2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저자격확인2 : TriggerState {
            internal State유저자격확인2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Trigger_panic");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 18000f);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "자격을 확인한다고? 잠깐!!!", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저자격확인2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저자격확인2_1 : TriggerState {
            internal State유저자격확인2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 22000117, msg: @"문답무용.\n순수한 크리티아스의 피가 흐르지 않는 자는 이곳에 발을 디딜 수 없다.",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저자격확인3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저자격확인3 : TriggerState {
            internal State유저자격확인3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 0, msg: "잠시 이야기를 들어줘!", duration: 3000, delayTick: 4000);
                context.AddCinematicTalk(npcID: 22000117, msg: "결과를 확인한다.", duration: 3000);
                context.AddCinematicTalk(npcID: 22000117, msg: @"결과, 부적합.\n전투 시스템 가동.", duration: 3000);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State아르케온등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온등장 : TriggerState {
            internal State아르케온등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetOnetimeEffect(id: 1000, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcID: 22000117, msg: "자격이 없는 자, 즉시 처단한다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아르케온등장2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온등장2 : TriggerState {
            internal State아르케온등장2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 0, msg: "아니 대화가 전혀 안 통하잖아!", duration: 2000, delayTick: 0);
                context.SetOnetimeEffect(id: 1000, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State경고(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경고 : TriggerState {
            internal State경고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State등장연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State등장연출 : TriggerState {
            internal State등장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1000, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "아르케온", desc: "아크로폴리스의 수호자", align: "centerLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.SetOnetimeEffect(id: 1001, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아르케온등장3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온등장3 : TriggerState {
            internal State아르케온등장3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "역시 이렇게 되는군.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: @"말이 통하지 않으니, 어쩔 수 없지.\n여기서 시간을 낭비할 수 없어.\n어서 처치하자.",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State아르케온등장4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온등장4 : TriggerState {
            internal State아르케온등장4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1001, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "수호자 아르케온을 처치하세요.", arg3: new int[] {2000}, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State다음연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음연출시작 : TriggerState {
            internal State다음연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State다음연출시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음연출시작_02 : TriggerState {
            internal State다음연출시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020028, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State위치이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위치이동 : TriggerState {
            internal State위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 0, msg: "휴... 힘든 싸움이었어.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "중요한 시설인가보군, 이런 괴물같은 녀석이 지키고 있는 것을 보니...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State진리의문확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진리의문확인 : TriggerState {
            internal State진리의문확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004, 4003}, arg2: 0);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "아무래도 저기가 진리의 문인가 보군.", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "아르망에게 전달해야겠어. 알케이나 고원으로 돌아가자.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State이오네독백준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이오네독백준비 : TriggerState {
            internal State이오네독백준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이오네독백준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이오네독백준비_02 : TriggerState {
            internal State이오네독백준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CameraSelect(arg1: 4011, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이오네독백(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이오네독백 : TriggerState {
            internal State이오네독백(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011, 4008}, arg2: 0);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "이오네", desc: "크리티아스의 왕녀", align: "centerLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.AddCinematicTalk(npcID: 11003760, msg: "그 동안 수고 했어요. 아르케온.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State이오네독백_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이오네독백_02 : TriggerState {
            internal State이오네독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003760, msg: "이 뒤는 저에게 맡기고 편히 쉬세요.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003760, msg: @"이제 이 곳의 모든 정보는 그 누구도 열어보지 못하도록...\n이 이오네가 책임지고 막겠습니다.",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateWarp준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWarp준비 : TriggerState {
            internal StateWarp준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWarp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02020016, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}