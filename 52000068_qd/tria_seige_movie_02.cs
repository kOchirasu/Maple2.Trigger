using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000068_qd {
    public static class _tria_seige_movie_02 {
        public class StateCinematicPhase2검사 : TriggerState {
            internal StateCinematicPhase2검사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{20002264}, questIds: new []{20002264}, questStates: new byte[]{3})) {
                    return new StateCinematicPhase2시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2시작 : TriggerState {
            internal StateCinematicPhase2시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000068, portalId: 3);
                context.CreateMonster(spawnIds: new []{10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034, 13000, 13001, 13002, 13003, 13004, 13005, 13006, 13007}, arg2: false);
                context.DestroyMonster(spawnIds: new []{11000, 11001, 11002, 11003, 11004, 11005, 11006, 11007}, arg2: false);
                context.SetVisibleBreakableObject(triggerIds: new []{5000, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012}, visible: false);
                context.SetSound(triggerId: 90001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicPhase2Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script01 : TriggerState {
            internal StateCinematicPhase2Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.CameraSelectPath(pathIds: new []{15000, 15001}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001966, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__0$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script01스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script01스킵 : TriggerState {
            internal StateCinematicPhase2Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script02(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script02 : TriggerState {
            internal StateCinematicPhase2Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001966, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__1$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script02스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script02스킵 : TriggerState {
            internal StateCinematicPhase2Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script03(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script03 : TriggerState {
            internal StateCinematicPhase2Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15002, 15003}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001901, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__2$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script03스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script03스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script03스킵 : TriggerState {
            internal StateCinematicPhase2Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script04(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script04 : TriggerState {
            internal StateCinematicPhase2Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001961, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__3$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script04스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script04스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script04스킵 : TriggerState {
            internal StateCinematicPhase2Script04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script04b(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script04b : TriggerState {
            internal StateCinematicPhase2Script04b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15005, 15006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001972, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__4$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script04b스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCinematicPhase2Script04b스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script04b스킵 : TriggerState {
            internal StateCinematicPhase2Script04b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script05(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script05 : TriggerState {
            internal StateCinematicPhase2Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001972, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__5$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script05스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script05스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script05스킵 : TriggerState {
            internal StateCinematicPhase2Script05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script05b(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script05b : TriggerState {
            internal StateCinematicPhase2Script05b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15100, 15101}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001970, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__17$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script05b스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script05b스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script05b스킵 : TriggerState {
            internal StateCinematicPhase2Script05b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script06(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script06 : TriggerState {
            internal StateCinematicPhase2Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15102, 15103}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__6$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script06스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script06스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script06스킵 : TriggerState {
            internal StateCinematicPhase2Script06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script07(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script07 : TriggerState {
            internal StateCinematicPhase2Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15104, 15105}, returnView: false);
                context.MoveNpc(spawnId: 13000, patrolName: "MS2PatrolData_top_ereb_go");
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__7$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script07스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script07스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script07스킵 : TriggerState {
            internal StateCinematicPhase2Script07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script08(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script08 : TriggerState {
            internal StateCinematicPhase2Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15106}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_sad", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__8$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script08스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script08스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script08스킵 : TriggerState {
            internal StateCinematicPhase2Script08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script09(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script09 : TriggerState {
            internal StateCinematicPhase2Script09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15107, 15108}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_closeEye", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__9$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script09스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script09스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script09스킵 : TriggerState {
            internal StateCinematicPhase2Script09스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script10(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script10 : TriggerState {
            internal StateCinematicPhase2Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__10$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script10스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script10스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script10스킵 : TriggerState {
            internal StateCinematicPhase2Script10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script11(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script11 : TriggerState {
            internal StateCinematicPhase2Script11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15109}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_closeEye", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__11$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script11스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script11스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script11스킵 : TriggerState {
            internal StateCinematicPhase2Script11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script12(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script12 : TriggerState {
            internal StateCinematicPhase2Script12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15110}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001973, script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__18$", arg4: 7);
                context.SetSkip(state: new StateCinematicPhase2Script12스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script12스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script12스킵 : TriggerState {
            internal StateCinematicPhase2Script12스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script13(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script13 : TriggerState {
            internal StateCinematicPhase2Script13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15111, 15112}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__12$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script13스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematicPhase2Script13스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script13스킵 : TriggerState {
            internal StateCinematicPhase2Script13스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script14(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script14 : TriggerState {
            internal StateCinematicPhase2Script14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__13$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script14스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script14스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script14스킵 : TriggerState {
            internal StateCinematicPhase2Script14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script15(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script15 : TriggerState {
            internal StateCinematicPhase2Script15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15113, 15114}, returnView: false);
                context.MoveNpc(spawnId: 13000, patrolName: "MS2PatrolData_top_ereb_back");
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_closeEye", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__14$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script15스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script15스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script15스킵 : TriggerState {
            internal StateCinematicPhase2Script15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script16(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script16 : TriggerState {
            internal StateCinematicPhase2Script16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_closeEye", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__15$", duration: 7000, align: Align.Center);
                context.SetSkip(state: new StateCinematicPhase2Script16스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicPhase2Script16스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script16스킵 : TriggerState {
            internal StateCinematicPhase2Script16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCinematicPhase2Script17(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicPhase2Script17 : TriggerState {
            internal StateCinematicPhase2Script17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{15115, 15116}, returnView: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000068_QD__TRIA_SEIGE_MOVIE_02__16$", duration: 7000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateFadeOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut : TriggerState {
            internal StateFadeOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateFadeOut_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_1 : TriggerState {
            internal StateFadeOut_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000001, portalId: 17);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
