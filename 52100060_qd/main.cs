using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100060_qd {
    public static class _main {
        public class StateQuestDungeonStart : TriggerState {
            internal StateQuestDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50100320}, questStates: new byte[]{3})) {
                    return new StateTeleport02000487(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50100320}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50100320}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 1, enabled: true);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{600}, visible: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1000})) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52100060_QD__MAIN__12$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_Move_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_Move_01 : TriggerState {
            internal StateCamera_Move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{600}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC_Show(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC_Show : TriggerState {
            internal StateNPC_Show(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateTeleport02000487(context));
                context.CreateMonster(spawnIds: new []{1, 2}, arg2: false);
                context.SetNpcRotation(spawnId: 1, rotation: 180);
                context.SetNpcRotation(spawnId: 2, rotation: 180);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC_Change_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC_Change_1 : TriggerState {
            internal StateNPC_Change_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1, 2}, arg2: false);
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
                context.CameraSelectPath(pathIds: new []{2, 3}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_1 : TriggerState {
            internal StateTalk_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: false);
                context.CameraSelect(triggerId: 4, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52100060_QD__MAIN__0$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_2 : TriggerState {
            internal StateTalk_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 5, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__1$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__2$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_3 : TriggerState {
            internal StateTalk_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{10, 11, 12}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__3$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalk_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_4 : TriggerState {
            internal StateTalk_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4, enabled: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52100060_QD__MAIN__4$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_5 : TriggerState {
            internal StateTalk_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6, 7}, returnView: false);
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_6 : TriggerState {
            internal StateTalk_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{77, 78}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52100060_QD__MAIN__6$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_7 : TriggerState {
            internal StateTalk_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52100060_QD__MAIN__7$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_8 : TriggerState {
            internal StateTalk_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 44, enabled: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{200});
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__8$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalk_9(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_9 : TriggerState {
            internal StateTalk_9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{13, 14, 15}, returnView: false);
                context.SetEffect(triggerIds: new []{600}, visible: false);
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__9$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalk_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_10 : TriggerState {
            internal StateTalk_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 200, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11001593, illustId: "11001593", script: "$52100060_QD__MAIN__10$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalk_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_11 : TriggerState {
            internal StateTalk_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 16, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", script: "$52100060_QD__MAIN__11$", duration: 2000, align: Align.Right);
                context.CameraSelect(triggerId: 8, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC_Attack_Move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC_Attack_Move : TriggerState {
            internal StateNPC_Attack_Move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 0.5f, endScale: 0.3f, duration: 3.0f, interpolator: 1);
                context.CameraSelectPath(pathIds: new []{8, 9}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData3");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTeleport02000487(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleport02000487 : TriggerState {
            internal StateTeleport02000487(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{-1});
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 02000487, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
