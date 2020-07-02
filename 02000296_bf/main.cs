namespace Maple2.Trigger._02000296_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 110, arg2: false, arg3: false);
                context.SetLadder(arg1: 111, arg2: false, arg3: false);
                context.SetLadder(arg1: 112, arg2: false, arg3: false);
                context.SetLadder(arg1: 113, arg2: false, arg3: false);
                context.DestroyMonster(arg1: new[] {5001, 5002, 5003, 5004, 5100, 5005, 5006, 5007, 5012, 5013});
                context.SetEffect(arg1: new[] {1000}, arg2: true);
                context.SetEffect(arg1: new[] {4000}, arg2: false);
                context.SetMesh(arg1: new[] {1001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1100, 1101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, arg2: true, arg3: 0, arg4: 100, arg5: 5f);
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: true);
                context.SetAgent(arg1: new[] {1300, 1301}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {5007, 5005, 5001, 5002, 5003, 5004}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 5005, arg3: "$02000296_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 5005, arg3: "$02000296_BF__MAIN__1$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {5005});
                context.CreateMonster(arg1: new[] {5012}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 5007, arg3: "$02000296_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 5007, arg3: "$02000296_BF__MAIN__3$", arg4: 3, arg5: 3);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: false);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveNpc(arg1: 5012, arg2: "MS2PatrolData_5012");
                context.SetConversation(arg1: 1, arg2: 5012, arg3: "$02000296_BF__MAIN__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetAgent(arg1: new[] {1300, 1301}, arg2: false);
                context.ChangeMonster(arg1: 5012, arg2: 5006);
                context.ChangeMonster(arg1: 5007, arg2: 5013);
                context.RemoveBalloonTalk(spawnPointId: 5012);
                context.RemoveBalloonTalk(spawnPointId: 5007);
                context.SetConversation(arg1: 1, arg2: 5013, arg3: "$02000296_BF__MAIN__5$", arg4: 4, arg5: 1);
                context.MoveNpc(arg1: 5013, arg2: "MS2PatrolData_5009");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {5005});
                context.CreateMonster(arg1: new[] {5012}, arg2: false);
                context.ChangeMonster(arg1: 5012, arg2: 5006);
                context.ChangeMonster(arg1: 5007, arg2: 5013);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 601, arg2: false);
                context.DestroyMonster(arg1: new[] {5013});
                context.SetMesh(arg1: new[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, arg2: false, arg3: 500, arg4: 100, arg5: 5f);
                context.SetMesh(arg1: new[] {1101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 110, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 111, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 112, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 113, arg2: true, arg3: true, arg4: 0);
            }

            public override TriggerState Execute() {
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
                context.SetAgent(arg1: new[] {1300, 1301}, arg2: true);
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002961, textId: 20002961);
                context.SetConversation(arg1: 1, arg2: 5006, arg3: "$02000296_BF__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 5006, arg3: "$02000296_BF__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000500, 10000501, 10000502, 10000503}, arg2: 0)) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {4000}, arg2: true);
                context.SetMesh(arg1: new[] {1001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new[] {1000}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 5006, arg3: "$02000296_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {5100}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002963, textId: 20002963, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {5100})) {
                    return new StateReadyToMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove01 : TriggerState {
            internal StateReadyToMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5100, 5001, 5002, 5003, 5004});
                context.SetMesh(arg1: new[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209}, arg2: true, arg3: 0, arg4: 100, arg5: 5f);
                context.SetAgent(arg1: new[] {1300, 1301}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.MoveNpc(arg1: 5006, arg2: "MS2PatrolData_5009");
                context.SetConversation(arg1: 1, arg2: 5006, arg3: "$02000296_BF__MAIN__9$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new[] {5006})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5006});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}