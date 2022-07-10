using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000073_cs {
    public static class _63000073_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117}, arg2: true);
                context.SetLadder(triggerId: 6001, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 6002, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 6003, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 6004, visible: false, animationEffect: false);
                context.SetMesh(triggerIds: new []{4001}, visible: true);
                context.SetMesh(triggerIds: new []{4002}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000372}, questStates: new byte[]{3})) {
                    return new State전투만(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000372}, questStates: new byte[]{2})) {
                    return new State퀘완료가능재입장(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000372}, questStates: new byte[]{1})) {
                    return new StateWait_01(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new State전투만(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투만 : TriggerState {
            internal State전투만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{115})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetLadder(triggerId: 6001, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6002, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6003, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6004, visible: true, animationEffect: true);
            }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{121}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossExit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossExit_01 : TriggerState {
            internal State보BossExit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State보BossExit_03(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossExit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossExit_02 : TriggerState {
            internal State보BossExit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2001");
                context.AddBalloonTalk(spawnId: 121, msg: "$63000073_CS__63000073_MAIN__0$", duration: 2500, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보BossExit_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossExit_03 : TriggerState {
            internal State보BossExit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossExit_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{121});
            }
        }

        private class State보BossExit_04 : TriggerState {
            internal State보BossExit_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 26300731, textId: 26300731);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{115})) {
                    return new StateLadder_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder_01 : TriggerState {
            internal StateLadder_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300731);
                context.SetLadder(triggerId: 6001, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6002, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6003, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6004, visible: true, animationEffect: true);
                context.ShowGuideSummary(entityId: 26300733, textId: 26300733);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001385}, arg2: 0)) {
                    return new State트렁크오픈_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_01 : TriggerState {
            internal State트렁크오픈_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300733);
                context.CreateMonster(spawnIds: new []{122}, arg2: false);
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.SetMesh(triggerIds: new []{4002}, visible: true);
                context.ShowGuideSummary(entityId: 26300732, textId: 26300732);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{30000372}, questStates: new byte[]{2})) {
                    return new State트렁크오픈_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘완료가능재입장 : TriggerState {
            internal State퀘완료가능재입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{122}, arg2: false);
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.SetMesh(triggerIds: new []{4002}, visible: true);
                context.SetLadder(triggerId: 6001, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6002, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6003, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 6004, visible: true, animationEffect: true);
                context.MoveUser(mapId: 63000073, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트렁크오픈_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_02 : TriggerState {
            internal State트렁크오픈_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.HideGuideSummary(entityId: 26300732);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State트렁크오픈_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_03 : TriggerState {
            internal State트렁크오픈_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트렁크오픈_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_04 : TriggerState {
            internal State트렁크오픈_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State에이든Exit_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에이든대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_01 : TriggerState {
            internal State에이든대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 122, sequenceName: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에이든대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_02 : TriggerState {
            internal State에이든대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004359, script: "$63000073_CS__63000073_MAIN__1$", duration: 2500, align: Align.Right, illustId: "0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에이든대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_03 : TriggerState {
            internal State에이든대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에이든대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_04 : TriggerState {
            internal State에이든대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 2500f);
                context.AddCinematicTalk(npcId: 0, script: "$63000073_CS__63000073_MAIN__2$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에이든대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_05 : TriggerState {
            internal State에이든대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 2500f);
                context.AddCinematicTalk(npcId: 0, script: "$63000073_CS__63000073_MAIN__3$", duration: 4500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에이든대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_06 : TriggerState {
            internal State에이든대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에이든대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_07 : TriggerState {
            internal State에이든대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 3500f);
                context.AddCinematicTalk(npcId: 11004359, script: "$63000073_CS__63000073_MAIN__4$", duration: 3500, align: Align.Right, illustId: "0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에이든대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든대화_08 : TriggerState {
            internal State에이든대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 4500f);
                context.AddCinematicTalk(npcId: 11004359, script: "$63000073_CS__63000073_MAIN__5$", duration: 4500, align: Align.Right, illustId: "0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에이든Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에이든Exit_01 : TriggerState {
            internal State에이든Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{122});
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
