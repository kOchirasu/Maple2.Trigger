using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000112_qd {
    public static class _52000112 {
        public class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetActor(triggerId: 231, visible: true, initialSequence: "Closed");
                context.SetEffect(triggerIds: new []{400, 401, 402, 403, 404, 405, 406, 407}, visible: false);
                context.SetMesh(triggerIds: new []{300, 301, 302, 303, 304, 305, 306, 307}, visible: true, arg3: 0, arg4: 1000, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002306}, questStates: new byte[]{2})) {
                    return new State재즈바1층습격_완료가능01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002306}, questStates: new byte[]{1})) {
                    return new State재즈바1층습격_진행중01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002308}, questStates: new byte[]{2})) {
                    return new State재즈바_지하습격_완료가능01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{2})) {
                    return new State쉐도우클로전투_완료Cinematic01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002311}, questStates: new byte[]{3})) {
                    return new State재즈바_지하습격_완료가능01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002308}, questStates: new byte[]{3})) {
                    return new State재즈바_지하습격_완료가능01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002306}, questStates: new byte[]{3})) {
                    return new State재즈바1층습격_완료가능01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_진행중01 : TriggerState {
            internal State재즈바1층습격_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new []{102, 103, 104, 105, 106, 107}, isAutoTargeting: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002306}, questStates: new byte[]{2})) {
                    return new State재즈바1층습격_완료가능01_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능01_b : TriggerState {
            internal State재즈바1층습격_완료가능01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$52000112_QD__52000112__0$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재즈바1층습격_완료가능01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능01 : TriggerState {
            internal State재즈바1층습격_완료가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재즈바1층습격_완료가능02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능02 : TriggerState {
            internal State재즈바1층습격_완료가능02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102, 103, 104, 105, 106, 107});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재즈바1층습격_완료가능03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능03 : TriggerState {
            internal State재즈바1층습격_완료가능03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_shadowClawMove");
                context.AddBalloonTalk(spawnId: 111, msg: "$52000112_QD__52000112__1$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002308}, questStates: new byte[]{1})) {
                    return new State재즈바_지하습격_진행중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_진행중01 : TriggerState {
            internal State재즈바_지하습격_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: true);
                context.SetActor(triggerId: 231, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{200, 209, 204, 205, 210, 206}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002308}, questStates: new byte[]{2})) {
                    return new State재즈바_지하습격_완료가능01_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능01_b : TriggerState {
            internal State재즈바_지하습격_완료가능01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$52000112_QD__52000112__2$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재즈바_지하습격_완료가능01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능01 : TriggerState {
            internal State재즈바_지하습격_완료가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재즈바_지하습격_완료가능02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능02 : TriggerState {
            internal State재즈바_지하습격_완료가능02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(spawnIds: new []{208, 201, 202, 203, 211, 212, 213, 214, 215, 216, 217, 218, 219}, arg2: false);
                context.DestroyMonster(spawnIds: new []{108, 109, 110, 111, 200, 209, 204, 205, 210, 206});
                context.MoveUser(mapId: 52000112, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State재즈바_지하습격_완료가능03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능03 : TriggerState {
            internal State재즈바_지하습격_완료가능03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002311}, questStates: new byte[]{3})) {
                    return new StatePC_로그스거역_진행중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC_로그스거역_진행중01 : TriggerState {
            internal StatePC_로그스거역_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 211, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 212, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 213, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 214, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 215, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 216, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 217, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 218, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 219, sequenceName: "Attack_Idle_A", duration: 15000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002312}, questStates: new byte[]{3})) {
                    return new StatePC_로그스거역_대원들01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002312}, questStates: new byte[]{2})) {
                    return new StatePC_로그스거역_대원들01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002312}, questStates: new byte[]{1})) {
                    return new StatePC_로그스거역_대원들01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC_로그스거역_대원들01 : TriggerState {
            internal StatePC_로그스거역_대원들01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{211, 212, 213, 214, 215, 216, 217, 218, 219});
                context.CreateMonster(spawnIds: new []{220, 221, 222, 223, 224, 225, 226, 227, 228}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{1})) {
                    return new State쉐도우클로전투_진행중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_진행중01 : TriggerState {
            internal State쉐도우클로전투_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228});
                context.SetSound(triggerId: 9000, arg2: true);
                context.DestroyMonster(spawnIds: new []{208});
                context.CreateMonster(spawnIds: new []{229}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{2})) {
                    return new State쉐도우클로전투_완료Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic01 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9000, arg2: false);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{207});
                context.CreateMonster(spawnIds: new []{208}, arg2: false);
                context.MoveUser(mapId: 52000112, portalId: 3);
                context.SetNpcEmotionLoop(spawnId: 208, sequenceName: "Attack_Idle_A", duration: 17500f);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Sit_Down_A", duration: 17500f);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Sit_Down_A", duration: 17500f);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Sit_Down_A", duration: 17500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도우클로전투_완료Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic02 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State쉐도우클로전투_완료Cinematic09(context), arg2: "exit");
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 5000f);
                context.FaceEmotion(spawnId: 0, emotionName: "PC_Pain_86000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로전투_완료Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic03 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3002, 3003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000112_QD__52000112__3$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로전투_완료Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic04 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000112_QD__52000112__4$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도우클로전투_완료Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic05 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 5.5f, interpolator: 2);
                context.CameraSelectPath(pathIds: new []{3004}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Assassin_DarkSight_A"});
                context.SetPcEmotionLoop(sequenceName: "Assassin_DarkSight_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로전투_완료Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic06 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3005, 3006}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Assassin_Enterance_A"});
                context.SetPcEmotionLoop(sequenceName: "Assassin_Enterance_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도우클로전투_완료Cinematic07_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic07_b : TriggerState {
            internal State쉐도우클로전투_완료Cinematic07_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{400, 401, 402, 403, 404, 405, 406, 407}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1700)) {
                    return new State쉐도우클로전투_완료Cinematic07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic07 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3007, 3008}, returnView: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000112_QD__52000112__5$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 208, sequenceName: "Stun_A", duration: 15500f);
                context.SetMesh(triggerIds: new []{300, 301, 302, 303, 304, 305, 306, 307}, visible: false, arg3: 0, arg4: 700, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State쉐도우클로전투_완료Cinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic08 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3009, 3010}, returnView: false);
                context.DestroyMonster(spawnIds: new []{201, 202, 203});
                context.VisibleMyPc(visible: false);
                context.AddCinematicTalk(npcId: 11003185, illustId: "0", script: "$52000112_QD__52000112__6$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로전투_완료Cinematic08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic08_1 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로전투_완료Cinematic09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료Cinematic09 : TriggerState {
            internal State쉐도우클로전투_완료Cinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000111, portalId: 11);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
