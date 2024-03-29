namespace Maple2.Trigger._02000296_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 110, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 111, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 112, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 113, visible: false, animationEffect: false);
                context.DestroyMonster(spawnIds: new []{5001, 5002, 5003, 5004, 5100, 5005, 5006, 5007, 5012, 5013});
                context.SetEffect(triggerIds: new []{1000}, visible: true);
                context.SetEffect(triggerIds: new []{4000}, visible: false);
                context.SetMesh(triggerIds: new []{1001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1100, 1101}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, visible: true, arg3: 0, arg4: 100, arg5: 5f);
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: true);
                context.SetAgent(triggerIds: new []{1300, 1301}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5007, 5005, 5001, 5002, 5003, 5004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLoadingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 1, spawnId: 5005, script: "$02000296_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLoadingDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay03 : TriggerState {
            internal StateLoadingDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 1, spawnId: 5005, script: "$02000296_BF__MAIN__1$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMeetLennon01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetLennon01 : TriggerState {
            internal StateMeetLennon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMeetLennon02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetLennon02 : TriggerState {
            internal StateMeetLennon02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{5005});
                context.CreateMonster(spawnIds: new []{5012}, arg2: false);
                context.SetConversation(type: 1, spawnId: 5007, script: "$02000296_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 5007, script: "$02000296_BF__MAIN__3$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMeetLennon03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetLennon03 : TriggerState {
            internal StateMeetLennon03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: false);
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonLeave01 : TriggerState {
            internal StateLennonLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 5012, patrolName: "MS2PatrolData_5012");
                context.SetConversation(type: 1, spawnId: 5012, script: "$02000296_BF__MAIN__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLennonLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonLeave02 : TriggerState {
            internal StateLennonLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAgent(triggerIds: new []{1300, 1301}, visible: false);
                context.ChangeMonster(removeSpawnId: 5012, addSpawnId: 5006);
                context.ChangeMonster(removeSpawnId: 5007, addSpawnId: 5013);
                context.RemoveBalloonTalk(spawnId: 5012);
                context.RemoveBalloonTalk(spawnId: 5007);
                context.SetConversation(type: 1, spawnId: 5013, script: "$02000296_BF__MAIN__5$", arg4: 4, arg5: 1);
                context.MoveNpc(spawnId: 5013, patrolName: "MS2PatrolData_5009");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLennonLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5005});
                context.CreateMonster(spawnIds: new []{5012}, arg2: false);
                context.ChangeMonster(removeSpawnId: 5012, addSpawnId: 5006);
                context.ChangeMonster(removeSpawnId: 5007, addSpawnId: 5013);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonLeave03 : TriggerState {
            internal StateLennonLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 601, enabled: false);
                context.DestroyMonster(spawnIds: new []{5013});
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, visible: false, arg3: 500, arg4: 100, arg5: 5f);
                context.SetMesh(triggerIds: new []{1101}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 110, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 111, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 112, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 113, visible: true, animationEffect: true, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReactSoulBead01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReactSoulBead01 : TriggerState {
            internal StateReactSoulBead01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{1300, 1301}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01", boxIds: 9001);
                context.ShowGuideSummary(entityId: 20002961, textId: 20002961);
                context.SetConversation(type: 1, spawnId: 5006, script: "$02000296_BF__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReactSoulBead02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReactSoulBead02 : TriggerState {
            internal StateReactSoulBead02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002961);
                context.SetConversation(type: 1, spawnId: 5006, script: "$02000296_BF__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000500, 10000501, 10000502, 10000503}, arg2: 0)) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{4000}, visible: true);
                context.SetMesh(triggerIds: new []{1001}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{1000}, visible: false);
                context.SetConversation(type: 1, spawnId: 5006, script: "$02000296_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5100}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle03 : TriggerState {
            internal StateBossBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01", boxIds: 9001);
                context.ShowGuideSummary(entityId: 20002963, textId: 20002963, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{5100})) {
                    return new StateReadyToMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove01 : TriggerState {
            internal StateReadyToMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5100, 5001, 5002, 5003, 5004});
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, visible: true, arg3: 0, arg4: 100, arg5: 5f);
                context.SetAgent(triggerIds: new []{1300, 1301}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToMove02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove02 : TriggerState {
            internal StateReadyToMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.MoveNpc(spawnId: 5006, patrolName: "MS2PatrolData_5009");
                context.SetConversation(type: 1, spawnId: 5006, script: "$02000296_BF__MAIN__9$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToMove03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove03 : TriggerState {
            internal StateReadyToMove03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002962, textId: 20002962, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9002, spawnIds: new []{5006})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5006});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
