namespace Maple2.Trigger._52100101_qd {
    public static class _52100101 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Dead_A");
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Dead_B");
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Dead_A");
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Dead_B");
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Dead_A");
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Dead_B");
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 107, sequenceName: "Dead_B");
                context.CreateMonster(spawnIds: new []{108}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 108, sequenceName: "Dead_A");
                context.CreateMonster(spawnIds: new []{114}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 114, sequenceName: "Sit_Down_A", duration: 9999999999f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100860}, questStates: new byte[]{2})) {
                    return new StateWait_01_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{50100870}, questStates: new byte[]{3})) {
                    return new StateWait_01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_01_02_003(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02_003 : TriggerState {
            internal StateWait_01_02_003(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100101, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구릉도착(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구릉도착 : TriggerState {
            internal State구릉도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구릉도착_01_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구릉도착_01_2 : TriggerState {
            internal State구릉도착_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002, 4003}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State구릉도착_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구릉도착_02 : TriggerState {
            internal State구릉도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__0$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State검은군단들(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단들 : TriggerState {
            internal State검은군단들(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__1$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State검은군단들2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단들2 : TriggerState {
            internal State검은군단들2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005, 4007}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__2$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State검은군단들3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검은군단들3 : TriggerState {
            internal State검은군단들3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{50100870}, questStates: new byte[]{3})) {
                    return new StateWait_01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_03 : TriggerState {
            internal StateWait_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_01_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_04 : TriggerState {
            internal StateWait_01_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100101, portalId: 3);
                context.CreateMonster(spawnIds: new []{109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아바라봄(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아바라봄 : TriggerState {
            internal State클라디아바라봄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아바라봄_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아바라봄_02 : TriggerState {
            internal State클라디아바라봄_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__4$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__5$", duration: 3000);
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State게오르크_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크_04 : TriggerState {
            internal State게오르크_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011, 4013}, returnView: false);
                context.MoveNpc(spawnId: 109, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_3004");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_3005");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_3006");
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게오르크_04_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크_04_02 : TriggerState {
            internal State게오르크_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__7$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State게오르크_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크_05 : TriggerState {
            internal State게오르크_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__8$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State게오르크_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크_06 : TriggerState {
            internal State게오르크_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3007");
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__9$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__10$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__11$", duration: 4500);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__12$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16500)) {
                    return new State게오르크_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게오르크_07 : TriggerState {
            internal State게오르크_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__13$", duration: 4500);
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__14$", duration: 4500);
                context.AddCinematicTalk(npcId: 0, script: "$52100101_QD__52100101__15$", duration: 4500);
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__16$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004422, script: "$52100101_QD__52100101__17$", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    return new State잠시후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후 : TriggerState {
            internal State잠시후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State잠시후_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후_2 : TriggerState {
            internal State잠시후_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100101_QD__52100101__18$");
                context.CameraSelectPath(pathIds: new []{4015}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State잠시후_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후_3 : TriggerState {
            internal State잠시후_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{109, 110, 111, 112, 113, 114});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State잠시후_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후_4 : TriggerState {
            internal State잠시후_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State잠시후_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후_5 : TriggerState {
            internal State잠시후_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.AddCinematicTalk(npcId: 11004421, script: "$52100101_QD__52100101__19$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004421, script: "$52100101_QD__52100101__20$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004421, script: "$52100101_QD__52100101__21$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004421, script: "$52100101_QD__52100101__22$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 02020029, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
