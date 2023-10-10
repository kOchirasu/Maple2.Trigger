namespace Maple2.Trigger._52020032_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8001, visible: false, initialSequence: "Damg_Idle_B");
                context.SetInteractObject(interactIds: new []{10001281}, state: 0);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200100}, questStates: new byte[]{3})) {
                    return new StateDel_Npc(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200095}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200095}, questStates: new byte[]{2})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200095}, questStates: new byte[]{3})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200100}, questStates: new byte[]{1})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200100}, questStates: new byte[]{2})) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Damg_Idle_B");
                context.CreateMonster(spawnIds: new []{102, 201, 202, 203, 204, 205, 206, 207, 301}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{60200095}, questStates: new byte[]{1})) {
                    return new StateBattle_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_A : TriggerState {
            internal StateBattle_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 201, addSpawnId: 601);
                context.ChangeMonster(removeSpawnId: 202, addSpawnId: 602);
                context.ChangeMonster(removeSpawnId: 203, addSpawnId: 603);
                context.ChangeMonster(removeSpawnId: 204, addSpawnId: 604);
                context.ChangeMonster(removeSpawnId: 205, addSpawnId: 605);
                context.ChangeMonster(removeSpawnId: 206, addSpawnId: 606);
                context.ChangeMonster(removeSpawnId: 207, addSpawnId: 607);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603, 604, 605, 606, 607})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetSceneSkip(state: new StateBattle_B(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3001");
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Attack_01_B");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_B : TriggerState {
            internal StateBattle_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ChangeMonster(removeSpawnId: 301, addSpawnId: 701);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEvent_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetInteractObject(interactIds: new []{10001281}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200095}, questStates: new byte[]{2})) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetActor(triggerId: 8001, visible: false, initialSequence: "Damg_Idle_B");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel_Npc : TriggerState {
            internal StateDel_Npc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.SetActor(triggerId: 8001, visible: false, initialSequence: "Damg_Idle_B");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
