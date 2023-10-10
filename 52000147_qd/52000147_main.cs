using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000147_qd {
    public static class _52000147_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5003, 5004, 5005}, visible: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: true);
                context.SetMeshAnimation(triggerIds: new []{4001, 4002}, visible: true, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{4003, 4004, 4005, 4006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State뚜벅뚜벅_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뚜벅뚜벅_01 : TriggerState {
            internal State뚜벅뚜벅_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State뚜벅뚜벅_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뚜벅뚜벅_02 : TriggerState {
            internal State뚜벅뚜벅_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000147_QD__52000147_MAIN__0$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State목격_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_01 : TriggerState {
            internal State목격_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State목격_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State목격_02 : TriggerState {
            internal State목격_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State목격_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_03 : TriggerState {
            internal State목격_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State목격_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_04 : TriggerState {
            internal State목격_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State목격_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_05 : TriggerState {
            internal State목격_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State목격_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_06 : TriggerState {
            internal State목격_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State목격_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_07 : TriggerState {
            internal State목격_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
                context.SetMeshAnimation(triggerIds: new []{4001, 4002}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State목격_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목격_08 : TriggerState {
            internal State목격_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State삼자대화_01(context));
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__1$", duration: 4000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_01 : TriggerState {
            internal State삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State삼자대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_02 : TriggerState {
            internal State삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State삼자대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_03 : TriggerState {
            internal State삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State삼자대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_04 : TriggerState {
            internal State삼자대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State삼자대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_05 : TriggerState {
            internal State삼자대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State하스터Combat_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000147_QD__52000147_MAIN__2$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State삼자대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_06 : TriggerState {
            internal State삼자대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State삼자대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_07 : TriggerState {
            internal State삼자대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State삼자대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_08 : TriggerState {
            internal State삼자대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__3$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_09 : TriggerState {
            internal State삼자대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State삼자대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_10 : TriggerState {
            internal State삼자대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__4$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_11 : TriggerState {
            internal State삼자대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__5$", duration: 2500, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_12 : TriggerState {
            internal State삼자대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__6$", duration: 4000, illustId: "DarkLord_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__7$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State삼자대화_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_13 : TriggerState {
            internal State삼자대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000147_QD__52000147_MAIN__8$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State삼자대화_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_14 : TriggerState {
            internal State삼자대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__9$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_15 : TriggerState {
            internal State삼자대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__10$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__11$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State삼자대화_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_16 : TriggerState {
            internal State삼자대화_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__12$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_17 : TriggerState {
            internal State삼자대화_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__13$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_18 : TriggerState {
            internal State삼자대화_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000147_QD__52000147_MAIN__14$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State삼자대화_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_19 : TriggerState {
            internal State삼자대화_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State삼자대화_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_20 : TriggerState {
            internal State삼자대화_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__15$", duration: 2500, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Attack_Idle_A", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State하스터Combat_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_01 : TriggerState {
            internal State하스터Combat_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State하스터Combat_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_02 : TriggerState {
            internal State하스터Combat_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State하스터Combat_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_03 : TriggerState {
            internal State하스터Combat_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201471, textId: 25201471);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State하스터Combat_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_04 : TriggerState {
            internal State하스터Combat_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201471);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State하스터Combat_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_05 : TriggerState {
            internal State하스터Combat_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__16$", duration: 2500, align: Align.Left);
                context.MoveUser(mapId: 52000147, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State하스터Combat_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_06 : TriggerState {
            internal State하스터Combat_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_B", duration: 60000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State하스터Combat_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터Combat_07 : TriggerState {
            internal State하스터Combat_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투후대화_02(context));
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__17$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State전투후대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State전투후대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03 : TriggerState {
            internal State전투후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투후대화_03_01(context));
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__18$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State전투후대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03_01 : TriggerState {
            internal State전투후대화_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State전투후대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_04 : TriggerState {
            internal State전투후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투후대화_05(context));
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__19$", duration: 3000, illustId: "DarkLord_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003382, script: "$52000147_QD__52000147_MAIN__20$", duration: 2500, illustId: "DarkLord_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State전투후대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_05 : TriggerState {
            internal State전투후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_06 : TriggerState {
            internal State전투후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_07 : TriggerState {
            internal State전투후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State전투후대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_08 : TriggerState {
            internal State전투후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_09 : TriggerState {
            internal State전투후대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2006");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_10 : TriggerState {
            internal State전투후대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005, 5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투후대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_11 : TriggerState {
            internal State전투후대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투후대화_12(context));
                context.AddCinematicTalk(npcId: 11003189, script: "$52000147_QD__52000147_MAIN__21$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State전투후대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_12 : TriggerState {
            internal State전투후대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_13 : TriggerState {
            internal State전투후대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_14 : TriggerState {
            internal State전투후대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State전투후대화_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_15 : TriggerState {
            internal State전투후대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000147_QD__52000147_MAIN__22$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000148, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
