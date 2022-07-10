namespace Maple2.Trigger._52010027_qd {
    public static class _main_quest10003101 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003101}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010027, portalId: 6005);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State집에서나옴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에서나옴 : TriggerState {
            internal State집에서나옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3006");
                context.CreateMonster(spawnIds: new []{801}, arg2: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010027_QD__MAIN_QUEST10003101__0$", duration: 3000, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State집에서나와서대사침(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에서나와서대사침 : TriggerState {
            internal State집에서나와서대사침(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Suprise_A"});
                context.AddBalloonTalk(spawnId: 0, msg: "$52010027_QD__MAIN_QUEST10003101__1$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State집에나와서대사침01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침01 : TriggerState {
            internal State집에나와서대사침01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 10000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003101__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State집에나와서대사침02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침02 : TriggerState {
            internal State집에나와서대사침02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State집에나와서대사침03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침03 : TriggerState {
            internal State집에나와서대사침03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 10000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003101__4$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State집에나와서대사침04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침04 : TriggerState {
            internal State집에나와서대사침04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.MoveNpc(spawnId: 801, patrolName: "MS2PatrolData_3005");
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003101__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__7$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__8$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003101__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new State집에나와서대사침05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침05 : TriggerState {
            internal State집에나와서대사침05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 801, sequenceName: "Attack_01_G");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__10$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010027, portalId: 6006);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01_1 : TriggerState {
            internal StateBattleStart01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52010027, portalId: 6006);
                context.CreateMonster(spawnIds: new []{801}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{801});
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart03 : TriggerState {
            internal StateBattleStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{802}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$52010027_QD__MAIN_QUEST10003101__12$", duration: 3000, boxId: 0);
                context.AddBalloonTalk(spawnId: 802, msg: "$52010027_QD__MAIN_QUEST10003101__13$", duration: 3000, delayTick: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{802})) {
                    return new State전투종료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010027, portalId: 6007);
                context.DestroyMonster(spawnIds: new []{802});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN_QUEST10003101__14$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 803, sequenceName: "Stun_A", duration: 160000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투종료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료03 : TriggerState {
            internal State전투종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
