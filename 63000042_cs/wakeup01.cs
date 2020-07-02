namespace Maple2.Trigger._63000042_cs {
    public static class _wakeup01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001484}, arg3: new byte[] {2})) {
                    return new StateLodingDelay00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay00 : TriggerState {
            internal StateLodingDelay00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000042, arg2: 10);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetPcEmotionLoop(arg1: "Down_Idle_D", arg2: 6000f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(arg1: "PCDownIdle02");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetSkip();
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11000038, arg3: "$63000042_CS__WAKEUP01__0$", arg4: 4);
                context.SetSkip(arg1: "DoctorTalk01Skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateLookAround01(context);
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.CameraSelect(arg1: 501, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 18000f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.SetConversation(arg1: 2, arg2: 11000038, arg3: "$63000042_CS__WAKEUP01__1$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.SetConversation(arg1: 2, arg2: 11000038, arg3: "$63000042_CS__WAKEUP01__2$", arg4: 4);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.SetConversation(arg1: 2, arg2: 11000038, arg3: "$63000042_CS__WAKEUP01__3$", arg4: 4);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 501, arg2: false);
                context.SetPcEmotionSequence(arg1: "Idle_A");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}