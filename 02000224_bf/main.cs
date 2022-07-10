namespace Maple2.Trigger._02000224_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001562}, questStates: new byte[]{2})) {
                    return new StateNext맵으로(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001562}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic00(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001561}, questStates: new byte[]{3})) {
                    return new State아르마노Exists(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001561}, questStates: new byte[]{2})) {
                    return new State아르마노Exists(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001561}, questStates: new byte[]{1})) {
                    return new State아르마노Exists(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001560}, questStates: new byte[]{3})) {
                    return new State아르마노Exists(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001560}, questStates: new byte[]{2})) {
                    return new State아르마노Exists(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001560}, questStates: new byte[]{1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Exists : TriggerState {
            internal State아르마노Exists(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001562}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001562}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext맵으로 : TriggerState {
            internal StateNext맵으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic00 : TriggerState {
            internal StateSetupCinematic00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State아르마노말썽_스킵완료(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.MoveUser(mapId: 02000224, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State티니에Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Spawn : TriggerState {
            internal State티니에Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__18$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Bore_C", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에이동01 : TriggerState {
            internal State티니에이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_girl01");
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01 : TriggerState {
            internal State아르마노Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003242, script: "$02000224_BF__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State아르마노Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State티니에Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01_skip : TriggerState {
            internal State아르마노Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에Script01(context);
            }

            public override void OnExit() { }
        }

        private class State티니에Script01 : TriggerState {
            internal State티니에Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__2$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State티니에Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6765)) {
                    return new State아르마노Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script01_skip : TriggerState {
            internal State티니에Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script02(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02 : TriggerState {
            internal State아르마노Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_girl02");
                context.SetConversation(type: 2, spawnId: 11003242, script: "$02000224_BF__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State아르마노Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4597)) {
                    return new State티니에Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02_skip : TriggerState {
            internal State아르마노Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에Script02(context);
            }

            public override void OnExit() { }
        }

        private class State티니에Script02 : TriggerState {
            internal State티니에Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__4$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State티니에Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7471)) {
                    return new State티니에이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script02_skip : TriggerState {
            internal State티니에Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에이동02(context);
            }

            public override void OnExit() { }
        }

        private class State티니에이동02 : TriggerState {
            internal State티니에이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_girl02");
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__5$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10109)) {
                    return new State티니에Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script03 : TriggerState {
            internal State티니에Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State티니에Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9090)) {
                    return new State아르마노Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script03_skip : TriggerState {
            internal State티니에Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script03(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script03 : TriggerState {
            internal State아르마노Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003242, script: "$02000224_BF__MAIN__7$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State아르마노Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5146)) {
                    return new State티니에Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script03_skip : TriggerState {
            internal State아르마노Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에Script04(context);
            }

            public override void OnExit() { }
        }

        private class State티니에Script04 : TriggerState {
            internal State티니에Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__8$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State티니에Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7418)) {
                    return new State아르마노Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script04_skip : TriggerState {
            internal State티니에Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script04(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script04 : TriggerState {
            internal State아르마노Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003242, script: "$02000224_BF__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State아르마노Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script04_skip : TriggerState {
            internal State아르마노Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script05(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script05 : TriggerState {
            internal State아르마노Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetConversation(type: 2, spawnId: 11003242, script: "$02000224_BF__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아르마노Script05_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3030)) {
                    return new State아르마노탈주(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script05_skip : TriggerState {
            internal State아르마노Script05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노탈주(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노탈주 : TriggerState {
            internal State아르마노탈주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State티니에Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script05 : TriggerState {
            internal State티니에Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_girl03");
                context.DestroyMonster(spawnIds: new []{101});
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__11$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State티니에Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script06 : TriggerState {
            internal State티니에Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC01");
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__12$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Bore_C", duration: 4000f);
                context.SetSkip(state: new State티니에Script06_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11023)) {
                    return new StatePCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script06_skip : TriggerState {
            internal State티니에Script06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StatePCScript01(context);
            }

            public override void OnExit() { }
        }

        private class StatePCScript01 : TriggerState {
            internal StatePCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$02000224_BF__MAIN__13$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script07 : TriggerState {
            internal State티니에Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__14$", arg4: 4, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "ChatUp_A");
                context.SetSkip(state: new State티니에Script07_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7810)) {
                    return new StatePCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script07_skip : TriggerState {
            internal State티니에Script07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에Script08(context);
            }

            public override void OnExit() { }
        }

        private class StatePCScript02 : TriggerState {
            internal StatePCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$02000224_BF__MAIN__15$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script08 : TriggerState {
            internal State티니에Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__16$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State티니에Script08_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7497)) {
                    return new State티니에Script09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Script08_skip : TriggerState {
            internal State티니에Script08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State티니에Script09(context);
            }

            public override void OnExit() { }
        }

        private class State티니에Script09 : TriggerState {
            internal State티니에Script09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003243, script: "$02000224_BF__MAIN__17$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7157)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노말썽_스킵완료 : TriggerState {
            internal State아르마노말썽_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 103});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "foolishson");
                context.MoveUser(mapId: 02000054, portalId: 10);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
