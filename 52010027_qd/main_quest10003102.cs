namespace Maple2.Trigger._52010027_qd {
    public static class _main_quest10003102 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003102}, questStates: new byte[]{1})) {
                    return new StateDel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel : TriggerState {
            internal StateDel(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010027, portalId: 6007);
                context.CreateMonster(spawnIds: new []{803}, arg2: true);
                context.SetNpcEmotionLoop(spawnId: 803, sequenceName: "Stun_A", duration: 160000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔피씨와말을걸면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔피씨와말을걸면 : TriggerState {
            internal State엔피씨와말을걸면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossMonster는소멸Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossMonster는소멸Prepare : TriggerState {
            internal StateBossMonster는소멸Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State완료조건(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 11003469, script: "$52010027_QD__MAIN_QUEST10003102__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003469, script: "$52010027_QD__MAIN_QUEST10003102__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateBossMonster는소멸Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossMonster는소멸Prepare01 : TriggerState {
            internal StateBossMonster는소멸Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003102__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003102__3$", duration: 3000);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBossMonster는소멸Prepare02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossMonster는소멸Prepare02 : TriggerState {
            internal StateBossMonster는소멸Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11003469, script: "$52010027_QD__MAIN_QUEST10003102__4$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003469, script: "$52010027_QD__MAIN_QUEST10003102__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003469, script: "$52010027_QD__MAIN_QUEST10003102__6$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateBossMonster는소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossMonster는소멸 : TriggerState {
            internal StateBossMonster는소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossMonster는소멸_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossMonster는소멸_01 : TriggerState {
            internal StateBossMonster는소멸_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{803});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003102__7$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003102__8$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN_QUEST10003102__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State전투종료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State완료조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료조건 : TriggerState {
            internal State완료조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "WindValleyBattle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000051, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
