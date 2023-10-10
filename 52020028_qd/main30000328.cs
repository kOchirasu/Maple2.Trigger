using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020028_qd {
    public static class _main30000328 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{30000328}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020028, portalId: 6002);
                context.SetOnetimeEffect(id: 1000, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아크로폴리스내부확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아크로폴리스내부확인 : TriggerState {
            internal State아크로폴리스내부확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "아크로폴리스", script: "고대 크리티아스 지식의 안식처", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.CameraSelectPath(pathIds: new []{4002, 4003, 4004}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "여기가 아크로폴리스...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012, 4001}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 0, script: "생각보다 조용하군.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "수호자 때문에 안에 들어갈 수가 없다니, 얼마나 대단한 녀석인거지.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "싸우지 않을 수 있었으면 좋겠는데.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "그나저나, 정말 아무도 없는 것 같은데...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State유저자격확인하기전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저자격확인하기전 : TriggerState {
            internal State유저자격확인하기전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_panic");
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 6000f);
                context.AddBalloonTalk(spawnId: 0, msg: "?!", duration: 3000);
                context.AddBalloonTalk(spawnId: 0, msg: "이... 이건?", duration: 3000, delayTick: 3000);
                context.SetSceneSkip(state: new State경고(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State유저자격확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저자격확인 : TriggerState {
            internal State유저자격확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "침입자 발견. 자격을 확인한다.", arg3: false);
                context.SetSceneSkip(state: new State아르케온Spawn4(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유저자격확인2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저자격확인2 : TriggerState {
            internal State유저자격확인2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_panic");
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 18000f);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "자격을 확인한다고? 잠깐!!!", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유저자격확인2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저자격확인2_1 : TriggerState {
            internal State유저자격확인2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 22000117, script: @"문답무용.\n순수한 크리티아스의 피가 흐르지 않는 자는 이곳에 발을 디딜 수 없다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유저자격확인3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저자격확인3 : TriggerState {
            internal State유저자격확인3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.AddBalloonTalk(spawnId: 0, msg: "잠시 이야기를 들어줘!", duration: 3000, delayTick: 4000);
                context.AddCinematicTalk(npcId: 22000117, script: "결과를 확인한다.", duration: 3000);
                context.AddCinematicTalk(npcId: 22000117, script: @"결과, 부적합.\n전투 시스템 가동.", duration: 3000);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아르케온Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온Spawn : TriggerState {
            internal State아르케온Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: false);
                context.SetOnetimeEffect(id: 1000, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 22000117, script: "자격이 없는 자, 즉시 처단한다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르케온Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온Spawn2 : TriggerState {
            internal State아르케온Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.AddBalloonTalk(spawnId: 0, msg: "아니 대화가 전혀 안 통하잖아!", duration: 2000, delayTick: 0);
                context.SetOnetimeEffect(id: 1000, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State경고(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경고 : TriggerState {
            internal State경고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawnCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnCinematic : TriggerState {
            internal StateSpawnCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1000, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "아르케온", script: "아크로폴리스의 수호자", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.SetOnetimeEffect(id: 1001, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르케온Spawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온Spawn3 : TriggerState {
            internal State아르케온Spawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "역시 이렇게 되는군.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: @"말이 통하지 않으니, 어쩔 수 없지.\n여기서 시간을 낭비할 수 없어.\n어서 처치하자.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아르케온Spawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온Spawn4 : TriggerState {
            internal State아르케온Spawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1001, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "수호자 아르케온을 처치하세요.", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateNextStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextStartCinematic : TriggerState {
            internal StateNextStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNextStartCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextStartCinematic_02 : TriggerState {
            internal StateNextStartCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020028, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State위치이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위치이동 : TriggerState {
            internal State위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "휴... 힘든 싸움이었어.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "중요한 시설인가보군, 이런 괴물같은 녀석이 지키고 있는 것을 보니...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State진리의문확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진리의문확인 : TriggerState {
            internal State진리의문확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004, 4003}, returnView: false);
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.AddCinematicTalk(npcId: 0, script: "아무래도 저기가 진리의 문인가 보군.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "아르망에게 전달해야겠어. 알케이나 고원으로 돌아가자.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State이오네독백Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이오네독백Prepare : TriggerState {
            internal State이오네독백Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이오네독백Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이오네독백Prepare_02 : TriggerState {
            internal State이오네독백Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.CameraSelect(triggerId: 4011, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이오네독백(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이오네독백 : TriggerState {
            internal State이오네독백(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011, 4008}, returnView: false);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "이오네", script: "크리티아스의 왕녀", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003760, script: "그 동안 수고 했어요. 아르케온.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State이오네독백_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이오네독백_02 : TriggerState {
            internal State이오네독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003760, script: "이 뒤는 저에게 맡기고 편히 쉬세요.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003760, script: @"이제 이 곳의 모든 정보는 그 누구도 열어보지 못하도록...\n이 이오네가 책임지고 막겠습니다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWarpPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarpPrepare : TriggerState {
            internal StateWarpPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02020016, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
