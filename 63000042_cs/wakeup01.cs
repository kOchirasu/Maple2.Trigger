namespace Maple2.Trigger._63000042_cs {
    public static class _wakeup01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001484}, questStates: new byte[]{2})) {
                    return new StateLodingDelay00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay00 : TriggerState {
            internal StateLodingDelay00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000042, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.CameraSelect(triggerId: 500, enable: true);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_D", duration: 6000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCDownIdle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle01 : TriggerState {
            internal StatePCDownIdle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StatePCDownIdle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCDownIdle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle02 : TriggerState {
            internal StatePCDownIdle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDoctorTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoctorTalk01 : TriggerState {
            internal StateDoctorTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000038, script: "$63000042_CS__WAKEUP01__0$", arg4: 4);
                context.SetSkip(state: new StateDoctorTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDoctorTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoctorTalk01Skip : TriggerState {
            internal StateDoctorTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateLookAround01(context);
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enable: false);
                context.CameraSelect(triggerId: 501, enable: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 18000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDoctorTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoctorTalk02 : TriggerState {
            internal StateDoctorTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 5000f);
                context.SetConversation(type: 2, spawnId: 11000038, script: "$63000042_CS__WAKEUP01__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDoctorTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoctorTalk03 : TriggerState {
            internal StateDoctorTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 5000f);
                context.SetConversation(type: 2, spawnId: 11000038, script: "$63000042_CS__WAKEUP01__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDoctorTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoctorTalk04 : TriggerState {
            internal StateDoctorTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 5000f);
                context.SetConversation(type: 2, spawnId: 11000038, script: "$63000042_CS__WAKEUP01__3$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSceneEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneEnd01 : TriggerState {
            internal StateSceneEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSceneEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneEnd02 : TriggerState {
            internal StateSceneEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enable: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
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
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
