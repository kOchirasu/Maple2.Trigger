using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000116_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100001}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100001}, questStates: new byte[]{2})) {
                    return new StateFadeout(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100001}, questStates: new byte[]{3})) {
                    return new StateFadeout(context);
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
                context.AddCinematicTalk(npcId: 11003163, illustId: "Nelf_normal", script: "$52000116_QD__MAIN__0$", duration: 4000, align: Align.Right);
                context.SetSceneSkip(state: new StateFadeout(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJordyspawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyspawn : TriggerState {
            internal StateJordyspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000116, portalId: 2);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJordyhelp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyhelp : TriggerState {
            internal StateJordyhelp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
                context.SetConversation(type: 2, spawnId: 11001838, script: "$52000116_QD__MAIN__1$", arg4: 1, arg5: 0);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWowspawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWowspawn : TriggerState {
            internal StateWowspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000116_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera : TriggerState {
            internal StateCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWow(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWow : TriggerState {
            internal StateWow(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Attack_01_A");
                context.SetConversation(type: 2, spawnId: 11003179, script: "$52000116_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSave : TriggerState {
            internal StateSave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Sit_Down_A", duration: 400000f);
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattleready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleready : TriggerState {
            internal StateBattleready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104}, arg2: true, arg3: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Attack_Idle_A", duration: 10000f);
                context.CameraReset(interpolationTime: 0.5f);
                context.MoveUserPath(patrolName: "MS2PatrolData_3003");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000116_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000116_QD__MAIN__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000116_QD__MAIN__6$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCamera_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_A : TriggerState {
            internal StateCamera_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMotion(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMotion : TriggerState {
            internal StateMotion(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Angry_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLol : TriggerState {
            internal StateLol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Damg_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRun(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRun : TriggerState {
            internal StateRun(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3004");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102, 103, 104});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000116, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateThank(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThank : TriggerState {
            internal StateThank(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Talk_A");
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003164, script: "$52000116_QD__MAIN__7$", duration: 2000);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEndready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndready : TriggerState {
            internal StateEndready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$52000116_QD__MAIN__8$", script: "$52000116_QD__MAIN__9$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "jordy");
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
