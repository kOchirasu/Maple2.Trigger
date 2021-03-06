using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020031_qd {
    public static class _main30000332 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {30000332}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_02 : TriggerState {
            internal StateStartCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(arg1: 52020031, arg2: 6002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제단보여주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단보여주기 : TriggerState {
            internal State제단보여주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4005, 4001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "천공의 제단", script: "천공의 심장의 보관소", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.SetSceneSkip(state: new State끝(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateNext스타트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext스타트 : TriggerState {
            internal StateNext스타트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 0, script: "이곳이 천공의 심장이 보관되어 있다는 곳이구나.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State제단확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단확인 : TriggerState {
            internal State제단확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {4005, 4009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제단관찰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단관찰 : TriggerState {
            internal State제단관찰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "누군가 이미 들어온 흔적이 있어 보였는데... 기분 탓인가...", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "저 벽에 있는 장치에 천공의 심장이 보관 되어있는 거겠지?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State제단관찰_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단관찰_02 : TriggerState {
            internal State제단관찰_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4011}, arg2: false);
                context.AddCinematicTalk(npcId: 0, script: "...어라? 천공의 심장으로 보이는 물건이 없는 것 같은데... ", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제단관찰_02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단관찰_02_1 : TriggerState {
            internal State제단관찰_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제단관찰_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단관찰_03 : TriggerState {
            internal State제단관찰_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제단관찰_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단관찰_04 : TriggerState {
            internal State제단관찰_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "가까이 가봐도 되려나..?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부시럭(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부시럭 : TriggerState {
            internal State부시럭(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부시럭_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부시럭_02 : TriggerState {
            internal State부시럭_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003756, script: "어머? 이게 누구야?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌발견01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌발견01 : TriggerState {
            internal State하렌발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4006, 4007}, arg2: false);
                context.AddCinematicTalk(npcId: 11003756, script: "설마 했는데... 너였구나?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌발견01_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌발견01_2 : TriggerState {
            internal State하렌발견01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State하렌발견01_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌발견01_3 : TriggerState {
            internal State하렌발견01_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003756, script: "많이 늦었네?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State하렌발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌발견02 : TriggerState {
            internal State하렌발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.1f);
                context.AddCinematicTalk(npcId: 0, script: "아니, 너는?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌발견03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌발견03 : TriggerState {
            internal State하렌발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4010}, arg2: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "하렌", script: "흑성회의 제 3 간부", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003756, script: "...이렇게 만나다니 우연이네.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003756, script: "혼자 이것저것 하기 힘들지? 후후.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020031, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State하렌Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌Spawn2 : TriggerState {
            internal State하렌Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Music_Cello_Play_03_A");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 3000f);
                context.AddCinematicTalk(npcId: 0, script: "어떻게 여기에... 네가?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "MeetHaren");
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {101});
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State끝02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝02 : TriggerState {
            internal State끝02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {101});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}