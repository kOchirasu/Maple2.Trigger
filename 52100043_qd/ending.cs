using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100043_qd {
    public static class _ending {
        public class StateEnding_Ready : TriggerState {
            internal StateEnding_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{720})) {
                    return new StateEnding_Camera_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Camera_1 : TriggerState {
            internal StateEnding_Camera_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enabled: false);
                context.CameraSelectPath(pathIds: new []{500, 501}, returnView: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005}, visible: false);
                context.SetMesh(triggerIds: new []{4993, 4994, 4995, 4996, 4997, 4998, 4999}, visible: false);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{600, 601, 602}, arg2: false);
                context.SetMesh(triggerIds: new []{4993, 4994, 4995, 4996, 4997, 4998, 4999}, visible: true);
                context.VisibleMyPc(visible: true);
                context.MoveNpc(spawnId: 600, patrolName: "MS2PatrolData0");
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData1");
                context.MoveNpc(spawnId: 602, patrolName: "MS2PatrolData2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnding_Talk_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_1 : TriggerState {
            internal StateEnding_Talk_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateNarration01(context));
                context.CameraSelect(triggerId: 1000, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001566, illustId: "11001566", script: "$52100043_QD__ENDING__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_2 : TriggerState {
            internal StateEnding_Talk_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 1001, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 601, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001567, illustId: "11001567", script: "$52100043_QD__ENDING__1$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_3 : TriggerState {
            internal StateEnding_Talk_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 1002, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 600, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__2$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateShake_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShake_Camera : TriggerState {
            internal StateShake_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.CameraSelectPath(pathIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4005, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4008, 4006, 4007, 4008, 4006, 4007, 4008, 4006, 4007, 4008}, returnView: true);
                context.AddCinematicTalk(npcId: 11001567, illustId: "11001567", script: "$52100043_QD__ENDING__3$", duration: 2000, align: Align.Left);
                context.DestroyMonster(spawnIds: new []{601, 602}, arg2: false);
                context.CreateMonster(spawnIds: new []{701, 702}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_Talk_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_4 : TriggerState {
            internal StateEnding_Talk_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{701, 702}, arg2: false);
                context.DestroyMonster(spawnIds: new []{601, 602});
                context.SetEffect(triggerIds: new []{5000, 5003, 5004, 5005}, visible: true);
                context.AddCinematicTalk(npcId: 11001566, illustId: "11001566", script: "$52100043_QD__ENDING__4$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_Talk_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_5 : TriggerState {
            internal StateEnding_Talk_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7000, 7001}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__5$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State6000_del(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6000_del : TriggerState {
            internal State6000_del(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.DestroyMonster(spawnIds: new []{600});
                context.CreateMonster(spawnIds: new []{700}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnding_Talk_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_6 : TriggerState {
            internal StateEnding_Talk_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.CameraSelect(triggerId: 6000, enabled: true);
                context.MoveNpc(spawnId: 700, patrolName: "MS2PatrolData4");
                context.AddCinematicTalk(npcId: 11001568, illustId: "11001568", script: "$52100043_QD__ENDING__6$", duration: 3000, align: Align.Left);
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetTimeScale(enabled: true, startScale: 0.8f, endScale: 0.03f, duration: 3.0f, interpolator: 1);
                context.SetEffect(triggerIds: new []{5002, 5006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_Talk_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_Talk_7 : TriggerState {
            internal StateEnding_Talk_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__7$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration02 : TriggerState {
            internal StateNarration02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateMap_Warf(context));
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration03 : TriggerState {
            internal StateNarration03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__9$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration04 : TriggerState {
            internal StateNarration04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__10$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNarration05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration05 : TriggerState {
            internal StateNarration05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__11$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNarration06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration06 : TriggerState {
            internal StateNarration06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100043_QD__ENDING__12$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMap_Warf(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMap_Warf : TriggerState {
            internal StateMap_Warf(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
                context.MoveUser(mapId: 52010068, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
